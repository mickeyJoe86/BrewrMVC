using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BrewrMVC.Models
{
    public class BrewDetailsContext : DbContext
    {
        public BrewDetailsContext()
            : base("Brewr")
        {
            Database.SetInitializer<BrewDetailsContext>(null);
        }

        public DbSet<Mash> Mashes { get; set; }
        public DbSet<Ferment> Ferments { get; set;  }
        public DbSet<Brew> Brews { get; set; }

        public System.Data.Entity.DbSet<BrewrMVC.Models.BrewDetailsViewModel> BrewDetailsViewModels { get; set; }
    }
}