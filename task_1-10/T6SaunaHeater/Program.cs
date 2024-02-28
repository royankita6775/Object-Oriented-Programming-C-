using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            kiuas kiuas = new kiuas();
            while(true)
            {
                Console.WriteLine("Switch (on/off) " + (kiuas.Power ? "on" : "off"));
                Console.WriteLine("Temperature: " + kiuas.Temperature);
                Console.WriteLine("Humidity: " + kiuas.Humidity);

                Console.Write("Type (on/off): ");

                string onoff = Console.ReadLine();

                if (onoff == "on")
                {
                    kiuas.Power = true;
                }
                else if (onoff == "off")
                {
                    break;
                }
                
                Console.WriteLine("Set your own temperature and humidity!");
                
                Console.Write("Temperature: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Humidity: ");
                int b = Convert.ToInt32(Console.ReadLine());

                kiuas.Temperature = a;
                kiuas.Humidity = b;

                
            }
            
        }
    }
    public class kiuas 
    {
        public bool Power = false;
        public double Temperature = 27.50;
        public int Humidity = 30;
    }
}
