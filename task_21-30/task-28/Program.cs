using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace task_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list of items in the refrigerator
            List<string> R = new List<string>();

            //adding the foods in the refrigerator
            R.Add("Apple");
            R.Add("Braed");
            R.Add("Bread");
            R.Add("Butter");
            R.Add("Cucumber");
            R.Add("Salad");
            R.Add("Milk");
            R.Add("Ketchup");

            //creation the Refrigerator
            string[] Refrigerator = R.ToArray();
            //Collection of food in Refrigerator
            Console.WriteLine("We have the following foods in the Refrigerator:");
            foreach (string i in Refrigerator)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
    
}
