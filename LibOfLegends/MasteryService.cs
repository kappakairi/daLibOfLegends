using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluorineFx;
using FluorineFx.Messaging.Messages;
using FluorineFx.Net;

using com.riotgames.platform.summoner.masterybook;
using com.riotgames.platform.gameclient.domain;

namespace LibOfLegends
{
    public class MasteryService
    {
        public const string serviceName = "masteryBookService";
        RPCService RPC;

        public MasteryService(RPCService rpc)
        {
            RPC = rpc;
        }

        #region Internal RPC

        private void Call<ResponderType>(string destination, string operation, Responder<ResponderType> responder, params object[] arguments)
        {
            if (RPC.RPCNetConnection == null)
                throw new RPCNotConnectedException("Connection has not been initialised yet");
            RPC.RPCNetConnection.Call(RPCService.EndpointString, destination, null, operation, responder, arguments);
        }

        private void GetMasteryBookInternal(Responder<MasteryBook> responder, object[] arguments)
        {
            Call(serviceName, "getMasteryBook", responder, arguments);
        }

        #endregion

        #region Blocking RPC

        public MasteryBook GetMasteryBook(long summonerID)
        {
            return (new InternalCallContext<MasteryBook>(GetMasteryBookInternal, new object[] { summonerID })).Execute();
        }

        #endregion
    }
}
