﻿using Library.DataAccess.DBInterop.Queries.Abstract;
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
    public class GetRejectedRequestsQuery : TableQuery<RequestRejected>
    {

        const string Query = @"select 
                              r.request_id, r.request_create_date, 
                              r.request_card_id, re.reader_id, re.reader_passport_id, re.reader_first_name, re.reader_last_name, re.reader_middle_name,
                              r.request_book_id, b.book_name, r.request_book_quantity,
                              rr.request_rejected_reason_id, rrn.reject_reason_name
                            from request_rejected rr
                            inner join request r on rr.request_rejected_request_id = r.request_id and rr.request_rejected_book_id = r.request_book_id
                            inner join card c on r.request_card_id = c.card_id
                            inner join reader re on c.card_reader_id = re.reader_id
                            inner join book b on r.request_book_id = b.book_id
                            inner join reject_reason rrn on rr.request_rejected_reason_id = rrn.reject_reason_id
                            where r.request_card_id = :id
                            order by b.book_name";

        public Card Card {
            get;
            set;
        }

        public GetRejectedRequestsQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override RequestRejected Read(DataRow row) {
            return new RequestRejected() {
                Id = new Request() {
                    Id = new RequestHeader() {
                        Id = Convert.ToInt32(row.Field<decimal>("request_id")),
                        CreateDate = row.Field<DateTime>("request_create_date"),
                        Reader = new Reader() {
                            Id = Convert.ToInt32(row.Field<decimal>("reader_id")),
                            PassportNumber = Convert.ToInt32(row.Field<decimal>("reader_passport_id")),
                            FirstName = row.Field<string>("reader_first_name"),
                            LastName = row.Field<string>("reader_last_name"),
                            MiddleName = row.Field<string>("reader_middle_name"),
                            Card = new Card() {
                                Id = Convert.ToInt32(row.Field<decimal>("request_card_id"))
                            }
                        },
                    },
                    Book = new Book() {
                        Id = Convert.ToInt32(row.Field<decimal>("request_book_id")),
                        Name = row.Field<string>("book_name"),
                    },
                    BookQuantity = Convert.ToInt32(row.Field<decimal>("request_book_quantity"))
                },
                Reason = new RejectReason() {
                    Id = Convert.ToInt32(row.Field<decimal>("request_rejected_reason_id")),
                    Name = row.Field<string>("reject_reason_name")
                }
            };
        }

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(Query);
            command.Parameters.Add(":id", Card.Id);
            return command;
        }
    }
}
