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
                var query = (from b in context.Brews
                             join f in context.Ferments on b.ID equals f.BrewId
                             join m in context.Mashes on f.BrewId equals m.BrewId
                             where f.BrewId == id
                             select new
                             {
                                 Name = b.Name,
                                 Type = b.Type,
                                 MashTime = m.MashTime,
                                 MashWeight = m.MashWeight,
                                 TargetTemp = m.TargetTemp,
                                 Reading1 = m.Reading1,
                                 Reading2 = m.Reading2,
                                 Reading3 = m.Reading3,
                                 Reading4 = m.Reading4,
                                 Reading5 = m.Reading5,
                                 Reading6 = m.Reading6,
                                 FinalReading = m.FinalReading,
                                 InitialGravity = f.InitialGravity,
                                 OriginalGravity = f.OriginalGravity,
                                 FinalGravity = f.FinalGravity
                             }).SingleOrDefault();

                var brew = new BrewDetailsViewModel
                {
                    Name = query.Name,
                    Type = query.Type,
                    MashTime = query.MashTime,
                    MashWeight = query.MashWeight,
                    TargetTemp = query.TargetTemp,
                    Reading1 = query.Reading1,
                    Reading2 = query.Reading2,
                    Reading3 = query.Reading3,
                    Reading4 = query.Reading4,
                    Reading5 = query.Reading5,
                    Reading6 = query.Reading6,
                    FinalReading = query.FinalReading,
                    InitialGravity = query.InitialGravity,
                    OriginalGravity = query.OriginalGravity,
                    FinalGravity = query.FinalGravity
                };

                return brew;
            }        
        }
    }
}