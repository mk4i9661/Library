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
    public class GetPublishersQuery : TableQuery<Publisher>
    {
        const string Query = @"select publisher_id, publisher_name, publisher_location, publisher_description from publisher order by publisher_name";

        public GetPublishersQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override Publisher Read(DataRow row) {
            return new Publisher() {
                Id = Convert.ToInt32(row.Field<decimal>("publisher_id")),
                Name = row.Field<string>("publisher_name"),
                Location = row.Field<string>("publisher_location"),
                Description = row.Field<string>("publisher_description")
            };
        }

        public override OracleCommand CreateOracleCommand() {
            return new OracleCommand(Query);
        }
    }
}
