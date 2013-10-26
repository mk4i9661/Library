using Library.Contracts;
using Library.DataContracts.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Proxies
{
    public class AuthenticationProxy : DisposableProxy<IAuthentication>, IAuthentication
    {
        public AuthenticationData Authenticate(string name, string hash) {
            return Channel.Authenticate(name, hash);
        }

        public bool IsAuthorized(AuthenticationData data) {
            return Channel.IsAuthorized(data);
        }

        public void LogOut(AuthenticationData data) {
            Channel.LogOut(data);
        }
    }
}
