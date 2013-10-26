using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Configuration
{
    public class OracleConnectionSection : ConfigurationSection
    {

        [ConfigurationProperty("host", IsRequired = true)]
        public string Host {
            get {
                return (string)base["host"];
            }
        }

        [ConfigurationProperty("port", IsRequired = true)]
        public int Port {
            get {
                return (int)base["port"];
            }
        }

        [ConfigurationProperty("serviceName", IsRequired = true)]
        public string ServiceName {
            get {
                return (string)base["serviceName"];
            }
        }

        [ConfigurationProperty("userId", IsRequired = true)]
        public string UserId {
            get {
                return (string)base["userId"];
            }
        }

        [ConfigurationProperty("password", IsRequired = true)]
        public string Password {
            get {
                return (string)base["password"];
            }
        }
    }
}
