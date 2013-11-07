using Library.Contracts;
using Library.DataContracts.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Proxies
{
    public class BibliographerProxy : AuthenticableProxy<IBibliographer>, IBibliographer
    {
        public BibliographerProxy(AuthenticationData data)
            : base(data) {

        }

        public IEnumerable<Publisher> GetPublishers() {
            return ExecuteScoped(() => Channel.GetPublishers());
        }

        public Publisher AddPublisher(Publisher publisher) {
            return ExecuteScoped(() => Channel.AddPublisher(publisher));
        }

        public Publisher UpdatePublisher(Publisher publisher) {
            return ExecuteScoped(() => Channel.UpdatePublisher(publisher));
        }

        public Publisher DeletePublisher(Publisher publisher) {
            return ExecuteScoped(() => Channel.DeletePublisher(publisher));
        }

        public IEnumerable<Rubric> GetRubrics() {
            return ExecuteScoped(() => Channel.GetRubrics());
        }

        public IEnumerable<Rubric> GetRubricsHierarchy() {
            return ExecuteScoped(() => Channel.GetRubricsHierarchy());
        }

        public Rubric AddRubric(Rubric rubric) {
            return ExecuteScoped(() => Channel.AddRubric(rubric));
        }

        public Rubric UpdateRubric(Rubric rubric) {
            return ExecuteScoped(() => Channel.UpdateRubric(rubric));
        }

        public Rubric DeleteRubric(Rubric rubric) {
            return ExecuteScoped(() => Channel.DeleteRubric(rubric));
        }

        public IEnumerable<Book> GetBooks(Rubric rubric = null, Publisher publisher = null, string search = "") {
            return ExecuteScoped(() => Channel.GetBooks(rubric, publisher, search));
        }

        public Book AddBook(Book book) {
            return ExecuteScoped(() => Channel.AddBook(book));
        }

        public Book UpdateBook(Book book) {
            return ExecuteScoped(() => Channel.UpdateBook(book));
        }

        public Book DeleteBook(Book book) {
            return ExecuteScoped(() => Channel.DeleteBook(book));
        }


        public IEnumerable<Author> GetAuthors() {
            return ExecuteScoped(() => Channel.GetAuthors());
        }

        public Author AddAuthor(Author author) {
            return ExecuteScoped(() => Channel.AddAuthor(author));
        }

        public Author UpdateAuthor(Author author) {
            return ExecuteScoped(() => Channel.UpdateAuthor(author));
        }

        public Author DeleteAuthor(Author author) {
            return ExecuteScoped(() => Channel.DeleteAuthor(author));
        }
    }
}
