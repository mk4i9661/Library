using Library.Contracts;
using Library.DataContracts.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Proxies
{
    public class BibliographerProxy : AuthenticableProxy<IBibliographer>, IBibliographer
    {
        public BibliographerProxy(AuthenticationData data)
            : base(data) {

        }

        public void DoSomething() {
            ExecuteScoped(() => Channel.DoSomething());
        }
    }
}
