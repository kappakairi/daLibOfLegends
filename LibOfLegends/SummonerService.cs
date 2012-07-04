using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluorineFx;
using FluorineFx.Messaging.Messages;
using FluorineFx.Net;

using com.riotgames.platform.summoner;
using com.riotgames.platform.statistics;
using com.riotgames.platform.gameclient.domain;

namespace LibOfLegends
{
    public class SummonerService
    {
        public const string serviceName = "summonerService";
        RPCService RPC;

        public SummonerService(RPCService rpc)
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

        private void GetSummonerByNameInternal(Responder<PublicSummoner> responder, object[] arguments)
        {
            Call(serviceName, "getSummonerByName", responder, arguments);
        }

        private void GetAllPublicSummonerDataByAccountInternal(Responder<AllPublicSummonerDataDTO> responder, object[] arguments)
        {
            Call(serviceName, "getAllPublicSummonerDataByAccount", responder, arguments);
        }

        private void GetAllSummonerDataByAccountInternal(Responder<AllSummonerData> responder, object[] arguments)
        {
            Call(serviceName, "getAllSummonerDataByAccount", responder, arguments);
        }

        private void GetSummonerNamesInternal(Responder<List<string>> responder, object[] arguments)
        {
            Call(serviceName, "getSummonerNames", responder, arguments);
        }

        #endregion

        #region Blocking RPC

        public PublicSummoner GetSummonerByName(string name)
        {
            return (new InternalCallContext<PublicSummoner>(GetSummonerByNameInternal, new object[] { name })).Execute();
        }

        public AllPublicSummonerDataDTO GetAllPublicSummonerDataByAccount(long accountID)
        {
            return (new InternalCallContext<AllPublicSummonerDataDTO>(GetAllPublicSummonerDataByAccountInternal, new object[] { accountID })).Execute();
        }

        // z
        //I don't understand how this one works anymore, always returns null for me
        public AllSummonerData GetAllSummonerDataByAccount(long accountID)
        {
            return (new InternalCallContext<AllSummonerData>(GetAllSummonerDataByAccountInternal, new object[] { accountID })).Execute();
        }

        public List<string> GetSummonerNames(List<long> summonerIDs)
        {
            return (new InternalCallContext<List<string>>(GetSummonerNamesInternal, new object[] { summonerIDs })).Execute();
        }

        #endregion
    }
}
