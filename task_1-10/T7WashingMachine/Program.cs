using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WashingMachine wc1 = new WashingMachine();

            Console.WriteLine("Temperature: " + wc1.temperature);
            Console.WriteLine("Humidity: " + wc1.timer);

            Console.WriteLine("Set the temperature and timer!");

            Console.Write("Temperature: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Humidity: ");
            int b = Convert.ToInt32(Console.ReadLine());

            wc1.temperature = a;
            wc1.timer = b;

            Console.WriteLine("Washing starts...");
            Console.ReadLine();
        }
    }
}
