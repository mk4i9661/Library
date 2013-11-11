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
    public abstract class RequestApprovedQuery : NoValueQuery
    {

        public RequestApproved RequestApproved {
            get;
            set;
        }

        protected RequestApprovedQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected abstract string GetQuery();

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(GetQuery());
            command.Parameters.Add(":request_id", RequestApproved.Id.Id.Id);
            command.Parameters.Add(":book_id", RequestApproved.Id.Book.Id);
            return command;
        }
    }

    public class RenewRequestQuery : RequestApprovedQuery
    {
        const string Query = @"update request_approved
                                set request_approved_renewal_count = request_approved_renewal_count + 1,
                                    request_approved_return_date = GET_DEFAULT_RETURN_DATE()
                                where request_approved_request_id = :request_id and request_approved_book_id = :book_id";

        public RenewRequestQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override string GetQuery() {
            return Query;
        }
    }

    public class CloseRequestQuery : RequestApprovedQuery
    {
        const string Query = @"update request_approved
                                set request_approved_is_returned = 1
                                where request_approved_request_id = :request_id and request_approved_book_id = :book_id";

        public CloseRequestQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override string GetQuery() {
            return Query;
        }
    }
}
