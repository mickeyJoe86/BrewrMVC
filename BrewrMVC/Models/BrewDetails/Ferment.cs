using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrewrMVC.Models
{
    public class Ferment
    {
        public int Id { get; set; }
        public int BrewId { get; set; }
        public decimal InitialGravity { get; set; }
        public decimal OriginalGravity { get; set; }
        public decimal FinalGravity { get; set; }
    }
}