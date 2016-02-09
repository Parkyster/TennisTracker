using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TennisTracker.Models
{
    public class PlayerRecord
    {
        public virtual Player Player { get; set; }
        public int Id { get; set; }          
    }
}