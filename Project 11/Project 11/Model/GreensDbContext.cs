using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Project_11
{
    public class GreensDbContext : DbContext
    {
        public GreensDbContext() : base("name=Greens")
        {
        }

        public DbSet<Vegetable> Vegetables { get; set; }
        public DbSet<VegetableType> VegetableTypes { get; set; }
    }
}
