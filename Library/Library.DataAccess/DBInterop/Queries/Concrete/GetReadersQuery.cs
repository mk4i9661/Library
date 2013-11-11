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
        const string Query = @"select reader_passport_id, reader_first_name, reader_last_name, reader_middle_name, reader_address, reader_phone from reader order by reader_last_name, reader_first_name, reader_middle_name";
        
        public GetReadersQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override Reader Read(System.Data.DataRow row) {
            return new Reader() {
                Id = Convert.ToInt32(row.Field<decimal>("reader_passport_id")),
                FirstName = row.Field<string>("reader_first_name"),
                LastName = row.Field<string>("reader_last_name"),
                MiddleName = row.Field<string>("reader_middle_name"),
                Address = row.Field<string>("reader_address"),
                Phone = row.Field<string>("reader_phone"),
            };
        }

        public override OracleCommand CreateOracleCommand() {
            return new OracleCommand(Query);
        }
    }
}
