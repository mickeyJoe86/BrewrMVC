using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrewrMVC.Models
{
    public class BrewDetailsRepository
    {
        public Mash GetAll(int id)
        {
            using (var context = new BrewDetailsContext())
            {
                var mash = context.Mashes
                    .Where(x => x.BrewId == id)
                    .SingleOrDefault();
                return mash;
            }
        }
       
    }
}