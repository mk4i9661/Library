using Library.DataAccess.DBInterop.Queries.Abstract;
using Library.DataContracts.Concrete;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.DBInterop.Queries.Concrete
{
    public abstract class ReaderQuery : NoValueQuery
    {
        public Reader Reader {
            get;
            set;
        }

        protected ReaderQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected abstract string GetQuery();

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(GetQuery());
            command.Parameters.Add(":reader_passport_id", Reader.PassportNumber);
            command.Parameters.Add(":reader_first_name", Reader.FirstName);
            command.Parameters.Add(":reader_last_name", Reader.LastName);
            command.Parameters.Add(":reader_middle_name", Reader.MiddleName);
            command.Parameters.Add(":reader_address", Reader.Address);
            command.Parameters.Add(":reader_phone", Reader.Phone);
            command.Parameters.Add(":reader_id", Reader.Id);
            return command;
        }
    }

    public class InsertReaderQuery : ReaderQuery
    {
        const string Query = @"insert into reader(reader_passport_id, reader_first_name, reader_last_name, reader_middle_name, reader_address, reader_phone, reader_id)
                                    values (:reader_passport_id, :reader_first_name, :reader_last_name, :reader_middle_name, :reader_address, :reader_phone, :reader_id) returning reader_id into :id";

        public InsertReaderQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override string GetQuery() {
            return Query;
        }

        public override OracleCommand CreateOracleCommand() {
            var command = base.CreateOracleCommand();
            command.Parameters.Add(":id", OracleDbType.Decimal, ParameterDirection.ReturnValue);
            return command;
        }

        OracleParameter _parameter;
        internal override void OnBeforeExecuteQuery(OracleCommand command) {
            _parameter = command.Parameters[":id"];
        }

        internal override void OnAfterExecuteQuery(OracleCommand command) {
            Reader.Id = Convert.ToInt32(((OracleDecimal)_parameter.Value).Value);
        }

    }

    public class UpdateReaderQuery : ReaderQuery
    {
        const string Query = @"update reader set
                                    reader_passport_id = :reader_passport_id,                                    
                                    reader_first_name = :reader_first_name,
                                    reader_last_name = :reader_last_name,
                                    reader_middle_name = :reader_middle_name,
                                    reader_address = :reader_address,
                                    reader_phone = :reader_phone
                                  where reader_id = :reader_id";

        public UpdateReaderQuery(ConnectionProvider provider)
            : base(provider) {

        }

        protected override string GetQuery() {
            return Query;
        }
    }

    public class DeleteReaderQuery : ReaderQuery
    {
        const string Query = @"delete from reader where reader_id = :reader_id";

        public DeleteReaderQuery(ConnectionProvider provider)
            : base(provider) {

        }

        protected override string GetQuery() {
            return Query;
        }

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(GetQuery());
            command.Parameters.Add(":reader_id", Reader.Id);
            return command;
        }
    }

}
