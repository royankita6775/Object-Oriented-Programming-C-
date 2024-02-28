using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task_12
{
    internal class TestTank
    {
        static void Main(string[] args)
        {
        }
    }

    public class Tank
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int CrewNumber { get; set; }
        public float Speed { get; set; }
        public float SpeedMax { get; set; }
        


        public void SlowTo(string UserInput)
        {

        }
        public void AccelerateTo()
        {
            float acceleratedspeed;
            Console.WriteLine("Give the desired speed(1-100): ");
            string inputspeed = Console.ReadLine();
            acceleratedspeed = Convert.ToDouble(inputspeed);
        }
        //dont need user input
        //no cw in the methods
        //every speed value in the main program
        //value checker method

}
}

