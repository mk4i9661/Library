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
using System.Monads;
using Library.DataAccess.DBInterop.Executors;

namespace Library.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
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

        void ClearTree(IEnumerable<Rubric> rubrics) {
            foreach (var rubric in rubrics) {
                rubric.Parent = rubric.Parent == null ? null : new Rubric() {
                    Id = rubric.Parent.Id,
                    Name = rubric.Parent.Name,
                };
                ClearTree(rubric.Childs);
            }
        }

        public IEnumerable<Rubric> GetRubrics() {
            return Ninject.Get<GetRubricsQuery>().Execute();
        }

        public IEnumerable<Rubric> GetRubricsHierarchy() {
            var rubrics = Rubric.FormTree(Ninject.Get<GetRubricsQuery>().Execute()).ToArray();
            ClearTree(rubrics);
            return rubrics;
        }

        public Rubric AddRubric(Rubric rubric) {
            var query = Ninject.Get<InsertRubricQuery>();
            query.Rubric = rubric;
            query.Execute();
            return rubric;
        }

        public Rubric UpdateRubric(Rubric rubric) {
            var rubrics = GetRubrics();
            if (Rubric.IsChildOf(rubrics, rubric, rubric)) {
                throw new Exception("Обнаружена циклическая зависимость рубрик. Обновление рубрики невозможно");
            }

            var query = Ninject.Get<UpdateRubricQuery>();
            query.Rubric = rubric;
            query.Execute();
            return rubric;
        }

        public Rubric DeleteRubric(Rubric rubric) {
            var query = Ninject.Get<DeleteRubricQuery>();
            query.Rubric = rubric;
            query.Execute();
            return rubric;
        }

        public IEnumerable<Book> GetBooks(Rubric rubric = null, Publisher publisher = null, Author author = null, string search = "") {
            var books = Ninject.Get<GetBooksQuery>().Execute();

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
            if (author != null)
            {
                var query = Ninject.Get<GetAuthorBooksQuery>();
                query.Author = author;
                var authorBooks = query.Execute();
                books = from b in books
                        join ab in authorBooks on b.Id equals ab.Id
                        select b;
            }
            books = publisher.Return(p => books.Where(b => b.Publisher.Id == p.Id), books);
            books = string.IsNullOrEmpty(search) ? books : from b in books
                                                           let s = search.ToLower()
                                                           where b.Name.ToLower().Contains(s) || (b.Annotation ?? string.Empty).ToLower().Contains(s)
                                                           select b;
            return books.ToArray();
        }

        public Book AddBook(Book book) {
            var query = Ninject.Get<InsertBookQuery>();
            query.Book = book;
            query.Execute();
            return book;
        }

        public Book UpdateBook(Book book) {
            var query = Ninject.Get<UpdateBookQuery>();
            query.Book = book;
            query.Execute();
            return book;
        }

        public Book DeleteBook(Book book) {
            var query = Ninject.Get<DeleteBookQuery>();
            query.Book = book;
            query.Execute();
            return book;
        }

        public IEnumerable<Author> GetBookAuthors(Book book) {
            var query = Ninject.Get<GetBookAuthorsQuery>();
            query.Book = book;
            return query.Execute();
        }

        public IEnumerable<Author> SetBookAuthors(Book book, IEnumerable<Author> authors) {
            var existsAuthors = GetBookAuthors(book).ToArray();
            var existsDictionary = existsAuthors.ToDictionary(a => a.Id);
            var insertingDictionary = authors.ToDictionary(a => a.Id);

            var provider = Factory.Get();
            var executor = Ninject.Get<Executor>();
            //сначала удаляем те, что существуют, но больше не нужные
            //затем добавляем те, что не существуют
            executor.ExecuteNonQueries((from a in existsAuthors
                                        where !insertingDictionary.ContainsKey(a.Id)
                                        select (BookAuthorQuery)new DeleteBookAuthorQuery(provider) {
                                            Book = book,
                                            Author = a
                                        })
                                        .Union(from a in authors
                                               where !existsDictionary.ContainsKey(a.Id)
                                               select (BookAuthorQuery)new InsertBookAuthorQuery(provider) {
                                                   Book = book,
                                                   Author = a
                                               }));
            return authors;
        }

        public IEnumerable<Author> GetAuthors() {
            return Ninject.Get<GetAuthorsQuery>().Execute();
        }

        public Author AddAuthor(Author author) {
            var query = Ninject.Get<InsertAuthorQuery>();
            query.Author = author;
            query.Execute();
            return author;
        }

        public Author UpdateAuthor(Author author) {
            var query = Ninject.Get<UpdateAuthorQuery>();
            query.Author = author;
            query.Execute();
            return author;
        }

        public Author DeleteAuthor(Author author) {
            var query = Ninject.Get<DeleteAuthorQuery>();
            query.Author = author;
            query.Execute();
            return author;
        }
    }
}
