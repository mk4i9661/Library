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
    public class GetApprovedRequestsQuery : TableQuery<RequestApproved>
    {
        const string Query = @"select
                              r.request_id, r.request_create_date, r.request_card_id,
                              r.request_book_id, b.book_name, r.request_book_quantity,
                              ra.request_approved_return_date, ra.request_approved_renewal_count, ra.request_approved_is_returned
                            from request_approved ra
                            inner join request r on ra.request_approved_request_id = r.request_id and ra.request_approved_book_id = r.request_book_id
                            inner join book b on r.request_book_id = b.book_id
                            where r.request_id = :id";

        public GetApprovedRequestsQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public RequestHeader Request {
            get;
            set;
        }

        public override RequestApproved Read(DataRow row) {
            return new RequestApproved() {
                Id = new Request() {
                    Id = new RequestHeader() {
                        Id = Convert.ToInt32(row.Field<decimal>("request_id")),
                        CreateDate = row.Field<DateTime>("request_create_date"),
                        Card = new Card() {
                            Id = Convert.ToInt32(row.Field<decimal>("request_card_id"))
                        }
                    },
                    Book = new Book() {
                        Id = Convert.ToInt32(row.Field<decimal>("request_book_id")),
                        Name = row.Field<string>("book_name"),
                    },
                    BookQuantity = Convert.ToInt32(row.Field<decimal>("request_book_quantity"))
                },
                ReturnDate = row.Field<DateTime>("request_approved_return_date"),
                RenewalCount = Convert.ToInt32(row.Field<decimal>("request_approved_renewal_count")),
                IsReturned = Convert.ToBoolean(row.Field<decimal>("request_approved_is_returned"))
            };
        }

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(Query);
            command.Parameters.Add(":id", Request.Id);
            return command;
        }
    }
}
