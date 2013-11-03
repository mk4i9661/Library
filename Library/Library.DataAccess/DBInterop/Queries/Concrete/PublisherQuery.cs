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
    public abstract class PublisherQuery : NoValueQuery
    {
        public Publisher Publisher {
            get;
            set;
        }

        protected PublisherQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected abstract string GetQuery();

        public override OracleCommand CreateSqlCommand() {
            var command = new OracleCommand(GetQuery());
            command.Parameters.Add(":name", Publisher.Name);
            command.Parameters.Add(":location", Publisher.Location);
            command.Parameters.Add(":description", Publisher.Description);
            command.Parameters.Add(":publisher_id", Publisher.Id);
            return command;
        }
    }

    public class InsertPublisherQuery : PublisherQuery
    {
        const string Query = @"insert into publisher (publisher_name, publisher_location, publisher_description, publisher_id) values(:name, :location, :description, :publisher_id) returning Publisher_ID into :id";

        public InsertPublisherQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override OracleCommand CreateSqlCommand() {
            var command = base.CreateSqlCommand();
            command.Parameters.Add(":id", OracleDbType.Decimal, ParameterDirection.ReturnValue);
            return command;
        }

        protected override void ExecuteQuery(OracleCommand command) {
            var parameter = command.Parameters[":id"];
            base.ExecuteQuery(command);
            Publisher.Id = Convert.ToInt32(((OracleDecimal)parameter.Value).Value);
        }

        protected override string GetQuery() {
            return Query;
        }
    }

    public class UpdatePublisherQuery : PublisherQuery
    {
        const string Query = @"update publisher set
                                  publisher_name = :name,
                                  publisher_location = :location,
                                  publisher_description = :description
                                where
                                  publisher_id = :publisher_id";

        public UpdatePublisherQuery(ConnectionProvider provider)
            : base(provider) {

        }

        protected override string GetQuery() {
            return Query;
        }
    }

    public class DeletePublisherQuery : PublisherQuery
    {
        const string Query = @"delete from publisher where publisher_id = :publisher_id";

        public DeletePublisherQuery(ConnectionProvider provider)
            : base(provider) {

        }

        protected override string GetQuery() {
            return Query;
        }

        public override OracleCommand CreateSqlCommand() {
            var command = new OracleCommand(GetQuery());
            command.Parameters.Add(":publisher_id", Publisher.Id);
            return command;
        }
    }
}
