﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WhixerShipments.Facade.ServiceShoppingCart {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceShoppingCart.IServiceShoppingCart")]
    public interface IServiceShoppingCart {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceShoppingCart/Ping", ReplyAction="http://tempuri.org/IServiceShoppingCart/PingResponse")]
        bool Ping();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceShoppingCart/Ping", ReplyAction="http://tempuri.org/IServiceShoppingCart/PingResponse")]
        System.Threading.Tasks.Task<bool> PingAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceShoppingCartChannel : WhixerShipments.Facade.ServiceShoppingCart.IServiceShoppingCart, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceShoppingCartClient : System.ServiceModel.ClientBase<WhixerShipments.Facade.ServiceShoppingCart.IServiceShoppingCart>, WhixerShipments.Facade.ServiceShoppingCart.IServiceShoppingCart {
        
        public ServiceShoppingCartClient() {
        }
        
        public ServiceShoppingCartClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceShoppingCartClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceShoppingCartClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceShoppingCartClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
