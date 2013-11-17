using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace Library.DataAccess.DBInterop.Queries.Abstract
{
    public abstract class AbstractQuery
    {
        public ConnectionProvider ConnectionProvider {
            get;
            protected set;
        }

        protected AbstractQuery(ConnectionProvider provider) {
            ConnectionProvider = provider;
        }

        public abstract void ExecuteQuery();

        protected abstract void ExecuteQuery(OracleCommand command);

        public abstract OracleCommand CreateOracleCommand();
    }

    public abstract class NoValueQuery : AbstractQuery
    {
        protected NoValueQuery(ConnectionProvider provider)
            : base(provider) {

        }

        public override void ExecuteQuery() {
            ExecuteQuery(CreateOracleCommand());
        }

        internal virtual void OnBeforeExecuteQuery(OracleCommand command) {

        }

        protected override void ExecuteQuery(OracleCommand command) {
            OnBeforeExecuteQuery(command);
            ConnectionProvider.ExecuteNonQuery(command);
            OnAfterExecuteQuery(command);
        }

        internal virtual void OnAfterExecuteQuery(OracleCommand command) {

        }

        public virtual void Execute() {
            ExecuteQuery();
        }
    }

    public abstract class ValueQuery<T> : AbstractQuery
    {
        public T Result {
            get;
            protected set;
        }

        protected ValueQuery(ConnectionProvider provider)
            : base(provider) {
            Result = default(T);
        }

        public virtual T Execute() {
            ExecuteQuery();
            return Result;
        }

        public override void ExecuteQuery() {
            ExecuteQuery(CreateOracleCommand());
        }
    }

    public abstract class RowQuery<T> : ValueQuery<T>
    {
        public DataSet RawData {
            get;
            protected set;
        }

        protected RowQuery(ConnectionProvider provider)
            : base(provider) {
        }
    }

    public abstract class TableQuery<T> : RowQuery<IEnumerable<T>>
    {
        protected TableQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override void ExecuteQuery(OracleCommand command) {
            RawData = ConnectionProvider.ExecuteTable(command);
            if (RawData.Tables.Count > 0) {
                var table = RawData.Tables[0];
                var result = new List<T>();
                foreach (DataRow row in table.Rows) {
                    result.Add(Read(row));
                }
                Result = result;
            }
        }

        public abstract T Read(DataRow row);
    }

    public abstract class OneRowQuery<T> : RowQuery<T>
    {
        protected OneRowQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override void ExecuteQuery(OracleCommand command) {
            RawData = ConnectionProvider.ExecuteTable(command);
            if (RawData.Tables.Count > 0) {
                var table = RawData.Tables[0];
                if (table.Rows.Count > 0) {
                    Result = Read(table.Rows[0]);
                }
            }
        }

        public abstract T Read(DataRow row);
    }

    public abstract class ScalarQuery<T> : ValueQuery<T>
    {
        public object RawData {
            get;
            protected set;
        }

        protected ScalarQuery(ConnectionProvider provider)
            : base(provider) {
        }

        protected override void ExecuteQuery(OracleCommand command) {
            RawData = ConnectionProvider.ExecuteScalar(command);
        }

        public override T Execute() {
            base.Execute();
            return Read(RawData);
        }

        protected virtual T Read(object obj) {
            return (T)obj;
        }
    }

}
