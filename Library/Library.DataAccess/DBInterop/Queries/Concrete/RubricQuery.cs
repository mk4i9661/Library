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
    public abstract class RubricQuery : NoValueQuery
    {
        public RubricQuery(ConnectionProvider provider)
            : base(provider) {

        }

        public Rubric Rubric {
            get;
            set;
        }

        protected abstract string GetQuery();

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(GetQuery());
            command.Parameters.Add(":parent_id", Rubric.Parent == null ? (object)DBNull.Value : Rubric.Parent.Id);
            command.Parameters.Add(":name", Rubric.Name);
            command.Parameters.Add(":description", Rubric.Description);
            command.Parameters.Add(":rubric_id", Rubric.Id);
            return command;
        }
    }

    public class InsertRubricQuery : RubricQuery
    {
        const string Query = @"insert into rubric (Rubric_Parent_ID, Rubric_Name, Rubric_Description, Rubric_ID) values(:parent_id, :name, :description, :rubric_id) returning Rubric_ID into :id";

        public InsertRubricQuery(ConnectionProvider provider)
            : base(provider) {

        }

        public override OracleCommand CreateOracleCommand() {
            var command = base.CreateOracleCommand();
            command.Parameters.Add(":id", OracleDbType.Decimal, ParameterDirection.ReturnValue);
            return command;
        }

        protected override void ExecuteQuery(OracleCommand command) {
            var parameter = command.Parameters[":id"];
            base.ExecuteQuery(command);
            Rubric.Id = Convert.ToInt32(((OracleDecimal)parameter.Value).Value);
        }

        protected override string GetQuery() {
            return Query;
        }
    }

    public class UpdateRubricQuery : RubricQuery
    {
        const string Query = @"update rubric set 
                                  rubric_parent_id = :parent_id,
                                  rubric_name = :name,
                                  rubric_description = :description
                                where rubric_id = :rubric_id";

        public UpdateRubricQuery(ConnectionProvider provider)
            : base(provider) {

        }

        protected override string GetQuery() {
            return Query;
        }
    }

    public class DeleteRubricQuery : RubricQuery
    {
        const string Query = @"delete from rubric where rubric_id = :rubric_id";

        public DeleteRubricQuery(ConnectionProvider provider)
            : base(provider) {

        }

        protected override string GetQuery() {
            return Query;
        }

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(Query);
            command.Parameters.Add(":rubric_id", Rubric.Id);
            return command;
        }
    }
}
