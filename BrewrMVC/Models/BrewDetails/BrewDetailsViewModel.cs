using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrewrMVC.Models
{
    public class BrewDetailsViewModel
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public int Id { get; set; }
        public int BrewId { get; set; }
        public int MashTime { get; set; }        
        public decimal MashWeight { get; set; }
        public int TargetTemp { get; set; }
        public int Reading1 { get; set; }
        public int Reading2 { get; set; }
        public int Reading3 { get; set; }
        public int Reading4 { get; set; }
        public int Reading5 { get; set; }
        public int Reading6 { get; set; }
        public int FinalReading { get; set; }

        public decimal InitialGravity { get; set; }
        public decimal OriginalGravity { get; set; }
        public decimal FinalGravity { get; set; }        

    }
}