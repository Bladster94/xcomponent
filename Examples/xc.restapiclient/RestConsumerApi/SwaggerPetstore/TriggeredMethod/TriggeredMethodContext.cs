// //-----------------------------------------------------------------------------
//// <auto-generated>
////     This code was generated by XCTools.
////     Changes to this file may cause incorrect behavior and will be lost if
////     the code is regenerated.
//// </auto-generated>
////------------------------------------------------------------------------------

namespace XComponent.SwaggerPetstore.TriggeredMethod
{
    using System;
    using XComponent.SwaggerPetstore.Common;
    using XComponent.SwaggerPetstore.Common.Senders;
    using XComponent.Runtime.Shared.TriggeredMethods;
    using XComponent.SwaggerPetstore.TriggeredMethod.ServiceClient;
    using XComponent.Runtime.Shared.Manager;
    using XComponent.Common.Logger;

    using Microsoft.Rest;


public partial class TriggeredMethodContext : ICustomTriggeredMethodContext
    {
        public SwaggerPetstore ServiceClient { get; private set; }

        public void OnComponentInitialized()
        {
            // You can override the service uri by setting a ServiceUri string resource..
            var uriOverride = ComponentManager.KeyValueParameters.GetValue("ServiceUri");
            this.ServiceClient = string.IsNullOrEmpty(uriOverride) ? new SwaggerPetstore() : new SwaggerPetstore (new Uri(uriOverride));
            ServiceClientTracing.AddTracingInterceptor(new SwaggerPetstoreServiceClientTracingInterceptor());
            ServiceClientTracing.IsEnabled = true;
            LogInfo(string.Format("Initialized service client. URL: {0}", this.ServiceClient.BaseUri));
        }
        
        public void UnHanledException(XComponent.Runtime.StateMachine.Exceptions.TriggeredMethodException exception)
        {
        }

        public void LogInfo(string message)
        {
            GetLogger(LogKeyEnum.SwaggerPetstoreLogger).Info(message);
        }

        public void LogError(string message)
        {
            GetLogger(LogKeyEnum.SwaggerPetstoreLogger).Error(message);
        }
}
 
   
    public partial interface ICustomTriggeredMethodContext
    {
        SwaggerPetstore ServiceClient { get; }
        void LogInfo(string message);
        void LogError(string message);
    }
}
