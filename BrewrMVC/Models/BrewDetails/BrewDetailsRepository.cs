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

        public BrewDetailsViewModel GetFullInfo(int id)
        {
            using (var context = new BrewDetailsContext())
            {
                BrewDetailsViewModel brewDetails = new BrewDetailsViewModel();

                brewDetails.BrewsObject = context.Brews
                        .Where(x => x.ID == id)
                        .SingleOrDefault();
                brewDetails.MashesObject = context.Mashes
                        .Where(x => x.BrewId == id)
                        .SingleOrDefault();
                brewDetails.FermentsObject = context.Ferments
                        .Where(x => x.BrewId == id)
                            .SingleOrDefault();

                return brewDetails;
            }        
        }  
    }
}