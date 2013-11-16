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
    public class GetNotificationsQuery : TableQuery<Notification>
    {
        const string Query = @"select 
                                  n.notification_request_id, n.notification_book_id,
                                  n.notification_type_id, nt.notification_text,
                                  n.notification_book_id, b.book_name,
                                    b.book_rubric_id, ru.rubric_name,
                                    b.book_publisher_id, p.publisher_name,
                                  r.request_create_date, r.request_book_quantity,
                                  c.card_id,
                                  re.reader_passport_id, re.reader_first_name, re.reader_last_name, re.reader_middle_name, re.reader_address, re.reader_phone
                                from notification n
                                inner join notification_type nt on n.notification_type_id = nt.notification_type_id
                                inner join book b on n.notification_book_id = b.book_id
                                inner join rubric ru on b.book_rubric_id = ru.rubric_id
                                inner join publisher p on b.book_publisher_id = p.publisher_id
                                inner join request r on n.notification_request_id = r.request_id and n.notification_book_id = r.request_book_id
                                inner join card c on r.request_card_id = c.card_id
                                inner join reader re on c.card_reader_passport_id = re.reader_passport_id";

        public GetNotificationsQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override Notification Read(DataRow row) {
            return new Notification() {
                Id = new Request() {
                    Id = new RequestHeader() {
                        Id = Convert.ToInt32(row.Field<decimal>("notification_request_id")),
                        Card = new Card() {
                            Id = Convert.ToInt32(row.Field<decimal>("card_id")),
                            Reader = new Reader() {
                                Id = Convert.ToInt32(row.Field<decimal>("reader_passport_id")),
                                FirstName = row.Field<string>("reader_first_name"),
                                LastName = row.Field<string>("reader_last_name"),
                                MiddleName = row.Field<string>("reader_middle_name"),
                                Address = row.Field<string>("reader_address"),
                                Phone = row.Field<string>("reader_phone")
                            }
                        },
                        CreateDate = row.Field<DateTime>("request_create_date")
                    },
                    BookQuantity = Convert.ToInt32(row.Field<decimal>("request_book_quantity")),
                    Book = new Book() {
                        Id = Convert.ToInt32(row.Field<decimal>("notification_book_id")),
                        Name = row.Field<string>("book_name"),
                        Rubric = new Rubric() {
                            Id = Convert.ToInt32(row.Field<decimal>("book_rubric_id")),
                            Name = row.Field<string>("rubric_name")
                        },
                        Publisher = new Publisher() {
                            Id = Convert.ToInt32(row.Field<decimal>("book_publisher_id")),
                            Name = row.Field<string>("publisher_name")
                        }
                    }
                },
                NotificationType = new NotificationType() {
                    Id = Convert.ToInt32(row.Field<decimal>("notification_type_id")),
                    Text = row.Field<string>("notification_text")
                }
            };
        }

        public override OracleCommand CreateOracleCommand() {
            return new OracleCommand(Query);
        }
    }
}
