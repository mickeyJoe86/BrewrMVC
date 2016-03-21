using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrewrMVC.Models
{
    public class FermentDetailsViewModel
    {
        public FermentDetailsViewModel()
        {
            this.BrewObject = new Brew();
            this.FermentsObject = new Ferment();
        }

        [Key]
        public int Id { get; set; }
        public Brew BrewObject { get; set; }
        public Ferment FermentsObject { get; set; }
    }
}