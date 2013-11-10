using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.DBInterop.Queries.Abstract;
using Library.DataContracts.Concrete;
using Oracle.DataAccess.Client;

namespace Library.DataAccess.DBInterop.Queries.Concrete
{
    public class GetAuthorsQuery : TableQuery<Author>
    {
        const string Query = @"select author_id, author_first_name, author_last_name, author_middle_name, author_biography from author";

        public GetAuthorsQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override Author Read(DataRow row) {
            return new Author() {
                Id = Convert.ToInt32(row.Field<decimal>("author_id")),
                FirstName = row.Field<string>("author_first_name"),
                LastName = row.Field<string>("author_last_name"),
                MiddleName = row.Field<string>("author_middle_name"),
                Biography = row.Field<string>("author_biography")
            };
        }

        public override OracleCommand CreateOracleCommand() {
            return new OracleCommand(Query);
        }
    }

    public class GetBookAuthorsQuery : GetAuthorsQuery
    {
        const string Query = @"select 
                                  a.author_id, a.author_first_name, a.author_last_name, a.author_middle_name, a.author_biography 
                                from book_author ba
                                inner join author a on ba.book_author_author_id = a.author_id
                                where book_author_book_id = :book_id";

        public GetBookAuthorsQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public Book Book {
            get;
            set;
        }

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(Query);
            command.Parameters.Add(":book_id", Book.Id);
            return command;
        }
    }
}
