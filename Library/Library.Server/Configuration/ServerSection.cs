using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Server.Configuration
{
    class ServerSection : ConfigurationSection
    {
        [ConfigurationProperty("host", IsRequired = true)]
        public string Host {
            get {
                return (string)base["host"];
            }
        }
    }
}
