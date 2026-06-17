using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_11
{
    public class VegetableTypeLogic
    {
        private GreensDbContext context = new GreensDbContext();

        
        public List<VegetableType> GetAllVegetableTypes()
        {
            return context.VegetableTypes.ToList();
        }

       
        public string GetVegetableTypeById(int id)
        {
            return context.VegetableTypes.Find(id).Name;
        }
    }
}
