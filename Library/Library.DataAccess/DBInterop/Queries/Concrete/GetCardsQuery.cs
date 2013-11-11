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
    public class GetCardsQuery : TableQuery<Card>
    {
        const string Query = @"select
                              r.reader_passport_id, r.reader_first_name, r.reader_middle_name, r.reader_last_name,
                              c.card_id, c.card_issue_date, c.card_expiry_date
                            from card c 
                            inner join reader r on c.card_reader_passport_id = r.reader_passport_id
                            order by card_id";

        public GetCardsQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override Card Read(DataRow row) {
            return new Card() {
                Reader = new Reader() {
                    Id = Convert.ToInt32(row.Field<decimal>("reader_passport_id")),
                    FirstName = row.Field<string>("reader_first_name"),
                    MiddleName = row.Field<string>("reader_middle_name"),
                    LastName = row.Field<string>("reader_last_name")
                },
                Id = Convert.ToInt32(row.Field<decimal>("card_id")),
                IssueDate = row.Field<DateTime>("card_issue_date"),
                ExpiryDate = row.Field<DateTime>("card_expiry_date")
            };
        }

        public override OracleCommand CreateOracleCommand() {
            return new OracleCommand(Query);
        }
    }
}
