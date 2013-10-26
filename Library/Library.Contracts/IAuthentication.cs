using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Library.DataContracts;
using Library.DataContracts.Concrete;

namespace Library.Contracts
{
    [ServiceContract]
    public interface IAuthentication
    {
        [OperationContract]
        AuthenticationData Authenticate(string name, string hash);
        [OperationContract]
        bool IsAuthorized(AuthenticationData data);
        [OperationContract(IsOneWay = true)]
        void LogOut(AuthenticationData data);
    }
}
