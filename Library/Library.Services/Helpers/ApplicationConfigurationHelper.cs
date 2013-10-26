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

        /*const string ConnectionString =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=127.0.0.1)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=orcl)));User Id=lab;Password=lab;";*/

        public static string GetOracleConnectionString() {
            return string.Format(
                "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1})))(CONNECT_DATA=(SERVICE_NAME={2})));User Id={3};Password={4};",
                ConnectionSection.Host,
                ConnectionSection.Port,
                ConnectionSection.ServiceName,
                ConnectionSection.UserId,
                ConnectionSection.Password
                );
        }
    }
}
