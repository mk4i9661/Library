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

        public override OracleCommand CreateSqlCommand() {
            return new OracleCommand(Query);
        }
    }
}
