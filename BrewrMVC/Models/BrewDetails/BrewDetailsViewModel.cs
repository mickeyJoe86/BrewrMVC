using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrewrMVC.Models
{
    public class BrewDetailsViewModel
    {
        public BrewDetailsViewModel()
        {
            this.BrewsObject = new Brew();
            this.MashesObject = new Mash();
            this.FermentsObject = new Ferment();
        }

        [Key]
        public int Id { get; set; }
        public Brew BrewsObject { get; set; }
        public Mash MashesObject { get; set; }
        public Ferment FermentsObject { get; set; }

    }
}