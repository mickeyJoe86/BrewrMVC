using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrewrMVC.Models
{
    public class NowBrewingRepository
    {
        public void StartMash(Mash mash, int id)
        {
            using (var context = new BrewDetailsContext())
            {
                var newMash = mash;
                mash.BrewId = id;
                context.Mashes.Add(mash);
                context.SaveChanges();
            }
        }
        
    }
}