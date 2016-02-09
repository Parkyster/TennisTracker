using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TennisTracker.Models
{
    public class SinglesMatch
    {
        public int SinglesMatchId { get; set; }
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public int PlayerIdWinner { get; set; }
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public string Score { get; set; }
        public virtual List<Player> Players { get; set; } 
    }
}