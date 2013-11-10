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
    public class GetRequestHeadersQuery : TableQuery<RequestHeader>
    {
        const string Query = @"select
                                  r.request_id, r.request_card_id, r.request_create_date, (case when ra.c is null then 0 else 1 end) as has_approved, (case when rr.c is null then 0 else 1 end) as has_rejected
                                from(
                                  select 
                                    distinct request_id, request_card_id, request_create_date
                                  from request
                                ) r
                                left join (
                                  select ra.request_approved_request_id, count(ra.request_approved_request_id) as c from request_approved ra group by ra.request_approved_request_id
                                ) ra on r.request_id = ra.request_approved_request_id
                                left join (
                                  select rr.request_rejected_request_id, count(rr.request_rejected_request_id) as c from request_rejected rr group by rr.request_rejected_request_id
                                ) rr on r.request_id = rr.request_rejected_request_id";

        public GetRequestHeadersQuery(ConnectionProvider provider)
            : base(provider) {

        }

        public override RequestHeader Read(DataRow row) {
            return new RequestHeader() {
                Id = Convert.ToInt32(row.Field<decimal>("request_id")),
                Card = new Card() {
                    Id = Convert.ToInt32(row.Field<decimal>("request_card_id")),
                },
                CreateDate = row.Field<DateTime>("request_create_date"),
                HasApprovedRequests = Convert.ToBoolean(row.Field<decimal>("has_approved")),
                HasRejectedRequests = Convert.ToBoolean(row.Field<decimal>("has_rejected"))
            };
        }

        public override OracleCommand CreateOracleCommand() {
            return new OracleCommand(Query);
        }
    }
}
