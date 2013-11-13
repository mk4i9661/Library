using Library.DataAccess.DBInterop.Queries.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataContracts.Concrete;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace Library.DataAccess.DBInterop.Queries.Concrete
{
    public abstract class AuthorQuery : NoValueQuery
    {
        protected AuthorQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public Author Author {
            get;
            set;
        }

        protected abstract string GetQuery();

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(GetQuery());
            command.Parameters.Add(":first_name", Author.FirstName);
            command.Parameters.Add(":middle_name", Author.MiddleName);
            command.Parameters.Add(":last_name", Author.LastName);
            command.Parameters.Add(":biography", Author.Biography ?? (object)DBNull.Value);
            command.Parameters.Add(":author_id", Author.Id);
            return command;
        }
    }

    public class InsertAuthorQuery : AuthorQuery
    {
        const string Query = @"insert into author(author_first_name,author_middle_name,author_last_name,author_biography,author_id) 
                                values(:first_name, :middle_name, :last_name, :biography, :author_id) returning Author_ID into :id";

        public InsertAuthorQuery(ConnectionProvider provider)
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

        protected override void ExecuteQuery(OracleCommand command) {
            var parameter = command.Parameters[":id"];
            base.ExecuteQuery(command);
            Author.Id = Convert.ToInt32(((OracleDecimal)parameter.Value).Value);
        }
    }

    public class UpdateAuthorQuery : AuthorQuery
    {
        const string Query = @"update author set
                          author_first_name = :first_name,
                          author_middle_name = :middle_name,
                          author_last_name = :last_name,
                          author_biography = :biography
                        where author_id = :id";

        public UpdateAuthorQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override string GetQuery() {
            return Query;
        }
    }

    public class DeleteAuthorQuery : AuthorQuery
    {
        const string Query = @"delete from author where author_id = :author_id";

        public DeleteAuthorQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override string GetQuery() {
            return Query;
        }

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand(Query);
            command.Parameters.Add(":author_id", Author.Id);
            return command;
        }
    }
}
