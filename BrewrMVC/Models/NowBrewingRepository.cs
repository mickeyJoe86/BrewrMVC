using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrewrMVC.Models
{
    public class NowBrewingRepository
    {
        public MashDetailsViewModel StartMashes(int id)
        {
            using (var context = new BrewDetailsContext())
            {
                MashDetailsViewModel mashDetails = new MashDetailsViewModel();

                mashDetails.BrewsObject = context.Brews
                        .Where(x => x.ID == id)
                        .SingleOrDefault();
                mashDetails.MashesObject = context.Mashes
                        .Where(x => x.BrewId == id)
                        .SingleOrDefault();

                return mashDetails;
            }
        }

        public void AddNewMash(MashDetailsViewModel mashDetail)
        {
            using (var context = new BrewDetailsContext())
            {
                var newMash = mashDetail.MashesObject;
                newMash.BrewId = mashDetail.BrewsObject.ID;              
                context.Mashes.Add(newMash);
                context.SaveChanges();
            }
        }

        public void SaveMash(MashDetailsViewModel mashDetail)
        {
            using (var context = new BrewDetailsContext())
            {
                var editMash = mashDetail.MashesObject;
                editMash.BrewId = mashDetail.Id;
                context.Entry(editMash).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }


    }
}