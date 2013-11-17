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
    public abstract class CardQuery : NoValueQuery
    {
        public Reader Reader {
            get;
            set;
        }

        protected CardQuery(ConnectionProvider provider) // вызов базового консруктора
            : base(provider) {
        }

        protected abstract string GetQuery();

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(GetQuery());
            command.Parameters.Add(":card_reader_id", Reader.Id);
            command.Parameters.Add(":card_id", Reader.Card.Id);
            return command;
        }
    }

    public class InsertCardQuery : CardQuery
    {
        const string Query = @"insert into card(card_reader_id, card_expiry_date, card_id)
                                    values (:card_reader_id, GET_DEFAULT_EXPIRY_DATE(), :card_id) returning card_id into :id";

        public InsertCardQuery(ConnectionProvider provider)
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
            Reader.Card.Id = Convert.ToInt32(((OracleDecimal)_parameter.Value).Value);
        }
    }

    public class RenewCardQuery : CardQuery
    {
        const string Query = @"update card set
                                    card_expiry_date = GET_DEFAULT_EXPIRY_DATE()
                                   where
                                    card_id = :card_id";

        public RenewCardQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override string GetQuery() {
            return Query;
        }

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(GetQuery());
            command.Parameters.Add(":card_id", Reader.Card.Id);
            return command;
        }
    }
}
