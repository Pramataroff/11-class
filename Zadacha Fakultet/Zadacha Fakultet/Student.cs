using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_Fakultet
{
    public class Student : Fakultet
    {
        private string facultetNumber;
        private string group;
        private double grade;
        public string FacultetNumber
        {
            get { return facultetNumber; }
            set { if (value != null) { facultetNumber = value; } }
        }

        public string Group
        {
            get { return group; }
            set { if (value != null) { group = value; } }
        }

        public double Grade
        {
            get { return grade; }
            set { if(value >= 2 && value <= 6) grade = value; }
        }

        public Student(string facultetNumber, string group, double grade, string instName,string city,string fakultet, string vocation) : base(instName,city,fakultet,vocation)
        {
            this.FacultetNumber = facultetNumber;
            this.Group = group;
            Grade = grade;
        }

        public override void Info()
        {
            Console.WriteLine($"Fakultet number: {this.FacultetNumber}");
            Console.WriteLine($"Group: {this.Group}");
            Console.WriteLine($"Grade: {this.Grade}");
        }

    }
}
