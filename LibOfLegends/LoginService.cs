using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluorineFx;
using FluorineFx.Messaging.Messages;
using FluorineFx.Net;

using com.riotgames.platform.game;
using com.riotgames.platform.statistics;

namespace LibOfLegends
{
    public class LoginService
    {
        public const string serviceName = "loginService";
        RPCService RPC;

        public LoginService(RPCService rpc)
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

        void GetStoreUrlInternal(Responder<string> responder, object[] arguments)
        {
            object[] blankArr = new object[0];
            Call(serviceName, "getStoreUrl", responder, blankArr);
        }

        #endregion

        #region Blocking RPC

        public string getStoreURL()
        {
            return (new InternalCallContext<string>(GetStoreUrlInternal, new object[] { })).Execute();
        }

        #endregion
    }
}
