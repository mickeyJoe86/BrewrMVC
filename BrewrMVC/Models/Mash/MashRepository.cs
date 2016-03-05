using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrewrMVC.Models
{
    public class MashRepository
    {
        public List<Mash> GetAll()
        {
            using (var context = new MashContext())
            {
                var mashes = context.Mashes.ToList();
                return mashes;
            }
        }
    }
}