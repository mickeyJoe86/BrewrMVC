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
    }
}