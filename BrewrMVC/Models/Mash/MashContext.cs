using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BrewrMVC.Models
{
    public class MashContext : DbContext
    {
        public MashContext()
            : base("Brewr")
        {
            Database.SetInitializer<MashContext>(null);
        }

        public DbSet<Mash> Mashes { get; set; }
    }
}