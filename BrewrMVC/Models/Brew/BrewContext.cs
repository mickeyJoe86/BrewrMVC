using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BrewrMVC.Models
{
    public interface IBrewContext
    {
        IDbSet<Brew> Brews { get; set; }
    }

    public class BrewContext : DbContext, IBrewContext
    {
        public BrewContext() 
            : base ("Brewr")
        {
        }

        public IDbSet<Brew> Brews { get; set; }
    }

    public class FakeDbContext: DbContext, IBrewContext, IBrewRepository
    {
        public IDbSet<Brew> Brews { get; set; }

        public void AddNewBrew(Brew brew)
        {
            throw new NotImplementedException();
        }

        public void DeleteBrew(int id)
        {
            throw new NotImplementedException();
        }

        public void EditBrew(Brew brew)
        {
            throw new NotImplementedException();
        }

        public Brew FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Brew> GetAll()
        {
            throw new NotImplementedException();
        }
    }

}