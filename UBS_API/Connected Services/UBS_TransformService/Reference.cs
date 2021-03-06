﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UBS_API.UBS_TransformService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UBS_TransformService.ICurrencyTransform")]
    public interface ICurrencyTransform {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyTransform/Humanize", ReplyAction="http://tempuri.org/ICurrencyTransform/HumanizeResponse")]
        string Humanize(int ammount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyTransform/Humanize", ReplyAction="http://tempuri.org/ICurrencyTransform/HumanizeResponse")]
        System.Threading.Tasks.Task<string> HumanizeAsync(int ammount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyTransform/HumanzieDouble", ReplyAction="http://tempuri.org/ICurrencyTransform/HumanzieDoubleResponse")]
        string HumanzieDouble(double ammount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyTransform/HumanzieDouble", ReplyAction="http://tempuri.org/ICurrencyTransform/HumanzieDoubleResponse")]
        System.Threading.Tasks.Task<string> HumanzieDoubleAsync(double ammount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICurrencyTransformChannel : UBS_API.UBS_TransformService.ICurrencyTransform, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CurrencyTransformClient : System.ServiceModel.ClientBase<UBS_API.UBS_TransformService.ICurrencyTransform>, UBS_API.UBS_TransformService.ICurrencyTransform {
        
        public CurrencyTransformClient() {
        }
        
        public CurrencyTransformClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CurrencyTransformClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CurrencyTransformClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CurrencyTransformClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Humanize(int ammount) {
            return base.Channel.Humanize(ammount);
        }
        
        public System.Threading.Tasks.Task<string> HumanizeAsync(int ammount) {
            return base.Channel.HumanizeAsync(ammount);
        }
        
        public string HumanzieDouble(double ammount) {
            return base.Channel.HumanzieDouble(ammount);
        }
        
        public System.Threading.Tasks.Task<string> HumanzieDoubleAsync(double ammount) {
            return base.Channel.HumanzieDoubleAsync(ammount);
        }
    }
}
