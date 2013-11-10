﻿using Library.Contracts;
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

        bool IsChildOf(IEnumerable<Rubric> source, Rubric target, Rubric level) {
            if (target.Parent == null) {
                return false;
            }
            if (target.Id == target.Parent.Id) {
                return true;
            }
            if (level != null && target.Parent.Id == level.Id) {
                return true;
            }

            var childs = source.Where(r => r.Parent != null && r.Parent.Id == level.Id).ToArray();
            if (childs.Length == 0) {
                return false;
            }
            return (from c in childs
                    where IsChildOf(source, target, c)
                    select c).Count() != 0;
        }

        public Rubric UpdateRubric(Rubric rubric) {
            var rubrics = GetRubrics();
            if (IsChildOf(rubrics, rubric, rubric)) {
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

        public IEnumerable<Book> GetBooks(Rubric rubric = null, Publisher publisher = null, string search = "") {
            var books = Ninject.Get<GetBooksQuery>().Execute();

            if (rubric != null) {
                var rubrics = GetRubrics();
                var dictionary = rubrics.ToDictionary(r => r.Id);
                if (dictionary.ContainsKey(rubric.Id)) {
                    rubric = dictionary[rubric.Id];
                    books = from b in books
                            where b.Rubric.Id == rubric.Id || dictionary.ContainsKey(b.Rubric.Id) && IsChildOf(rubrics, dictionary[b.Rubric.Id], rubric)
                            select b;
                }
            }
            books = publisher.Return(p => books.Where(b => b.Publisher.Id == p.Id), books);
            books = string.IsNullOrEmpty(search) ? books : from b in books
                                                           let s = search.ToLower()
                                                           where b.Name.ToLower().Contains(s) || b.Annotation.ToLower().Contains(s)
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
            var existsAuthors = GetBookAuthors(book);
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
            throw new NotImplementedException();
        }

        public Author UpdateAuthor(Author author) {
            throw new NotImplementedException();
        }

        public Author DeleteAuthor(Author author) {
            throw new NotImplementedException();
        }
    }
}
