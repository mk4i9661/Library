using Library.Contracts;
using Library.Server.Configuration;
using Library.Server.Configuration.Helpers;
using Library.Services;
using Library.Services.Validators;
using Library.Services.Validators.InspectorFactories.Abstract;
using Library.Services.Validators.InspectorFactories.Concrete;
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
            var helper = GetHelper();
            var authentication = GetConfiguredHost(typeof(AuthenticationService), typeof(IAuthentication), helper.Host + "Authentication");
            var bibliographer = GetConfiguredHost(typeof(BibliographerService), typeof(IBibliographer), helper.Host + "Bibliographer", new BibliographerInspectorFactory());
            var @operator = GetConfiguredHost(typeof(OperatorService), typeof(IOperator), helper.Host + "Operator", new OperatorInspectorFactory());
            var chief = GetConfiguredHost(typeof(ChiefService), typeof(IChief), helper.Host + "Chief", new ChiefInspectorFactory());

            authentication.Open();
            bibliographer.Open();
            @operator.Open();
            chief.Open();

            Console.WriteLine("The services is ready. Press any key to terminate services");
            Console.ReadKey();
        }

        static ServiceHost GetConfiguredHost(Type service, Type contract, string address) {
            var host = new ServiceHost(service);
            var endpoint = host.AddServiceEndpoint(contract, new NetTcpBinding(SecurityMode.None) {
                MaxReceivedMessageSize = int.MaxValue,
                MaxBufferSize = int.MaxValue,
                CloseTimeout = TimeSpan.MaxValue,
                SendTimeout = TimeSpan.MaxValue,
                ReceiveTimeout = TimeSpan.MaxValue,
                OpenTimeout = TimeSpan.MaxValue,
            }, address);
            return host;
        }

        static ServiceHost GetConfiguredHost(Type service, Type contract, string address, IRoleInspectorFactory factory) {
            var host = GetConfiguredHost(service, contract, address);
            host.Description.Endpoints[0].EndpointBehaviors.Add(new EmployeeValidationBehavior());
            host.Description.Endpoints[0].EndpointBehaviors.Add(new RoleValidationBehavior() {
                Factory = factory
            });
            return host;
        }

        static ServerConfigurationHelper GetHelper() {
            return new ServerConfigurationHelper((ServerSection)ConfigurationManager.GetSection("serverConfig"));
        }
    }
}
