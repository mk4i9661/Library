using Library.DataAccess.DBInterop.Queries.Abstract;
using Library.DataContracts.Concrete;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.DBInterop.Queries.Concrete
{
    public class GetRequestsQuery : TableQuery<Request>
    {
        const string Query = @"select distinct request_id, request_card_id, request_create_date from request";

        public GetRequestsQuery(ConnectionProvider provider)
            : base(provider) {

        }

        public override Request Read(DataRow row) {
            return new Request() {
                Id = Convert.ToInt32(row.Field<decimal>("request_id")),
                Card = new Card() {
                    Id = Convert.ToInt32(row.Field<decimal>("request_card_id")),
                },
                CreateDate = row.Field<DateTime>("request_create_date")
            };
        }

        public override OracleCommand CreateOracleCommand() {
            return new OracleCommand(Query);
        }
    }
}
