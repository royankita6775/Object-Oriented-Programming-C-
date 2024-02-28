using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicycle bike1 = new Bicycle()
            {
                Name = "Jopo",
                Model = "Street",
                YearModel = 2016,
                Color = "Blue",
                GearWheels = "True",
                GearName = "ShimanoNexus"
            };
            Console.WriteLine("Bike1 info");
            Console.WriteLine(bike1.BikeInfo());

            Bicycle bike2 = new Bicycle()
            {
                Name = "Tunturi",
                Model = "StreetPower",
                YearModel = 2010,
                Color = "Black",
                GearWheels = "True",
                GearName = "Shimano Nexus"
            };
            Console.WriteLine($"\nBike2 info");
            Console.WriteLine(bike2.BikeInfo());

            Boat boat1 = new Boat()
            {
                Name = "SummerFun",
                Model = "S900",
                YearModel = 1990,
                Color = "White",
                SeatCount = 3,
                BoatType = "RowBoat"
            };
            Console.WriteLine($"\nBoat1 info");
            Console.WriteLine(boat1.BoatInfo());

            Boat boat2 = new Boat()
            {
                Name = "Yamaha",
                Model = "Model 1000",
                YearModel = 2010,
                Color = "Yellow",
                SeatCount = 5,
                BoatType = "MotorBoat"
            };
            Console.WriteLine($"\nBoat2 info");
            Console.WriteLine(boat2.BoatInfo());
            Console.ReadKey();
        }

    }
    public class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int YearModel { get; set; }
        public string Color { get; set; }
    }
    public class Bicycle : Vehicle
    {
        public string GearWheels { get; set; }
        public string GearName { get; set; }
        public string BikeInfo()
        {
            return $"- Name:{Name} Model:{Model} ModelYear:{YearModel} Color:{Color} GearWheels:{GearWheels} GearName:{GearName}";
        }
    }
    public class Boat : Vehicle
    {
        public int SeatCount { get; set; }
        public string BoatType { get; set; }
        public string BoatInfo()
        {
            return $"- Name:{Name} Model:{Model} ModelYear:{YearModel} Color:{Color} SeatCount:{SeatCount} BoatType:{BoatType}";
        }
    }
}
