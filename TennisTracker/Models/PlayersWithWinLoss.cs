using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TennisTracker.Models
{
    public class PlayersWithWinLoss
    {
        public PlayersWithWinLoss(IEnumerable<Player> players, List<Dictionary<int,string>> winLoss)
        {
            Players = players;
            WinLoss = winLoss;
        }
        public IEnumerable<Player> Players { get; set; }
        public List<Dictionary<int,string>> WinLoss { get; set; } 
    }
}