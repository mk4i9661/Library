using Library.Contracts;
using Library.DataContracts.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Proxies
{
    public class ChiefProxy : AuthenticableProxy<IChief>, IChief
    {
        public ChiefProxy(AuthenticationData data)
            : base(data) {
        }

        public IEnumerable<ReportBook> GetBooks(Rubric rubric = null, Publisher publisher = null, string search = "") {
            return ExecuteScoped(() => Channel.GetBooks(rubric, publisher, search));
        }

        public IEnumerable<Publisher> GetPublishers() {
            return ExecuteScoped(() => Channel.GetPublishers());
        }

        public IEnumerable<Rubric> GetRubrics() {
            return ExecuteScoped(() => Channel.GetRubrics());
        }
    }
}
