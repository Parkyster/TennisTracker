using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TennisTracker.Models
{
    public class DoublesMatch
    {
        public int DoublesMatchId { get; set; }
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public int Player3Id { get; set; }
        public int Player4Id { get; set; }
        public KeyValuePair<int,int> Winners { get; set; }
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public string Score { get; set; }
    }
}