using Library.Contracts;
using Library.DataContracts.Concrete;
using Library.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Library.DataAccess.DBInterop.Queries.Concrete;
using System.Monads;

namespace Library.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ChiefService : AbstractService, IChief
    {
        public IEnumerable<ReportBook> GetBooks(Rubric rubric = null, Publisher publisher = null, string search = "") {
            var books = Ninject.Get<GetReportBooksQuery>().Execute();

            if (rubric != null) {
                var rubrics = GetRubrics();
                var dictionary = rubrics.ToDictionary(r => r.Id);
                if (dictionary.ContainsKey(rubric.Id)) {
                    rubric = dictionary[rubric.Id];
                    books = from b in books
                            where b.Rubric.Id == rubric.Id || dictionary.ContainsKey(b.Rubric.Id) && Rubric.IsChildOf(rubrics, dictionary[b.Rubric.Id], rubric)
                            select b;
                }
            }
            books = publisher.Return(p => books.Where(b => b.Publisher.Id == p.Id), books);
            books = string.IsNullOrEmpty(search) ? books : from b in books
                                                           let s = search.ToLower()
                                                           where b.Name.ToLower().Contains(s) || (b.Annotation ?? string.Empty).ToLower().Contains(s)
                                                           select b;
            return books.ToArray();
        }

        public IEnumerable<Publisher> GetPublishers() {
            return Ninject.Get<GetPublishersQuery>().Execute();
        }

        public IEnumerable<Rubric> GetRubrics() {
            return Ninject.Get<GetRubricsQuery>().Execute();
        }

        public IEnumerable<Reader> GetBookHolders(Book book) {
            var query = Ninject.Get<GetBookHoldersQuery>();
            query.Book = book;
            return query.Execute();
        }

        public IEnumerable<Reader> GetBookObligators(Book book) {
            var query = Ninject.Get<GetBookObligatorsQuery>();
            query.Book = book;
            return query.Execute();
        }
    }
}
