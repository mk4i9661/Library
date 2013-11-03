using Library.Contracts;
using Library.DataContracts.Concrete;
using Library.Proxies;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
            var authenticationPool = new ProxyPool<IAuthentication, AuthenticationProxy>(() => new AuthenticationProxy());
            var bibliographerPool = new ProxyPool<IBibliographer, BibliographerProxy>(() => new BibliographerProxy(Kernel.Get<AuthenticationData>()));

            kernel.Bind<IAuthentication>().ToMethod(method => authenticationPool.Get());
            kernel.Bind<IBibliographer>().ToMethod(method => bibliographerPool.Get());
            return kernel;
        }

    }

    class ProxyPool<TContract, TProxy>
        where TContract : class
        where TProxy : DisposableProxy<TContract>, TContract
    {
        TProxy Proxy {
            get;
            set;
        }

        Func<TProxy> Factory {
            get;
            set;
        }

        public ProxyPool(Func<TProxy> factory) {
            Factory = factory;
        }

        public TContract Get() {
            if (Proxy == null || Proxy.State != CommunicationState.Opened) {
                Proxy = Factory();
            }
            return Proxy;
        }
    }
}
