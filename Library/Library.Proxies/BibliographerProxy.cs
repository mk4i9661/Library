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

        public IEnumerable<Publisher> GetPublishers() {
            return ExecuteScoped(() => Channel.GetPublishers());
        }

        public Publisher AddPublisher(Publisher publisher) {
            return ExecuteScoped(() => Channel.AddPublisher(publisher));
        }

        public Publisher UpdatePublisher(Publisher publisher) {
            return ExecuteScoped(() => Channel.UpdatePublisher(publisher));
        }

        public Publisher DeletePublisher(Publisher publisher) {
            return ExecuteScoped(() => Channel.DeletePublisher(publisher));
        }
    }
}
