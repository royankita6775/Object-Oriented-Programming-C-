using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Name of the student: ");
                string a = Console.ReadLine();
                Console.Write("ID of the student: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Subject: ");
                string p = Console.ReadLine();

                string[] studentNames = { a };
                int[] studentIDs = { x };
                string[] studentsubjects = { p };

                Console.WriteLine("*****Students Information*****");
                Console.WriteLine("Name: " + a + " ID: " + x + " Subject: " + p);
            }

            Console.ReadLine();
        }
    }
}
