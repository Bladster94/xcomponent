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

namespace XComponent.TradeCapture.Common
{
    public class InternalCommunication : IInternalCommunication
    {
        private const string ComponentName = "TradeCapture";

		private IAgentManager _agentManager;
        private Dictionary<int, EngineAgent> _engineAgentsById = new Dictionary<int, EngineAgent>();
        private Dictionary<int, List<EngineAgent>> _engineAgentsByStateMachine = new Dictionary<int, List<EngineAgent>>();

        public InternalCommunication(IAgentManager agentManager)
        {
            _agentManager = agentManager;
        }
		
        public void Init(string configFile)
        {
			foreach( var engineAgent in _agentManager.FilterEngineAgentForInternalAPI(183271270))
			{
				_engineAgentsById.Add(engineAgent.Id, engineAgent);
				
				foreach( var detail in Agent.getAgentDetails(engineAgent))
				{
					if (detail.Key.Equals(183271270))
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

		public void Send(Context context, XComponent.TradeCapture.UserObject.Transaction evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.TradeCapture.UserObject.Transaction(), IncomingEventType.Transition, HeaderFactory.Create(context, 15, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.TradeCapture.UserObject.Transaction evt, string privateTopic = null)
        {
            SendEvent(StdEnum.XCTradeProcessor, evt != null ? evt : new XComponent.TradeCapture.UserObject.Transaction(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.TradeCapture.UserObject.Transaction evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.TradeCapture.UserObject.Transaction(), IncomingEventType.Transition, HeaderFactory.Create(15, (int)stateMachineEnum, 183271270, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		public void Send(Context context, XComponent.TradeCapture.UserObject.Error evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.TradeCapture.UserObject.Error(), IncomingEventType.Transition, HeaderFactory.Create(context, 12, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.TradeCapture.UserObject.Error evt, string privateTopic = null)
        {
            SendEvent(StdEnum.Transaction, evt != null ? evt : new XComponent.TradeCapture.UserObject.Error(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.TradeCapture.UserObject.Error evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.TradeCapture.UserObject.Error(), IncomingEventType.Transition, HeaderFactory.Create(12, (int)stateMachineEnum, 183271270, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		public void Send(Context context, XComponent.TradeCapture.UserObject.Init evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.TradeCapture.UserObject.Init(), IncomingEventType.Transition, HeaderFactory.Create(context, 13, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.TradeCapture.UserObject.Init evt, string privateTopic = null)
        {
            SendEvent(StdEnum.Transaction, evt != null ? evt : new XComponent.TradeCapture.UserObject.Init(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.TradeCapture.UserObject.Init evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.TradeCapture.UserObject.Init(), IncomingEventType.Transition, HeaderFactory.Create(13, (int)stateMachineEnum, 183271270, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		public void Send(Context context, XComponent.TradeCapture.UserObject.Reject evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.TradeCapture.UserObject.Reject(), IncomingEventType.Transition, HeaderFactory.Create(context, 14, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.TradeCapture.UserObject.Reject evt, string privateTopic = null)
        {
            SendEvent(StdEnum.Transaction, evt != null ? evt : new XComponent.TradeCapture.UserObject.Reject(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.TradeCapture.UserObject.Reject evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.TradeCapture.UserObject.Reject(), IncomingEventType.Transition, HeaderFactory.Create(14, (int)stateMachineEnum, 183271270, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		public void Send(Context context, XComponent.TradeCapture.UserObject.UpdateAndRetry evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.TradeCapture.UserObject.UpdateAndRetry(), IncomingEventType.Transition, HeaderFactory.Create(context, 16, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.TradeCapture.UserObject.UpdateAndRetry evt, string privateTopic = null)
        {
            SendEvent(StdEnum.Transaction, evt != null ? evt : new XComponent.TradeCapture.UserObject.UpdateAndRetry(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.TradeCapture.UserObject.UpdateAndRetry evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.TradeCapture.UserObject.UpdateAndRetry(), IncomingEventType.Transition, HeaderFactory.Create(16, (int)stateMachineEnum, 183271270, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		public void Send(Context context, XComponent.Common.Event.DefaultEvent evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Common.Event.DefaultEvent(), IncomingEventType.Transition, HeaderFactory.Create(context, 6, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.Common.Event.DefaultEvent evt, string privateTopic = null)
        {
            SendEvent(StdEnum.Transaction, evt != null ? evt : new XComponent.Common.Event.DefaultEvent(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.Common.Event.DefaultEvent evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Common.Event.DefaultEvent(), IncomingEventType.Transition, HeaderFactory.Create(6, (int)stateMachineEnum, 183271270, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		public void Send(Context context, XComponent.TradeCapture.UserObject.Accept evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.TradeCapture.UserObject.Accept(), IncomingEventType.Transition, HeaderFactory.Create(context, 11, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.TradeCapture.UserObject.Accept evt, string privateTopic = null)
        {
            SendEvent(StdEnum.Transaction, evt != null ? evt : new XComponent.TradeCapture.UserObject.Accept(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.TradeCapture.UserObject.Accept evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.TradeCapture.UserObject.Accept(), IncomingEventType.Transition, HeaderFactory.Create(11, (int)stateMachineEnum, 183271270, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		public void Send(Context context, XComponent.Referential.UserObject.GetSnapshot evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Referential.UserObject.GetSnapshot(), IncomingEventType.Transition, HeaderFactory.Create(context, 8, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.Referential.UserObject.GetSnapshot evt, string privateTopic = null)
        {
            SendEvent(StdEnum.Transaction, evt != null ? evt : new XComponent.Referential.UserObject.GetSnapshot(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.Referential.UserObject.GetSnapshot evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Referential.UserObject.GetSnapshot(), IncomingEventType.Transition, HeaderFactory.Create(8, (int)stateMachineEnum, 183271270, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		public void Send(Context context, XComponent.Referential.UserObject.InstrumentSnapshot evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Referential.UserObject.InstrumentSnapshot(), IncomingEventType.Transition, HeaderFactory.Create(context, 10, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.Referential.UserObject.InstrumentSnapshot evt, string privateTopic = null)
        {
            SendEvent(StdEnum.Transaction, evt != null ? evt : new XComponent.Referential.UserObject.InstrumentSnapshot(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.Referential.UserObject.InstrumentSnapshot evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Referential.UserObject.InstrumentSnapshot(), IncomingEventType.Transition, HeaderFactory.Create(10, (int)stateMachineEnum, 183271270, privateTopic));
			PostOnStateMachine(incomingEvent, stateMachineEnum);
        }

		public void Send(Context context, XComponent.Referential.UserObject.Instrument evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Referential.UserObject.Instrument(), IncomingEventType.Transition, HeaderFactory.Create(context, 9, privateTopic));
            Agent.Post(_engineAgentsById[context.AgentId], incomingEvent);
        }
        
		public void SendEvent(XComponent.Referential.UserObject.Instrument evt, string privateTopic = null)
        {
            SendEvent(StdEnum.Transaction, evt != null ? evt : new XComponent.Referential.UserObject.Instrument(), privateTopic);
		}

		public void SendEvent(StdEnum stateMachineEnum, XComponent.Referential.UserObject.Instrument evt, string privateTopic = null)
        {
            var incomingEvent = new IncomingEvent(evt != null ? evt : new XComponent.Referential.UserObject.Instrument(), IncomingEventType.Transition, HeaderFactory.Create(9, (int)stateMachineEnum, 183271270, privateTopic));
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
				case StdEnum.XCTradeProcessor :
					return _engineAgentsByStateMachine[-1802001970];
				case StdEnum.Transaction :
					return _engineAgentsByStateMachine[-1025633653];
				case StdEnum.UpdateReferential :
					return _engineAgentsByStateMachine[-253835822];
				case StdEnum.GetInstrumentSnapshot :
					return _engineAgentsByStateMachine[1101023624];
			}

            return new List<EngineAgent>();
        }
    }
}
