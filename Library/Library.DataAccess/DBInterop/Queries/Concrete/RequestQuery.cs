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
    public abstract class RequestQuery : NoValueQuery
    {
        protected RequestQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public Request Request {
            get;
            set;
        }

        protected abstract string GetQuery();

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(GetQuery());
            command.Parameters.Add(":request_id", Request.Id.Id);
            command.Parameters.Add(":book_id", Request.Book.Id);
            command.Parameters.Add(":card_id", Request.Id.Reader.Card.Id);
            command.Parameters.Add(":book_quantity", Request.BookQuantity);
            return command;
        }
    }

    public class InsertRequestQuery : RequestQuery
    {
        const string Query = @"insert into request(request_id, request_book_id, request_card_id, request_book_quantity)
                                values(:request_id, :book_id, :card_id, :book_quantity)";

        public InsertRequestQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override string GetQuery() {
            return Query;
        }
    }
}
