using Library.Services.Validators.InspectorFactories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Validators
{
    public class RoleValidationBehavior : IEndpointBehavior
    {
        public IRoleInspectorFactory Factory {
            get;
            set;
        }

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters) {

        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime) {
            foreach (var clientOperation in clientRuntime.Operations) {
                clientOperation.ParameterInspectors.Add(Factory.Create());
            }
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher) {
            foreach (var dispatchOperation in endpointDispatcher.DispatchRuntime.Operations) {
                dispatchOperation.ParameterInspectors.Add(Factory.Create());
            }
        }

        public void Validate(ServiceEndpoint endpoint) {

        }
    }
}
