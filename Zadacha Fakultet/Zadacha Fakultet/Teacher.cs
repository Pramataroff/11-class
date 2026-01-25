using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_Fakultet
{
    public class Teacher : Fakultet
    {
        private double salary;
        private List<string> groups = new List<string>();

        public Teacher(double salary, List<string> groups, string instName, string city, string fakultet, string vocation) : base(instName, city, fakultet, vocation)
        {
            this.Salary = salary;
            Groups = groups;
        }

        public double Salary { get => salary; set { if (value >= 2 && value <= 6) salary = value; } }

        public List<string> Groups { get => groups; set => groups = value; }

        public override void Info()
        {
            Console.WriteLine($"teacher salary: {this.Salary}");
            int count = 1;
            foreach (var item in Groups)
            {
                Console.WriteLine($"Group [{count}]: {item} ");
                count++;
            }

        }
    }
}
