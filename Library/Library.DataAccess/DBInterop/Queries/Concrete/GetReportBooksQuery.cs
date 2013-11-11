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
    public class GetReportBooksQuery : TableQuery<ReportBook>
    {
        const string Query = @"select
                                  book_id, book_name, book_imprint_date, book_page_quantity, book_annotation, book_quantity,
                                  book_rubric_id, r.rubric_name,
                                  book_publisher_id, p.publisher_name,
                                  nvl(taken.c, 0) as taken_count,
                                  nvl(delayed.c, 0) as delayed_count
                                from book b
                                inner join rubric r on b.book_rubric_id = r.rubric_id
                                inner join publisher p on b.book_publisher_id = p.publisher_id
                                left join (
                                  select ra.request_approved_book_id, sum(r.request_book_quantity) as c
                                  from request_approved ra 
                                  inner join request r on ra.request_approved_request_id = r.request_id and ra.request_approved_book_id = r.request_book_id
                                  where ra.request_approved_is_returned = 0 group by ra.request_approved_book_id
                                ) taken on b.book_id = taken.request_approved_book_id
                                left join (
                                  select ra.request_approved_book_id, sum(r.request_book_quantity) as c
                                  from request_approved ra 
                                  inner join request r on ra.request_approved_request_id = r.request_id and ra.request_approved_book_id = r.request_book_id
                                  where ra.request_approved_is_returned = 0 and ra.request_approved_return_date < sysdate group by ra.request_approved_book_id
                                ) delayed on b.book_id = delayed.request_approved_book_id
                                order by r.rubric_name, p.publisher_name, book_name";

        public GetReportBooksQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override ReportBook Read(DataRow row) {
            return new ReportBook() {
                Id = Convert.ToInt32(row.Field<decimal>("book_id")),
                Name = row.Field<string>("book_name"),
                ImprintDate = row.Field<DateTime>("book_imprint_date"),
                PageQuantity = Convert.ToInt32(row.Field<decimal>("book_page_quantity")),
                Annotation = row.Field<string>("book_annotation"),
                BookQuantity = Convert.ToInt32(row.Field<decimal>("book_quantity")),
                Rubric = new Rubric() {
                    Id = Convert.ToInt32(row.Field<decimal>("book_rubric_id")),
                    Name = row.Field<string>("rubric_name")
                },
                Publisher = new Publisher() {
                    Id = Convert.ToInt32(row.Field<decimal>("book_publisher_id")),
                    Name = row.Field<string>("publisher_name")
                },
                DelayedBookQuantity = Convert.ToInt32(row.Field<decimal>("delayed_count")),
                TakenBookQuantity = Convert.ToInt32(row.Field<decimal>("taken_count"))
            };
        }

        public override OracleCommand CreateOracleCommand() {
            return new OracleCommand(Query);
        }
    }
}
