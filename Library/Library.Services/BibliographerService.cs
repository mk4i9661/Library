using Library.Contracts;
using Library.DataAccess.DBInterop.Queries.Concrete;
using Library.DataContracts.Concrete;
using Library.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Library.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class BibliographerService : AbstractService, IBibliographer
    {
        public IEnumerable<Publisher> GetPublishers() {
            return Ninject.Get<GetPublishersQuery>().Execute();
        }

        public Publisher AddPublisher(Publisher publisher) {
            throw new NotImplementedException();
        }

        public Publisher UpdatePublisher(Publisher publisher) {
            throw new NotImplementedException();
        }

        public Publisher DeletePublisher(Publisher publisher) {
            throw new NotImplementedException();
        }
    }
}
