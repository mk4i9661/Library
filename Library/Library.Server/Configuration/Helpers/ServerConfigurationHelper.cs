using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Server.Configuration.Helpers
{
    class ServerConfigurationHelper
    {

        public ServerConfigurationHelper(ServerSection section) {
            Host = section.Host;
        }

        public string Host {
            get;
            protected set;
        }
    }
}
