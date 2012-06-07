using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.riotgames.platform.game
{
    public class GameState
    {
        public long Id { get; set; }
        //public string RoomName { get; set; }

        public string QueueTypeName { get; set; }
        public int PickTurn { get; set; }

        public long OptimisticLock;
        public string TerminatedCondition;
        public DateTime? CreationTime;
        public string GameType;
        public int QueuePosition;
        //public List<GameObserver> Observers;
        public int GameTypeConfigId;
        //public List<com.riotgames.platform.game.PlayerChampionSelectionDTO> PlayerChampionSelections;
        //public PlayerParticipant Owner;
        public string Name;
        //public GameMapId GameMap;
        //public SpectatorOrigin AllowedSpectatorOrigin;
        //public GameMode GameMode;
        public string GameStateString;
        //public List<BannedChampion> BannedChampions;
        //public List<PlayerParticipant> TeamOne;
        //public List<PlayerParticipant> TeamTwo;

        //public string GameState;
        public double ExpiryTime;
        public List<int> BanOrder;

        public bool PasswordSet;
        public int MaxPlayers;
        public int SpectatorDelay;

    }
}
