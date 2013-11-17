using Library.DataAccess.DBInterop.Queries.Abstract;
using Library.DataContracts.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace Library.DataAccess.DBInterop.Queries.Concrete
{
    public class GetReadersQuery : TableQuery<Reader>
    {
        const string Query = @"select 
                              r.reader_id, r.reader_passport_id, r.reader_first_name, r.reader_last_name, r.reader_middle_name, r.reader_address, r.reader_phone,
                              c.card_id, c.card_issue_date, c.card_expiry_date
                            from reader r
                            inner join card c on r.reader_id = c.card_reader_id
                            order by r.reader_last_name, r.reader_first_name, r.reader_middle_name";

        public GetReadersQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override Reader Read(System.Data.DataRow row) {
            return new Reader() {
                Id = Convert.ToInt32(row.Field<decimal>("reader_id")),
                PassportNumber = Convert.ToInt32(row.Field<decimal>("reader_passport_id")),
                FirstName = row.Field<string>("reader_first_name"),
                LastName = row.Field<string>("reader_last_name"),
                MiddleName = row.Field<string>("reader_middle_name"),
                Address = row.Field<string>("reader_address"),
                Phone = row.Field<string>("reader_phone"),
                Card = new Card() {
                    Id = Convert.ToInt32(row.Field<decimal>("card_id")),
                    IssueDate = row.Field<DateTime>("card_issue_date"),
                    ExpiryDate = row.Field<DateTime>("card_expiry_date")
                }
            };
        }

        public override OracleCommand CreateOracleCommand() {
            return new OracleCommand(Query);
        }
    }
}
