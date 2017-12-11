﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using XComponent.Common.ApiContext;
using XComponent.Trade.Common;

namespace XComponent.Trade.Common.Senders
{
    public interface IProcessOrderCreationOrderCreationOnUpTradeProcessorSenderInterface
    {
		void CreateTrade(Context context, string privateTopic = null);

		void ExecuteTrade(Context context);

		void Execute(Context context);


		void CreateTrade(Context context, XComponent.Trade.UserObject.Trade transitionEvent, string privateTopic = null);

		void ExecuteTrade(Context context, XComponent.Trade.UserObject.TradeExecution transitionEvent, string privateTopic = null);

		void Execute(Context context, XComponent.Trade.UserObject.TradeExecution transitionEvent, string privateTopic = null);


		void SendEvent(XComponent.Trade.UserObject.Trade evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.Trade.UserObject.Trade evt, string privateTopic = null);

		void SendEvent(XComponent.Trade.UserObject.TradeExecution evt);

		void SendEvent(StdEnum stdEnum, XComponent.Trade.UserObject.TradeExecution evt);

    }

    public interface IExecuteTradeTradeExecutionOnUpTradeProcessorSenderInterface
    {
		void CreateTrade(Context context, string privateTopic = null);

		void ExecuteTrade(Context context);

		void Execute(Context context);


		void CreateTrade(Context context, XComponent.Trade.UserObject.Trade transitionEvent, string privateTopic = null);

		void ExecuteTrade(Context context, XComponent.Trade.UserObject.TradeExecution transitionEvent, string privateTopic = null);

		void Execute(Context context, XComponent.Trade.UserObject.TradeExecution transitionEvent, string privateTopic = null);


		void SendEvent(XComponent.Trade.UserObject.Trade evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.Trade.UserObject.Trade evt, string privateTopic = null);

		void SendEvent(XComponent.Trade.UserObject.TradeExecution evt);

		void SendEvent(StdEnum stdEnum, XComponent.Trade.UserObject.TradeExecution evt);

    }

    public interface IProcessOrderExecutionOrderExecutionOnUpTradeProcessorSenderInterface
    {
		void CreateTrade(Context context, string privateTopic = null);

		void ExecuteTrade(Context context);

		void Execute(Context context);


		void CreateTrade(Context context, XComponent.Trade.UserObject.Trade transitionEvent, string privateTopic = null);

		void ExecuteTrade(Context context, XComponent.Trade.UserObject.TradeExecution transitionEvent, string privateTopic = null);

		void Execute(Context context, XComponent.Trade.UserObject.TradeExecution transitionEvent, string privateTopic = null);


		void SendEvent(XComponent.Trade.UserObject.Trade evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.Trade.UserObject.Trade evt, string privateTopic = null);

		void SendEvent(XComponent.Trade.UserObject.TradeExecution evt);

		void SendEvent(StdEnum stdEnum, XComponent.Trade.UserObject.TradeExecution evt);

    }

    public interface IExecuteTradeExecutionOnExecutedTradeSenderInterface
    {


    }

    public interface ICreateTradeTradeOnWaitingForExecutionTradeSenderInterface
    {


    }

}