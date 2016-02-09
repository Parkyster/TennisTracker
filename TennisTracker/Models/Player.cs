using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TennisTracker.Models
{
    public class Player
    {
        
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Plays { get; set; }
        public string FavouriteSurface { get; set; }
        //public List<SinglesMatch> SinglesMatches { get; set; }  

    }
}