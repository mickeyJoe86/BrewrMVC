using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrewrMVC.Models
{
    public interface IBrewRepository
    {
        List<Brew> GetAll();
        void AddNewBrew(Brew brew);
        Brew FindById(int id);
        void EditBrew(Brew brew);
        void DeleteBrew(int id);
    }
}
