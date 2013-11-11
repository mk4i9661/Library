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
    public class GetBookReadersQuery : TableQuery<Reader>
    {
        const string Query = @"select 
                                  r.reader_passport_id, r.reader_first_name, r.reader_middle_name, r.reader_last_name, r.reader_phone, r.reader_address
                                from card c 
                                inner join (
                                  select
                                    distinct r.request_card_id
                                  from request_approved ra
                                  inner join request r on ra.request_approved_request_id = r.request_id
                                  where ra.request_approved_book_id = :book_id
                                ) holder on c.card_id = holder.request_card_id
                                inner join reader r on c.card_reader_passport_id = r.reader_passport_id
                                order by r.reader_last_name, r.reader_first_name, r.reader_middle_name";

        public GetBookReadersQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override Reader Read(DataRow row) {
            return new Reader() {
                Id = Convert.ToInt32(row.Field<decimal>("reader_passport_id")),
                FirstName = row.Field<string>("reader_first_name"),
                LastName = row.Field<string>("reader_last_name"),
                MiddleName = row.Field<string>("reader_middle_name"),
                Phone = row.Field<string>("reader_phone"),
                Address = row.Field<string>("reader_address")
            };
        }

        public Book Book {
            get;
            set;
        }

        protected virtual string GetQuery() {
            return Query;
        }

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(GetQuery());
            command.Parameters.Add(":book_id", Book.Id);
            return command;
        }
    }

    public class GetBookHoldersQuery : GetBookReadersQuery
    {
        const string Query = @"select 
                                  r.reader_passport_id, r.reader_first_name, r.reader_middle_name, r.reader_last_name, r.reader_phone, r.reader_address
                                from card c 
                                inner join (
                                  select
                                    distinct r.request_card_id
                                  from request_approved ra
                                  inner join request r on ra.request_approved_request_id = r.request_id
                                  where ra.request_approved_is_returned = 0 and ra.request_approved_book_id = :book_id
                                ) holder on c.card_id = holder.request_card_id
                                inner join reader r on c.card_reader_passport_id = r.reader_passport_id
                                order by r.reader_last_name, r.reader_first_name, r.reader_middle_name";

        public GetBookHoldersQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override string GetQuery() {
            return Query;
        }
    }

    public class GetBookObligatorsQuery : GetBookReadersQuery
    {
        const string Query = @"select 
                                  r.reader_passport_id, r.reader_first_name, r.reader_middle_name, r.reader_last_name, r.reader_phone, r.reader_address
                                from card c 
                                inner join (
                                  select
                                    distinct r.request_card_id
                                  from request_approved ra
                                  inner join request r on ra.request_approved_request_id = r.request_id
                                  where ra.request_approved_is_returned = 0 and ra.request_approved_return_date < sysdate and ra.request_approved_book_id = :book_id
                                ) holder on c.card_id = holder.request_card_id
                                inner join reader r on c.card_reader_passport_id = r.reader_passport_id
                                order by r.reader_last_name, r.reader_first_name, r.reader_middle_name";

        public GetBookObligatorsQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override string GetQuery() {
            return Query;
        }
    }
}
