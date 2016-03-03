using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace BrewrMVC.Models
{
    public class BrewRepository
    {       
        public List<Brew> GetAll()
        {
            using (var context = new BrewContext())
            {
                string userid = HttpContext.Current.User.Identity.GetUserId();
                var brews = context.Brews.Where(x => x.UserId == userid).ToList();
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

        public Brew FindById(int id)
        {
            using (var context = new BrewContext())
            {
                var brew = context.Brews.Find(id);
                return brew;
            }
        }

        public void EditBrew(Brew brew)
        {
            using (var context = new BrewContext())
            {                
                context.Entry(brew).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteBrew(int id)
        {
            using (var context = new BrewContext())
            {
                var brew = context.Brews.Find(id);
                context.Brews.Remove(brew);
                context.SaveChanges();
            }
        }
    }
}