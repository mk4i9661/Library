using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.DBInterop.Queries.Abstract;
using Library.DataContracts.Concrete;
using Oracle.DataAccess.Client;

namespace Library.DataAccess.DBInterop.Queries.Concrete
{
    public class GetEmployeesQuery : TableQuery<Employee>
    {
        const string Query = @"SELECT 
                                  e.Employee_ID, e.Employee_Name, e.Employee_Password,
                                  e.Employee_Role_ID, r.role_name
                                FROM employee E
                                INNER JOIN Role R ON e.employee_role_id = r.role_id";

        public GetEmployeesQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override Employee Read(DataRow row) {
            return new Employee() {
                Id = Convert.ToInt32(row.Field<decimal>("Employee_ID")),
                Name = row.Field<string>("Employee_Name"),
                Password = row.Field<string>("Employee_Password"),
                Role = new Role() {
                    Id = (RoleId)Convert.ToInt32(row.Field<decimal>("Employee_Role_ID")),
                    Name = row.Field<string>("role_name")
                }
            };
        }

        public override OracleCommand CreateSqlCommand() {
            return new OracleCommand(Query);
        }
    }
}
