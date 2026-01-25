using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_Fakultet
{
    abstract public class Fakultet
    {
        private string institutionName;
        private string city;
        private string fakultet_;
        private string vocation;

        public string InstitutionName
        {
            get { return institutionName; }
            set { if (value != null) { institutionName = value; } }
        }

        public string City
        {
            get { return city; }
            set { if (value != null) { city = value; } }
        }

        public string _Fakultet
        {
            get { return fakultet_; }
            set { if (value != null) { fakultet_ = value; } }
        }

        public string Vocation
        {
            get { return vocation; }
            set { if (value != null) { vocation = value; } }
        }
        public Fakultet(string institutionName, string city, string fakultet, string vocation)
        {
            this.InstitutionName = institutionName;
            this.City = city;
            this._Fakultet = fakultet;
            this.Vocation = vocation;
        }
        virtual public void Info()
        {
            Console.WriteLine();
            Console.WriteLine(new string('-',50));
            Console.WriteLine($"Institution name: {this.InstitutionName}");
            Console.WriteLine($"City: {this.City}");
            Console.WriteLine($"Fakultet: {this._Fakultet}");
            Console.WriteLine($"Vocation: {this.Vocation}");
        }
    }
}
