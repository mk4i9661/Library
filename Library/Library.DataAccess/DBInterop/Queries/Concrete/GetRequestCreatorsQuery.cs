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
    public class GetRequestCreatorsQuery : TableQuery<RequestCreator>
    {
        const string Query = @"select
                              c.card_id, c.card_expiry_date, c.card_issue_date,
                              re.reader_id, re.reader_passport_id, re.reader_first_name, re.reader_last_name, re.reader_middle_name,
                              re.reader_address, re.reader_phone,
                              r.has_approved, r.has_rejected
                            from (
                              select distinct
                                r.request_card_id as card_id,
                                (case when ra.total is null then 0 else 1 end) as has_approved,
                                (case when rr.total is null then 0 else 1 end) as has_rejected
                              from request r
                              left join (
                                select request_card_id, count(request_card_id) as total from request inner join request_approved on request_id = request_approved_request_id group by request_card_id
                              ) ra on r.request_card_id = ra.request_card_id
                              left join (
                                select request_card_id, count(request_card_id) as total from request inner join request_rejected rr on request_id = request_rejected_request_id group by request_card_id
                              ) rr on r.request_card_id = rr.request_card_id
                            ) r
                            inner join card c on r.card_id = c.card_id
                            inner join reader re on c.card_reader_id = re.reader_id";

        public GetRequestCreatorsQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override RequestCreator Read(DataRow row) {
            return new RequestCreator() {
                Card = new Card() {
                    Id = Convert.ToInt32(row.Field<decimal>("card_id")),
                    IssueDate = row.Field<DateTime>("card_issue_date"),
                    ExpiryDate = row.Field<DateTime>("card_expiry_date"),
                },
                Id = Convert.ToInt32(row.Field<decimal>("reader_id")),
                PassportNumber = Convert.ToInt32(row.Field<decimal>("reader_passport_id")),
                FirstName = row.Field<string>("reader_first_name"),
                LastName = row.Field<string>("reader_last_name"),
                MiddleName = row.Field<string>("reader_middle_name"),
                Address = row.Field<string>("reader_address"),
                Phone = row.Field<string>("reader_phone"),
                HasApprovedRequests = Convert.ToBoolean(row.Field<decimal>("has_approved")),
                HasRejectedRequests = Convert.ToBoolean(row.Field<decimal>("has_rejected"))
            };
        }

        public override OracleCommand CreateOracleCommand() {
            return new OracleCommand(Query);
        }
    }
}
