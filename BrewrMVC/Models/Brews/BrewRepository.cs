using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrewrMVC.Models
{
    public class BrewRepository
    {       
        public List<Brew> GetAll()
        {
            using (var context = new BrewContext())
            {
                var brews = context.Brews.ToList();
                return brews;
            }
        }

        public void AddNewBrew(Brew brew)
        {
            using (var context = new BrewContext())
            {
                context.Brews.Add(brew);
                context.SaveChanges();
            }
        }
    }
}