using Library.DataAccess.DBInterop.Queries.Abstract;
using Library.DataContracts.Concrete;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.DBInterop.Queries.Concrete
{
    public abstract class BookAuthorQuery : NoValueQuery
    {
        public Book Book {
            get;
            set;
        }

        public Author Author {
            get;
            set;
        }

        protected BookAuthorQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected abstract string GetQuery();

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(GetQuery());
            command.Parameters.Add(":book_id", Book.Id);
            command.Parameters.Add(":author_id", Author.Id);
            return command;
        }
    }

    public class InsertBookAuthorQuery : BookAuthorQuery
    {
        const string Query = @"insert into book_author(book_author_book_id, book_author_author_id)
                                values(:book_id, :author_id)";

        public InsertBookAuthorQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override string GetQuery() {
            return Query;
        }
    }

    public class DeleteBookAuthorQuery : BookAuthorQuery
    {
        const string Query = @"delete from book_author where book_author_book_id = :book_id and book_author_author_id = :author_id";

        public DeleteBookAuthorQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override string GetQuery() {
            return Query;
        }
    }
}
