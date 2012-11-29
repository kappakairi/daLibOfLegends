using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluorineFx;
using FluorineFx.Messaging.Messages;
using FluorineFx.Net;

using com.riotgames.platform.clientfacade.domain;

namespace LibOfLegends
{
    public class ClientFacadeService
    {
        public const string serviceName = "clientFacadeService";

        private RPCService RPC;
        public LoginDataPacket loginDataPacket;

        public ClientFacadeService(RPCService rpc)
        {
            RPC = rpc;
            loginDataPacket = null;
        }

        #region Internal RPC

        private void Call<ResponderType>(string destination, string operation, Responder<ResponderType> responder, params object[] arguments)
        {
            if (RPC.RPCNetConnection == null)
                throw new RPCNotConnectedException("Connection has not been initialised yet");
            RPC.RPCNetConnection.Call(RPCService.EndpointString, destination, null, operation, responder, arguments);
        }

        void GetLoginDataPacketForUserInternal(Responder<LoginDataPacket> responder, object[] arguments)
        {
            Call(serviceName, "getLoginDataPacketForUser", responder, arguments);
        }

        #endregion

        #region Blocking RPC

        private LoginDataPacket getLoginDataPacket()
        {
            return (new InternalCallContext<LoginDataPacket>(GetLoginDataPacketForUserInternal, new object[] { }).Execute());
        }

        #endregion
    }
}
