using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluorineFx;
using FluorineFx.Messaging.Messages;
using FluorineFx.Net;

using com.riotgames.platform.game;
using com.riotgames.platform.matchmaking;

namespace LibOfLegends
{
    public class MatchmakerService
    {
        public const string serviceName = "matchmakerService";

        RPCService RPC;
        public List<GameQueueConfig> availableQueues;

        public MatchmakerService(RPCService rpc)
        {
            RPC = rpc;
        }

        #region Internal RPC

        void Call<ResponderType>(string destination, string operation, Responder<ResponderType> responder, params object[] arguments)
        {
            if (RPC.RPCNetConnection == null)
                throw new RPCNotConnectedException("Connection has not been initialised yet");
            RPC.RPCNetConnection.Call(RPCService.EndpointString, destination, null, operation, responder, arguments);
        }

        private void GetAvailableQueuesInternal(Responder<GameQueueConfig> responder, object[] arguments)
        {
            object[] blankArr = new object[0];
            Call(serviceName, "getAvailableQueues", responder, blankArr);
        }

        private void AttachToQueueInternal(Responder<SearchingForMatchNotification> responder, object[] arguments)
        {
            Call(serviceName, "attachToQueue", responder, arguments);
        }

        private void CancelFromQueueIfPossibleInternal(Responder<bool> responder, object[] arguments)
        {
            Call(serviceName, "cancelFromQueueIfPossible", responder, arguments);
        }

        #endregion

        #region Blocking RPC

        public GameQueueConfig getAvailableQueues()
        {
            return (new InternalCallContext<GameQueueConfig>(GetAvailableQueuesInternal, new object[] { })).Execute();
        }

        public SearchingForMatchNotification attachToQueue(MatchMakerParams matchParams)
        {
            return (new InternalCallContext<SearchingForMatchNotification>(AttachToQueueInternal, new object[] { matchParams })).Execute();
        }

        public bool cancelFromQueueIfPossible(int queueId)
        {
            return (new InternalCallContext<bool>(CancelFromQueueIfPossibleInternal, new object[] { queueId })).Execute();
        }

        #endregion
    }
}
