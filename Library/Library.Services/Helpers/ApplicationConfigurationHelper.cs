using Library.DataAccess.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Helpers
{
    public class ApplicationConfigurationHelper
    {
        static readonly OracleConnectionSection ConnectionSection;

        static ApplicationConfigurationHelper() {
            ConnectionSection = (OracleConnectionSection)ConfigurationManager.GetSection("oracleConnection");
        }

        public static string GetOracleConnectionString() {
            return string.Format("Data Source={0}:{1}/{2}; User Id={3}; Password={4}; Pooling=true;", ConnectionSection.Host, ConnectionSection.Port, ConnectionSection.ServiceName, ConnectionSection.UserId, ConnectionSection.Password);
        }
    }
}
