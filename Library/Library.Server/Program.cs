using Library.Contracts;
using Library.Server.Configuration;
using Library.Server.Configuration.Helpers;
using Library.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Server
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            var helper = GetHelper();

            var server = new ServiceHost(typeof(AuthenticationService));
            server.AddServiceEndpoint(typeof(IAuthentication), new NetTcpBinding(SecurityMode.None) {
                MaxReceivedMessageSize = int.MaxValue,
                MaxBufferSize = int.MaxValue,
                CloseTimeout = TimeSpan.MaxValue,
                SendTimeout = TimeSpan.MaxValue,
                ReceiveTimeout = TimeSpan.MaxValue,
                OpenTimeout = TimeSpan.MaxValue,
            }, helper.Host + "Authentication");
            server.Open();
            Console.WriteLine("The services is ready. Press any key to terminate services");
            Console.ReadKey();
        }

        static ServerConfigurationHelper GetHelper() {
            return new ServerConfigurationHelper((ServerSection)ConfigurationManager.GetSection("serverConfig"));
        }
    }
}
