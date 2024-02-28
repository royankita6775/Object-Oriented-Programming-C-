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
            VType v1 = new VType()
            {
                brand = "Nissan", 
                model = "E", 
                speed = 120, 
                tires = 4,
                type = "private"
            };

            v1.speed = 10;
            Console.WriteLine(v1.ShowInfo());
        }
    }
    public class Vehicle
    {
        public string brand;
        public string model;
        public int speed;
        public int tires;

        public string ShowInfo()
        {
            return $"The manufacturer is {brand} and the model is {model}, speed is {speed}";
        }
    }
    public class VType : Vehicle
    {
        public string type;
    }
}
