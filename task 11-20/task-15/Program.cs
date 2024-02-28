using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                Name = "Kirsi Kernel",
                Profession = "Teacher",
                Salary = 1200
            };
            Boss boss = new Boss() 
            {
                Name = "Hanna Husso",
                Profession = "Head of Institute",
                Salary = 2200,
                Car = "Audi",
                Bonus = 5000
            };
            Console.WriteLine(emp1.EmpData());
            Console.WriteLine(boss.BossData());

            emp1.Profession = "Principal";
            emp1.Salary = 2200;
            Console.WriteLine(emp1.EmpData());
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; } 

        public string EmpData()
        {
            return $"Employee: \n-Name: {Name} Profession: {Profession} Salary: {Salary}";
        }
    }
    public class Boss : Employee
    {
        public string Car;
        public int Bonus;

        public string BossData()
        {
            return $"Boss: \n-Name: {Name} Profession: {Profession} Salary: {Salary} Car: {Car} Bonus: {Bonus}";
        }
    }
}
