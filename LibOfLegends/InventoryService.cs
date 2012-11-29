using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluorineFx;
using FluorineFx.Messaging.Messages;
using FluorineFx.Net;

using com.riotgames.platform.summoner.boost;
using com.riotgames.platform.catlog.champion;

namespace LibOfLegends
{
    public class InventoryService
    {
        public const string serviceName = "inventoryService";

        RPCService RPC;
        public SummonerActiveBoostsDTO activeBoosts;
        public List<ChampionDTO> availableChampions;

        public InventoryService(RPCService rpc)
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

        #endregion

        #region Blocking RPC

        #endregion
    }
}
