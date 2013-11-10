using Library.DataAccess.DBInterop.Queries.Abstract;
using Library.DataContracts.Concrete;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.DBInterop.Queries.Concrete
{
    public abstract class BookQuery : NoValueQuery
    {
        protected BookQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public Book Book {
            get;
            set;
        }

        protected abstract string GetQuery();

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(GetQuery());
            command.Parameters.Add(":name", Book.Name);
            command.Parameters.Add(":imprint_date", Book.ImprintDate);
            command.Parameters.Add(":page_quantity", Book.PageQuantity);
            command.Parameters.Add(":annotation", Book.Annotation);
            command.Parameters.Add(":quantity", Book.BookQuantity);
            command.Parameters.Add(":rubric_id", Book.Rubric.Id);
            command.Parameters.Add(":publisher_id", Book.Publisher.Id);
            command.Parameters.Add(":book_id", Book.Id);
            return command;
        }
    }

    public class InsertBookQuery : BookQuery
    {
        const string Query = @"insert into book(book_name, book_imprint_date, book_page_quantity, book_annotation, book_quantity, book_rubric_id, book_publisher_id, book_id)
                                values(:name, :imprint_date, :page_quantity, :annotation, :quantity, :rubric_id, :publisher_id, :book_id) returning Book_ID into :id";

        public InsertBookQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override string GetQuery() {
            return Query;
        }

        public override OracleCommand CreateOracleCommand() {
            var command = base.CreateOracleCommand();
            command.Parameters.Add(":id", OracleDbType.Decimal, ParameterDirection.ReturnValue);
            return command;
        }

        protected override void ExecuteQuery(OracleCommand command) {
            var parameter = command.Parameters[":id"];
            base.ExecuteQuery(command);
            Book.Id = Convert.ToInt32(((OracleDecimal)parameter.Value).Value);
        }
    }

    public class UpdateBookQuery : BookQuery
    {
        const string Query = @"update book set
                              book_name = :name,
                              book_imprint_date = :imprint_date,
                              book_page_quantity = :page_quantity,
                              book_annotation = :annotation,
                              book_quantity = :quantity,
                              book_rubric_id = :rubric_id,
                              book_publisher_id = :publisher_id
                            where book_id = :book_id";

        public UpdateBookQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override string GetQuery() {
            return Query;
        }
    }

    public class DeleteBookQuery : BookQuery
    {
        const string Query = @"delete from book where book_id = :book_id";

        public DeleteBookQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override string GetQuery() {
            return Query;
        }

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(Query);
            command.Parameters.Add(":book_id", Book.Id);
            return command;
        }
    }
}
