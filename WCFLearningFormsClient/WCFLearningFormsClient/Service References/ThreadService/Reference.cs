﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFLearningFormsClient.ThreadService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ThreadService.IThreadService")]
    public interface IThreadService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IThreadService/CreateThread", ReplyAction="http://tempuri.org/IThreadService/CreateThreadResponse")]
        bool CreateThread(string name, System.Nullable<System.Guid> creatorID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IThreadService/CreateThread", ReplyAction="http://tempuri.org/IThreadService/CreateThreadResponse")]
        System.Threading.Tasks.Task<bool> CreateThreadAsync(string name, System.Nullable<System.Guid> creatorID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IThreadService/GetThreads", ReplyAction="http://tempuri.org/IThreadService/GetThreadsResponse")]
        string[] GetThreads();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IThreadService/GetThreads", ReplyAction="http://tempuri.org/IThreadService/GetThreadsResponse")]
        System.Threading.Tasks.Task<string[]> GetThreadsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IThreadServiceChannel : WCFLearningFormsClient.ThreadService.IThreadService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ThreadServiceClient : System.ServiceModel.ClientBase<WCFLearningFormsClient.ThreadService.IThreadService>, WCFLearningFormsClient.ThreadService.IThreadService {
        
        public ThreadServiceClient() {
        }
        
        public ThreadServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ThreadServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ThreadServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ThreadServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CreateThread(string name, System.Nullable<System.Guid> creatorID) {
            return base.Channel.CreateThread(name, creatorID);
        }
        
        public System.Threading.Tasks.Task<bool> CreateThreadAsync(string name, System.Nullable<System.Guid> creatorID) {
            return base.Channel.CreateThreadAsync(name, creatorID);
        }
        
        public string[] GetThreads() {
            return base.Channel.GetThreads();
        }
        
        public System.Threading.Tasks.Task<string[]> GetThreadsAsync() {
            return base.Channel.GetThreadsAsync();
        }
    }
}
