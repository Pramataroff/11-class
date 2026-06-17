using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_11
{
    public class VegetableLogic
    {
        private GreensDbContext context = new GreensDbContext(); 

        public Vegetable Get(int id)
        {
            Vegetable findedVegetable = context.Vegetables.Find(id);
            if (findedVegetable != null)
            {
                context.Entry(findedVegetable).Reference(x => x.VegetableType).Load();
            }
            return findedVegetable;
        }

        public List<Vegetable> GetAll()
        {
            return context.Vegetables.Include("VegetableType").ToList();
        }

        public void Create(Vegetable vegetable)
        {
            context.Vegetables.Add(vegetable);
            context.SaveChanges();
        }

        public void Update(int id, Vegetable vegetable)
        {
            Vegetable findedVegetable = context.Vegetables.Find(id);
            if (findedVegetable == null)
            {
                return;
            }

            findedVegetable.Name = vegetable.Name;
            findedVegetable.Description = vegetable.Description;
            findedVegetable.Price = vegetable.Price;
            findedVegetable.VegetableTypeId = vegetable.VegetableTypeId;

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Vegetable findedVegetable = context.Vegetables.Find(id);
            if (findedVegetable != null)
            {
                context.Vegetables.Remove(findedVegetable);
                context.SaveChanges();
            }
        }
    }
}
