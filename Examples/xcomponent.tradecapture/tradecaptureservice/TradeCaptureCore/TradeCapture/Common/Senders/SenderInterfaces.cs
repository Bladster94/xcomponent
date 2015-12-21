//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace XComponent.TradeCapture.Common.Senders
{
    using System;
    using XComponent.Common.ApiContext;
    using XComponent.TradeCapture.Common;
    
	public interface IInitMappingInitOnMappingTransactionSenderInterface
    {
		void GetInstrumentSnapshot(Context context);
		
		
		void GetInstrumentSnapshot(Context context, XComponent.Referential.UserObject.GetSnapshot transitionEvent);
		
		
		void SendEvent(XComponent.Referential.UserObject.GetSnapshot evt);
			void SendEvent(StdEnum stdEnum, XComponent.Referential.UserObject.GetSnapshot evt);
		
    }
	public interface IRejectRejectOnTransactionRejectedTransactionSenderInterface
    {
		
		
		
		
		
    }
	public interface IUpdateAndRetryUpdateAndRetryOnValidationTransactionSenderInterface
    {
		void InitMapping(Context context);
		
		
		void InitMapping(Context context, XComponent.TradeCapture.UserObject.Init transitionEvent);
		
		
		void SendEvent(XComponent.TradeCapture.UserObject.Init evt);
			void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.Init evt);
		
    }
	public interface ITimeOutDefaultEventOnTransactionRejectedTransactionSenderInterface
    {
		
		
		
		
		
    }
	public interface IErrorErrorOnErrorOnMappingTransactionSenderInterface
    {
		void UpdateReferential(Context context);
		
		
		void UpdateReferential(Context context, XComponent.Referential.UserObject.Instrument transitionEvent);
		
		
		void SendEvent(XComponent.Referential.UserObject.Instrument evt);
			void SendEvent(StdEnum stdEnum, XComponent.Referential.UserObject.Instrument evt);
		
    }
	public interface IAcceptedAcceptOnTransactionAcceptedTransactionSenderInterface
    {
		
		
		
		
		
    }
	public interface IReferentialNotificationInstrumentSnapshotOnMappingTransactionSenderInterface
    {
		void Error(Context context);
		void Accepted(Context context);
		
		
		void Error(Context context, XComponent.TradeCapture.UserObject.Error transitionEvent);
		void Accepted(Context context, XComponent.TradeCapture.UserObject.Accept transitionEvent);
		
		
		void SendEvent(XComponent.TradeCapture.UserObject.Error evt);
			void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.Error evt);
		void SendEvent(XComponent.TradeCapture.UserObject.Accept evt);
			void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.Accept evt);
		
    }
	public interface INewTransactionTransactionOnValidationTransactionSenderInterface
    {
		void ValidationError(Context context);
		void InitMapping(Context context);
		
		
		void ValidationError(Context context, XComponent.TradeCapture.UserObject.Error transitionEvent);
		void InitMapping(Context context, XComponent.TradeCapture.UserObject.Init transitionEvent);
		
		
		void SendEvent(XComponent.TradeCapture.UserObject.Error evt);
			void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.Error evt);
		void SendEvent(XComponent.TradeCapture.UserObject.Init evt);
			void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.Init evt);
		
    }
	public interface IUpdateReferentialInstrumentOnUpdateReferentialUpdateReferentialSenderInterface
    {
		
		
		
		
		
    }
	
}
