using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrewrMVC.Models
{
    public class MashDetailsViewModel
    {
        public MashDetailsViewModel()
        {
            this.BrewsObject = new Brew();
            this.MashesObject = new Mash();
        }

        [Key]
        public int Id { get; set; }
        public Brew BrewsObject { get; set; }
        public Mash MashesObject { get; set; }
    }
}