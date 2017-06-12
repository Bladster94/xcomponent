﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using XComponent.Common.ApiContext;
using XComponent.ChatManager.Common;

namespace XComponent.ChatManager.Common.Senders
{
    public class PublishMessageSentMessageOnCreatedChatroomSender : AbstractSender, IPublishMessageSentMessageOnCreatedChatroomSenderInterface
    {

		public void PublishMessage(Context context, XComponent.ChatManager.UserObject.PublishedMessage transitionEvent, string privateTopic = null)
		{
			_internalAPI.PublishMessage(context, transitionEvent, privateTopic);
		}


		public void SendEvent(XComponent.ChatManager.UserObject.PublishedMessage evt, string privateTopic = null)
		{
			_internalAPI.SendEvent(evt, privateTopic);
		}

		public void SendEvent(StdEnum stdEnum, XComponent.ChatManager.UserObject.PublishedMessage evt, string privateTopic = null)
		{
			_internalAPI.SendEvent(stdEnum, evt, privateTopic);
		}

    }

    public class CreateRoomCreateChatroomOnCreatedChatroomSender : AbstractSender, ICreateRoomCreateChatroomOnCreatedChatroomSenderInterface
    {

		public void PublishMessage(Context context, XComponent.ChatManager.UserObject.PublishedMessage transitionEvent, string privateTopic = null)
		{
			_internalAPI.PublishMessage(context, transitionEvent, privateTopic);
		}


		public void SendEvent(XComponent.ChatManager.UserObject.PublishedMessage evt, string privateTopic = null)
		{
			_internalAPI.SendEvent(evt, privateTopic);
		}

		public void SendEvent(StdEnum stdEnum, XComponent.ChatManager.UserObject.PublishedMessage evt, string privateTopic = null)
		{
			_internalAPI.SendEvent(stdEnum, evt, privateTopic);
		}

    }

    public class PublishMessagePublishedMessageOnPublishedPublishedMessageSender : AbstractSender, IPublishMessagePublishedMessageOnPublishedPublishedMessageSenderInterface
    {


    }

}