﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WhixerShipments.Facade.ServiceWantToSend {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceWantToSend.IServiceWantToSend")]
    public interface IServiceWantToSend {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceWantToSend/Ping", ReplyAction="http://tempuri.org/IServiceWantToSend/PingResponse")]
        bool Ping();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceWantToSend/Ping", ReplyAction="http://tempuri.org/IServiceWantToSend/PingResponse")]
        System.Threading.Tasks.Task<bool> PingAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceWantToSendChannel : WhixerShipments.Facade.ServiceWantToSend.IServiceWantToSend, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceWantToSendClient : System.ServiceModel.ClientBase<WhixerShipments.Facade.ServiceWantToSend.IServiceWantToSend>, WhixerShipments.Facade.ServiceWantToSend.IServiceWantToSend {
        
        public ServiceWantToSendClient() {
        }
        
        public ServiceWantToSendClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceWantToSendClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceWantToSendClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceWantToSendClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Ping() {
            return base.Channel.Ping();
        }
        
        public System.Threading.Tasks.Task<bool> PingAsync() {
            return base.Channel.PingAsync();
        }
    }
}
