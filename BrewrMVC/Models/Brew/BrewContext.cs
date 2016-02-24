using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BrewrMVC.Models
{
    public class BrewContext : DbContext
    {
        public BrewContext() 
            : base ("Brewr")
        {
        }

        public DbSet<Brew> Brews { get; set; }
    }
}