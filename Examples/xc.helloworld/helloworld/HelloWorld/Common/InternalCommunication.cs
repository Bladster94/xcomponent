﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using XComponent.Engine.Processing;
using XComponent.Common.Processing;
using XComponent.Engine.Processing.Domain;
using XComponent.Common.ApiContext;
using XComponent.Communication;

namespace XComponent.HelloWorld.Common
{
    public class InternalCommunication : IInternalCommunication
    {
        private const string ComponentName = "HelloWorld";

		private IAgentManager _agentManager;
        private Dictionary<int, EngineAgent> _engineAgentsById = new Dictionary<int, EngineAgent>();
        private Dictionary<int, List<EngineAgent>> _engineAgentsByStateMachine = new Dictionary<int, List<EngineAgent>>();

        public InternalCommunication(IAgentManager agentManager)
        {
            _agentManager = agentManager;
        }
		
        public void Init(string configFile)
        {
			foreach( var engineAgent in _agentManager.FilterEngineAgentForInternalAPI(-69981087))
			{
				_engineAgentsById.Add(engineAgent.Id, engineAgent);
				
				foreach( var detail in Agent.getAgentDetails(engineAgent))
				{
					if (detail.Key.Equals(-69981087))
					{
						foreach( var stateMachineCode in detail.Value )
						{
							if(!_engineAgentsByStateMachine.ContainsKey(stateMachineCode))
							{
								_engineAgentsByStateMachine.Add(stateMachineCode, new List<EngineAgent>());
							}

							_engineAgentsByStateMachine[stateMachineCode].Add(engineAgent);
						}
					}
				}
			}
        }

		public void Send(Context context, XComponent.HelloWorld.UserObject.SayHello evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.HelloWorld.UserObject.SayHello(), IncomingEventType.Transition, HeaderFactory.Create(context, 9, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.HelloWorld.UserObject.SayHello evt, string privateTopic = null)
        {
            SendEvent(StdEnum.HelloWorldManager, evt != null ? evt : new XComponent.HelloWorld.UserObject.SayHello(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.HelloWorld.UserObject.SayHello evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.HelloWorld.UserObject.SayHello(), IncomingEventType.Transition, HeaderFactory.Create(9, (int)stateMachineEnum, -69981087, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		private void PostOnStateMachine(IncomingEvent incomingEvent, StdEnum stateMachineEnum)
		{
			foreach(var engineAgent in GetEngineAgents(stateMachineEnum))
			{
				Agent.Post(engineAgent, incomingEvent);
			}
		}

		private IEnumerable<EngineAgent> GetEngineAgents(StdEnum stateMachineEnum)
        {
			switch(stateMachineEnum)
			{
				case StdEnum.HelloWorldManager :
					return _engineAgentsByStateMachine[-829536631];
				case StdEnum.HelloResponse :
					return _engineAgentsByStateMachine[1837059171];
			}

            return new List<EngineAgent>();
        }
    }
}
