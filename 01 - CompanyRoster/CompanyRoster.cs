using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoster
{
    \\test1
    class Person
    {
        public string name;
        public double salary;
        public string position;
        public string department;
        public string email;
        public int age;

        public Person(string name, double salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = "n/a";
            this.age = -1;
        }
    }
    class Program
    {
        // test
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var data = new List<Person>();
            for (int i = 0; i < input; i++)
            {
                var peopleInfo = Console.ReadLine().Split();

                var person = new Person(peopleInfo[0],
                   double.Parse(peopleInfo[1]),
                   peopleInfo[2],
                   peopleInfo[3]);

                if (peopleInfo.Length > 4)
                {
                    var emailOrAge = peopleInfo[4];
                    if (emailOrAge.Contains('@'))
                    {
                        person.email = emailOrAge;
                    }
                    else
                    {
                        person.age = int.Parse(emailOrAge);
                    }
                }

                if (peopleInfo.Length > 5)
                {
                    person.age = int.Parse(peopleInfo[5]);
                }
                data.Add(person);
            }


            var result = data
                .GroupBy(e => e.department)
                .Select(e => new
                {
                    Departament = e.Key,
                    AverageSalary = e.Average(emp => emp.salary),
                    Employees = e.OrderByDescending(emp => emp.salary)

                })
                .FirstOrDefault();


            Console.WriteLine("Highest Average Salary: {0}", result.Departament);
            foreach (var item in result.Employees)
            {
                Console.WriteLine($"{item.name} {item.salary:f2} {item.email} {item.age}");
            }

        }
    }
}
