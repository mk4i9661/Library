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
    public class GetAuthorBooksQuery : TableQuery<Book>
    {
        const string Query = @"select distinct
                                  book_id, book_name, book_imprint_date, book_page_quantity, book_annotation, book_quantity,
                                  book_rubric_id, r.rubric_name,
                                  book_publisher_id, p.publisher_name,
                                  (case when bc.c is null then 0 else 1 end) as has_authors
                                from author a
                                inner join book_author ba on a.author_id = ba.book_author_author_id
                                inner join book b on ba.book_author_book_id = b.book_id
                                inner join rubric r on b.book_rubric_id = r.rubric_id
                                inner join publisher p on b.book_publisher_id = p.publisher_id
                                left join (
                                  select book_author_book_id, count(book_author_book_id) as c from book_author ba group by ba.book_author_book_id
                                ) bc on b.book_id = bc.book_author_book_id
                                where a.author_id = :id
                                order by r.rubric_name, p.publisher_name, book_name";

        public GetAuthorBooksQuery(ConnectionProvider provider)
            : base(provider)
        {
        }

        public Author Author
        {
            get;
            set;
        }

        public override Book Read(DataRow row)
        {
            return new Book()
            {
                Id = Convert.ToInt32(row.Field<decimal>("book_id")),
                Name = row.Field<string>("book_name"),
                ImprintDate = row.Field<DateTime>("book_imprint_date"),
                PageQuantity = Convert.ToInt32(row.Field<decimal>("book_page_quantity")),
                Annotation = row.Field<string>("book_annotation"),
                BookQuantity = Convert.ToInt32(row.Field<decimal>("book_quantity")),
                Rubric = new Rubric()
                {
                    Id = Convert.ToInt32(row.Field<decimal>("book_rubric_id")),
                    Name = row.Field<string>("rubric_name")
                },
                Publisher = new Publisher()
                {
                    Id = Convert.ToInt32(row.Field<decimal>("book_publisher_id")),
                    Name = row.Field<string>("publisher_name")
                },
                HasAuthors = Convert.ToBoolean(row.Field<decimal>("has_authors"))
            };
        }

        public override OracleCommand CreateOracleCommand()
        {
            var command = new OracleCommand(Query);
            command.Parameters.Add(":id", Author.Id);
            return command;
        }
    }
}
