using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Library.DataContracts.Concrete;

namespace Library.Contracts
{
    [ServiceContract]
    public interface IBibliographer
    {
        [OperationContract]
        IEnumerable<Publisher> GetPublishers();
        [OperationContract]
        Publisher AddPublisher(Publisher publisher);
        [OperationContract]
        Publisher UpdatePublisher(Publisher publisher);
        [OperationContract]
        Publisher DeletePublisher(Publisher publisher);

        [OperationContract]
        IEnumerable<Rubric> GetRubricsHierarchy();
        [OperationContract]
        IEnumerable<Rubric> GetRubrics();
        [OperationContract]
        Rubric AddRubric(Rubric rubric);
        [OperationContract]
        Rubric UpdateRubric(Rubric rubric);
        [OperationContract]
        Rubric DeleteRubric(Rubric rubric);

        [OperationContract]
        IEnumerable<Book> GetBooks(Rubric rubric = null, Publisher publisher = null, string search = "");
        [OperationContract]
        Book AddBook(Book book);
        [OperationContract]
        Book UpdateBook(Book book);
        [OperationContract]
        Book DeleteBook(Book book);
        [OperationContract]
        IEnumerable<Author> GetBookAuthors(Book book);
        [OperationContract]
        IEnumerable<Author> SetBookAuthors(Book book, IEnumerable<Author> authors);

        [OperationContract]
        IEnumerable<Author> GetAuthors();
        [OperationContract]
        Author AddAuthor(Author author);
        [OperationContract]
        Author UpdateAuthor(Author author);
        [OperationContract]
        Author DeleteAuthor(Author author);
    }
}
