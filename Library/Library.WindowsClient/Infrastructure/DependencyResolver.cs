using Library.Contracts;
using Library.Proxies;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.WindowsClient.Infrastructure
{
    static class DependencyResolver
    {
        public static IKernel Kernel {
            get;
            private set;
        }

        static DependencyResolver() {
            Kernel = GetKernel();
        }

        static IKernel GetKernel() {
            var kernel = new StandardKernel();
            kernel.Bind<IAuthentication>().To(typeof(AuthenticationProxy));
            kernel.Bind<IBibliographer>().To(typeof(BibliographerProxy));
            return kernel;
        }

    }
}
