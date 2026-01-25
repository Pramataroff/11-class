using System.Net.Http.Headers;

namespace Zadacha_Fakultet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //a)

                Console.Write("Enter how many students: ");
                int n = int.Parse(Console.ReadLine());
                List<Student> students = new List<Student>();
                for (int i = 0; i < n; i++)
                {

                    Console.Write("Enter fakultet number: ");
                    string fakultetNumber = Console.ReadLine();
                    Console.Write("Enter group: ");
                    string group = Console.ReadLine();
                    Console.Write("Enter grade: ");
                    double grade = double.Parse(Console.ReadLine());
                    Console.Write("Enter institution name: ");
                    string instNmae = Console.ReadLine();
                    Console.Write("Enter city: ");
                    string city = Console.ReadLine();
                    Console.Write("Enter fakultet");
                    string fakultet = Console.ReadLine();
                    Console.Write("Enter vocation: ");
                    string vocation = Console.ReadLine();
                    students.Add(new Student(fakultetNumber, group, grade, instNmae, city, fakultet, vocation));
                }

                Console.Write("Enter how many teachers: ");
                n = int.Parse(Console.ReadLine());
                List<Teacher> teachers = new List<Teacher>();
                for (int i = 0; i < n; i++)
                {

                    Console.Write("Enter institution name: ");
                    string instNmae = Console.ReadLine();
                    Console.Write("Enter city: ");
                    string city = Console.ReadLine();
                    Console.Write("Enter fakultet");
                    string fakultet = Console.ReadLine();
                    Console.Write("Enter vocation: ");
                    string vocation = Console.ReadLine();
                    Console.Write("Enter salary: ");
                    double salary = double.Parse(Console.ReadLine());
                    Console.Write("Enter groups: ");
                    List<string> groups = new List<string>();
                    teachers.Add(new Teacher(salary, groups, instNmae, city, fakultet, vocation));

                }



                //b) izvejda informaciq za n broi studenti
                Console.Write("Enter for how many students you want to take information: ");
                students.Take(int.Parse(Console.ReadLine())).ToList().ForEach(student => student.Info());
                Console.WriteLine(new string('-', 50));

                //c) izvejda danni za studenti po specialnost
                Console.Write("Enter specific vocation: ");
                string vocationFilter = Console.ReadLine();
                students.Where(x => x.Vocation == vocationFilter).ToList().ForEach(student => student.Info());
                Console.WriteLine(new string('-', 50));

                //d) sreden uspeh
                double AverageGrade = students.Average(x => x.Grade);
                Console.Write($"Average grade: {AverageGrade}");
                Console.WriteLine();
                Console.WriteLine(new string('-', 50));

                //e) izvejda danni za studenti s nai visok uspeh
                Console.WriteLine();
                Console.Write("Students with the highest grade: ");
                students.OrderByDescending(x => x.Grade).ToList().Where(x => x.Grade >= 5.50).ToList().ForEach(student => student.Info());
                

                //f) sortira studentite po specialnost
                students = students.OrderBy(x => x.Vocation).ToList();

                //g) da se validirat dannite(validirani sa v classa) i realiziraite hvashtane na greshki


                //bonus
                double teachersSalary = teachers.Average(x => x.Salary);
                Console.WriteLine($"Teachers average salary: {teachersSalary}");
                Console.WriteLine(new string('-',50));
                   
            }
            catch (Exception)
            {
                Console.WriteLine("You meesed up something!!!");
            }

        }
    }
}
