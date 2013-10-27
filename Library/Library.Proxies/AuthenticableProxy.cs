using Library.DataContracts.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Library.Proxies
{
    public class AuthenticableProxy<T> : DisposableProxy<T> where T : class
    {
        protected AuthenticationData AuthenticationData {
            get;
            set;
        }

        public AuthenticableProxy(AuthenticationData data) {
            AuthenticationData = data;
        }

        protected void AttachHeader() {
            var header = new MessageHeader<AuthenticationHeader>(new AuthenticationHeader() {
                Data = AuthenticationData
            });
            OperationContext.Current.OutgoingMessageHeaders.Add(header.GetUntypedHeader("AuthenticationHeader", ""));
        }

        protected void ExecuteScoped(Action action) {
            using (var scope = new OperationContextScope(InnerChannel)) {
                AttachHeader();
                action();
            }
        }

        protected TR ExecuteScoped<TR>(Func<TR> function) {
            using (var scope = new OperationContextScope(InnerChannel)) {
                AttachHeader();
                return function();
            }
        }
    }
}
