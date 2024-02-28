using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace T9Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle() { brand = "Ford", model = "2006", speed = 120, tyres = 4 };
            Vehicle vehicle2 = new Vehicle() { brand = "BMW", model = "2016", speed = 220, tyres = 4 };

            Console.WriteLine("My vehicle details: " + vehicle1);
            Console.WriteLine("Sifats vehicle details: " + vehicle2);

            vehicle1.model = "2010";

            Console.WriteLine("My vehicle details: " + vehicle1);

            Console.ReadLine();
        }
    }
}
