using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Library.Contracts;
using Library.DataAccess.DBInterop.Queries.Concrete;
using Library.DataContracts;
using Library.DataContracts.Concrete;
using Library.Services.Abstract;
using System.ServiceModel.Description;

namespace Library.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class AuthenticationService : AbstractService, IAuthentication
    {
        ConcurrentDictionary<Guid, AuthenticationData> Authorized {
            get;
            set;
        }

        public AuthenticationService() {
            Authorized = new ConcurrentDictionary<Guid, AuthenticationData>();
        }

        public AuthenticationData Authenticate(string name, string hash) {
            var query = new GetEmployeesQuery(GetConnectionProvider());
            var employee = query.Execute().FirstOrDefault(e => e.Name == name && e.Password == hash);
            if (employee != null) {
                var result = new AuthenticationData() {
                    Id = Guid.NewGuid(),
                    Employee = employee
                };
                Authorized[result.Id] = result;
                return result;
            }
            return null;
        }


        public bool IsAuthorized(AuthenticationData data) {
            return data == null ? false : Authorized.ContainsKey(data.Id);
        }

        public void LogOut(AuthenticationData data) {
            if (data != null) {
                var result = (AuthenticationData)null;
                Authorized.TryRemove(data.Id, out result);
            }
        }
    }
}
