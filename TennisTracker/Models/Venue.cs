using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TennisTracker.Models
{
    public class Venue
    {
        public int VenueId { get; set; }
        public string Name { get; set; }
        public string CourtType { get; set; }
    }
}