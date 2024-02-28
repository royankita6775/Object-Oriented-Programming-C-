using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace task_25
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car
            {
                Brand = "Ford",
                Model = "Mustang",
                TireNumber = 4,
                tires = "Nokia Hakkapeliitta 205R16"
            };
            Car car2 = new Car
            {
                Brand = "Chevy",
                Model = "Corvette",
                TireNumber = 4,
                tires = "MIC Pilot 160R17"
            };

            Tire tire1 = new Tire
            {
                Manufacturer = "Nokia",
                Model = "Hakkapeliitta",
                TireSize = "205R16"
            };
            Tire tire2 = new Tire
            {
                Manufacturer = "MIC",
                Model = "Pilot",
                TireSize = "160R17"
            };

            Console.WriteLine(car1.CarInfo());
            Console.WriteLine(car2.CarInfo());
            Console.WriteLine(tire1.TireInfo());
            Console.WriteLine(tire2.TireInfo());

            Console.ReadKey();
        }
    }
    public class Tire
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string TireSize { get; set; }
        public string TireInfo()
        {
            return $"Manufacturer: {Manufacturer}\nModel: {Model}\nTireSize: {TireSize}";
        }
    }
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int TireNumber { get; set; }
        public string tires { get; set; }
        public string CarInfo()
        {
            return $"Brand: {Brand}\nModel: {Model}\nTireNumber: {TireNumber}\nTires: {tires}\n";
        }
    }
}
