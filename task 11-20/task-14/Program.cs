using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Give a new volume value (0-100) > ");
                int value = Convert.ToInt32(Console.ReadLine());

                if (value <= 0)
                {
                    Console.WriteLine("-> TOO low volume - Amplifier volume is set to minimum : 0");
                    break;
                }
                else if (value >= 100)
                {
                    Console.WriteLine("-> TOO much volume - Amplifier volume is set to maximum : 100");

                }
                else
                {
                    Console.WriteLine("-> Amplifier volume is set to : " + value);

                }
            }

            Console.WriteLine("All done!");
        }
    }
}
