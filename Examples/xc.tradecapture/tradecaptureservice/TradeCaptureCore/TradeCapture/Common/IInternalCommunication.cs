﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using XComponent.Common.ApiContext;

namespace XComponent.TradeCapture.Common
{
    public interface IInternalCommunication
    {
        void Init(string configFile);

        void Send(Context context, XComponent.TradeCapture.UserObject.Transaction evt, string privateTopic = null);

        void Send(Context context, XComponent.TradeCapture.UserObject.Error evt, string privateTopic = null);

        void Send(Context context, XComponent.TradeCapture.UserObject.Init evt, string privateTopic = null);

        void Send(Context context, XComponent.TradeCapture.UserObject.Reject evt, string privateTopic = null);

        void Send(Context context, XComponent.TradeCapture.UserObject.UpdateAndRetry evt, string privateTopic = null);

        void Send(Context context, XComponent.Common.Event.DefaultEvent evt, string privateTopic = null);

        void Send(Context context, XComponent.TradeCapture.UserObject.Accept evt, string privateTopic = null);

        void Send(Context context, XComponent.Referential.UserObject.GetSnapshot evt, string privateTopic = null);

        void Send(Context context, XComponent.Referential.UserObject.InstrumentSnapshot evt, string privateTopic = null);

        void Send(Context context, XComponent.Referential.UserObject.Instrument evt, string privateTopic = null);

        void SendEvent(XComponent.TradeCapture.UserObject.Transaction evt, string privateTopic = null);

        void SendEvent(XComponent.TradeCapture.UserObject.Error evt, string privateTopic = null);

        void SendEvent(XComponent.TradeCapture.UserObject.Init evt, string privateTopic = null);

        void SendEvent(XComponent.TradeCapture.UserObject.Reject evt, string privateTopic = null);

        void SendEvent(XComponent.TradeCapture.UserObject.UpdateAndRetry evt, string privateTopic = null);

        void SendEvent(XComponent.Common.Event.DefaultEvent evt, string privateTopic = null);

        void SendEvent(XComponent.TradeCapture.UserObject.Accept evt, string privateTopic = null);

        void SendEvent(XComponent.Referential.UserObject.GetSnapshot evt, string privateTopic = null);

        void SendEvent(XComponent.Referential.UserObject.InstrumentSnapshot evt, string privateTopic = null);

        void SendEvent(XComponent.Referential.UserObject.Instrument evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.Transaction evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.Error evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.Init evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.Reject evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.UpdateAndRetry evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Common.Event.DefaultEvent evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.Accept evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Referential.UserObject.GetSnapshot evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Referential.UserObject.InstrumentSnapshot evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Referential.UserObject.Instrument evt, string privateTopic = null);

    }
}
