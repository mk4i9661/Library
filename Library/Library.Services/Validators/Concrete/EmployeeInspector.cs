using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;
using Library.DataContracts.Concrete;
using Library.Proxies;

namespace Library.Services.Validators.Concrete
{
    public class EmployeeInspector : IParameterInspector
    {
        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState) {
            
        }

        public object BeforeCall(string operationName, object[] inputs) {
            var header = OperationContext.Current.RequestContext.RequestMessage.Headers.GetHeader<AuthenticationHeader>("AuthenticationHeader", "");
            if (header == null) {
                throw new Exception("Неопознаный запрос");
            }
            using (var proxy = new AuthenticationProxy()) {
                if (!proxy.IsAuthorized(header.Data)) {
                    throw new Exception("Неавторизованный запрос");
                }
            }
            return null;
        }
    }
}
