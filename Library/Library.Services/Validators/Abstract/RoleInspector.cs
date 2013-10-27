using Library.DataContracts.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Validators.Abstract
{
    public abstract class RoleInspector : IParameterInspector
    {
        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState) {
            
        }

        public object BeforeCall(string operationName, object[] inputs) {
            var header = OperationContext.Current.RequestContext.RequestMessage.Headers.GetHeader<AuthenticationHeader>("AuthenticationHeader", "");
            if (header == null ) {
                throw new Exception("Неопознаный запрос");
            }
            if (!ValidateRole(header.Data.Employee.Role)) {
                throw new Exception("Доступ запрещен");
            }
            return null;
        }

        protected abstract bool ValidateRole(Role role);
    }
}
