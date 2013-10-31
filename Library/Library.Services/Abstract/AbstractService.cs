using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.DBInterop;
using Library.Services.Helpers;
using Ninject;

namespace Library.Services.Abstract
{
    public class AbstractService
    {
        public IKernel Ninject {
            get;
            private set;
        }

        protected ConnectionProviderFactory Factory {
            get;
            private set;
        }

        protected AbstractService() {
            Factory = new ConnectionProviderFactory(ApplicationConfigurationHelper.GetOracleConnectionString());
            Ninject = new StandardKernel();
            Ninject.Bind<ConnectionProvider>().ToMethod(context => Factory.Get());
        }
    }
}
