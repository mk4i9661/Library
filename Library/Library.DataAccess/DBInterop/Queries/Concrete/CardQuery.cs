using Library.DataAccess.DBInterop.Queries.Abstract;
using Library.DataContracts.Concrete;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.DBInterop.Queries.Concrete
{
    public abstract class CardQuery : NoValueQuery
    {
        public Card Card
        {
            get;
            set;
        }

        protected CardQuery(ConnectionProvider provider) // вызов базового консруктора
            : base(provider){
        }

        protected abstract string GetQuery();

        public override OracleCommand CreateOracleCommand()
        {
            var command = new OracleCommand(GetQuery());
            command.Parameters.Add(":card_reader_passport_id", Card.Reader.Id);
            command.Parameters.Add(":card_id", Card.Id);
           
            return command;
        }
    }

    public class InsertCardQuery : CardQuery
    {
        const string Query = @"insert into card(card_reader_passport_id, card_expiry_date, card_id)
                                    values (:card_reader_passport_id, GET_DEFAULT_EXPIRY_DATE(), :card_id)";

        public InsertCardQuery(ConnectionProvider provider)
            : base(provider)
        {
        }

        protected override string GetQuery()
        {
            return Query;
        }

    }

    public class UpdateCardQuery : CardQuery
    {
        const string Query = @"update card set
                                    card_reader_passport_id = :card_reader_passport_id
                                  where
                                    card_id = :card_id";

        public UpdateCardQuery(ConnectionProvider provider)
            : base(provider)
        {

        }

        protected override string GetQuery()
        {
            return Query;
        }
    }

    public class DeleteCardQuery : CardQuery
    {
        const string Query = @"delete from card where reader_passport_id = :reader_passport_id";

        public DeleteCardQuery(ConnectionProvider provider)
            : base(provider)
        {

        }

        protected override string GetQuery()
        {
            return Query;
        }

        public override OracleCommand CreateOracleCommand()
        {
            var command = new OracleCommand(GetQuery());
            command.Parameters.Add(":card_id", Card.Id);
            return command;
        }
    }

    public class RenewCardQuery : CardQuery
    {
        const string Query = @"update card set
                                    ccard_expiry_date = GET_DEFAULT_EXPIRY_DATE()
                                   where
                                    card_id = :card_id
                                  ";

        public RenewCardQuery(ConnectionProvider provider)
            : base(provider)
        {
        }

        protected override string GetQuery()
        {
            return Query;
        }

        public override OracleCommand CreateOracleCommand()
        {
            var command = new OracleCommand(GetQuery());
            command.Parameters.Add(":card_id", Card.Id);
            return command;
        }
    }
}
