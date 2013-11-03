using Library.Contracts;
using Library.DataAccess.DBInterop.Queries.Concrete;
using Library.DataContracts.Concrete;
using Library.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Library.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class BibliographerService : AbstractService, IBibliographer
    {
        public IEnumerable<Publisher> GetPublishers() {
            return Ninject.Get<GetPublishersQuery>().Execute();
        }

        public Publisher AddPublisher(Publisher publisher) {
            var query = Ninject.Get<InsertPublisherQuery>();
            query.Publisher = publisher;
            query.Execute();
            return publisher;
        }

        public Publisher UpdatePublisher(Publisher publisher) {
            var query = Ninject.Get<UpdatePublisherQuery>();
            query.Publisher = publisher;
            query.Execute();
            return publisher;
        }

        public Publisher DeletePublisher(Publisher publisher) {
            var query = Ninject.Get<DeletePublisherQuery>();
            query.Publisher = publisher;
            query.Execute();
            return publisher;
        }

        public IEnumerable<Rubric> GetRubrics() {
            return Ninject.Get<GetRubricsQuery>().Execute();
        }

        public Rubric AddRubric(Rubric rubric) {
            throw new NotImplementedException();
        }

        public Rubric UpdateRubric(Rubric rubric) {
            throw new NotImplementedException();
        }

        public Rubric DeleteRubric(Rubric rubric) {
            throw new NotImplementedException();
        }
    }
}
