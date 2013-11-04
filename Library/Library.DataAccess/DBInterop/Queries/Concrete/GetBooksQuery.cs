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
    public class GetBooksQuery : TableQuery<Book>
    {
        const string Query = @"select
                                  book_id, book_name, book_imprint_date, book_page_quantity, book_annotation, book_quantity,
                                  book_rubric_id, r.rubric_name,
                                  book_publisher_id, p.publisher_name
                                from book b
                                inner join rubric r on b.book_rubric_id = r.rubric_id
                                inner join publisher p on b.book_publisher_id = p.publisher_id";

        public GetBooksQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override Book Read(DataRow row) {
            return new Book() {
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
                }
            };
        }

        public override OracleCommand CreateSqlCommand() {
            return new OracleCommand(Query);
        }
    }
}
