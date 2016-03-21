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

        public FermentDetailsViewModel StartFerments(int id)
        {
            using (var context = new BrewDetailsContext())
            {
                FermentDetailsViewModel fermentDetails = new FermentDetailsViewModel();

                fermentDetails.BrewObject = context.Brews
                    .Where(x => x.ID == id)
                    .SingleOrDefault();
                fermentDetails.FermentsObject = context.Ferments
                    .Where(x => x.BrewId == id)
                    .SingleOrDefault();

                return fermentDetails;
            }
        }

        public void AddNewFerments(FermentDetailsViewModel ferments)
        {
            using (var context = new BrewDetailsContext())
            {
                var newFerments = ferments.FermentsObject;
                newFerments.BrewId = ferments.BrewObject.ID;
                context.Ferments.Add(newFerments);
                context.SaveChanges();
            }
        }

        public void SaveFerments(FermentDetailsViewModel ferments)
        {
            using (var context = new BrewDetailsContext())
            {
                var editFerment = ferments.FermentsObject;
                editFerment.BrewId = ferments.Id;
                context.Entry(editFerment).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}