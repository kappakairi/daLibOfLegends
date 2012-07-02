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
    public class GameService
    {
        public const string serviceName = "gameService";
        RPCService RPC;

        public GameService(RPCService rpc)
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

        void JoinGame(Responder<GameDTO> responder, object[] arguments)
        {
            Call(serviceName, "joinGame", responder, arguments);
        }

        void GetGameStateInternal(Responder<GameDTO> responder, object[] arguments)
        {
            Call(serviceName, "getLatestGameTimerState", responder, arguments);
        }

        void GetCustomGameInternal(Responder<GameDTO> responder, object[] arguments)
        {
            Call(serviceName, "getGame", responder, arguments);
        }

        void RetrieveInProgressSpectatorGameInfoInternal(Responder<PlatformGameLifecycleDTO> responder, object[] arguments)
        {
            Call(serviceName, "retrieveInProgressSpectatorGameInfo", responder, arguments);
        }

        /** Creates a custom practice game based on the 
         * PracticeGameConfig class passed to it
         */
        void CreatePracticeGame(Responder<GameDTO> responder, object[] arguments)
        {
            Call(serviceName, "createPracticeGame", responder, arguments);
        }

        /** Switches the player to observer
         * if not allowed, will return false
         */
        void SwicthPlayerToObserver(Responder<bool> responder, object[] arguments)
        {
            Call(serviceName, "switchPlayerToObserver", responder, arguments);
        }

        /** Switches the observer to player
         * if not allowed, will return false
         */
        void SwicthObserverToPlayer(Responder<bool> responder, object[] arguments)
        {
            Call(serviceName, "switchObserverToPlayer", responder, arguments);
        }

        /** Quit the current game Lobby that
         * the summoner is in
         */
        void QuitGame(Responder<string> responder, object[] arguments)
        {
            Call(serviceName, "quitGame", responder, arguments);
        }

        /** Tells the client that GameMessage was received
         * Possible Values (int GameId, string Message)
         * Messages: GameClientConnectedToServer
         */
        void SetClientReceivedGameMessageInternal(Responder<string> responder, object[] arguments)
        {
            Call(serviceName, "setClientReceivedGameMessage", responder, arguments);
        }

        /** Tells the client that MaestroMessage was received
         * Possible Values (int GameId, string Message)
         * Messages: GameReconnect | GameClientConnectedToServer
         */
        void SetClientReceivedMaestroMessageInternal(Responder<string> responder, object[] arguments)
        {
            Call(serviceName, "setClientReceivedMaestroMessage", responder, arguments);
        }

        /** TODO TODO T 
         * When Game stats will receive message with com.riotgames.platform.game.PlayerCredentailsDTO
         * that helps client able connect to game server 
         * Need to setup a responder, but no caller
         */
        void receivePlayerCredentialsInternal(Responder<PlayerCredentialsDTO> responder, object[] arguments)
        {
            Call(serviceName, "NOCALL", responder, arguments);
        }

        #endregion

        #region Blocking RPC

        public GameDTO joinGame(long gameID, string pass)
        {
            return (new InternalCallContext<GameDTO>(JoinGame, new object[] { gameID, pass })).Execute();
        }

        public GameDTO getGameState(double gameID, string gameState, int rand)
        {
            return (new InternalCallContext<GameDTO>(GetGameStateInternal, new object[] { gameID, gameState, rand })).Execute();
        }

        public GameDTO getCustomGame(long gameID)
        {
            return (new InternalCallContext<GameDTO>(GetCustomGameInternal, new object[] { gameID })).Execute();
        }

        public PlatformGameLifecycleDTO retrieveInProgressSpectatorGameInfo(string summonerName)
        {
            return (new InternalCallContext<PlatformGameLifecycleDTO>(RetrieveInProgressSpectatorGameInfoInternal, new object[] { summonerName })).Execute();
        }

        public GameDTO createPracticeGame(PracticeGameConfig gameCfg)
        {
            return (new InternalCallContext<GameDTO>(CreatePracticeGame, new object[] { gameCfg })).Execute();
        }

        public bool switchPlayerToObserver(long gameID)
        {
            return (new InternalCallContext<bool>(SwicthPlayerToObserver, new object[] { gameID })).Execute();
        }

        public bool switchObserverToPlayer(long gameID, int teamID)
        {
            return (new InternalCallContext<bool>(SwicthObserverToPlayer, new object[] { gameID, teamID })).Execute();
        }

        public bool quitGame()
        {
            new InternalCallContext<string>(QuitGame, new object[] { }).Execute();

            return true;
        }

        #endregion
    }
}
