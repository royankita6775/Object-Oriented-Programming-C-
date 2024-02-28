using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Radio radio1 = new Radio()
            //{
              //  SW_ON = true,
                //Power = 2F,
                //Volume = 7,
                //Frequency = 22000
            //};
            
            //Console.WriteLine(radio1.VolLimit(radio1.Volume));
            //Console.WriteLine(radio1.FreqLimit(radio1.Frequency));

                Radio radio = new Radio();
                radio.SW_ON = true;
                radio.Power = 2F;
                //radio.VolLimit(10);
                radio.Frequency = 27000;
            //Console.WriteLine(radio.VolLimit(radio.Volume), radio.FreqLimit(radio.Frequency));
            //Console.WriteLine(radio2.FreqLimit(radio2.Frequency));
            radio.VolLimit(11);
            //radio1.VolLimit(-1);
            //Console.WriteLine(radio1.Volume);
            Console.WriteLine(radio.ToString());
        }
    }
    public class ElectricalDevice
    {
        public bool SW_ON = true;
        public float Power { get; set; }
    }
    public class Radio : ElectricalDevice
    {
        private int volume;
        public int Volume
        {
            get { return volume; }
        }
        public double Frequency { get; set; }

        public void VolLimit(int volumeInput)
        {
            if(volumeInput >= 0 && volumeInput <= 9)
            {
                volume = volumeInput;
            }
            else if (volumeInput < 0)
            {
                volume = 0;
            }
            else
            {
                volume = 9;
            }
        }
        public string FreqLimit(double Frequency)
        {
            if (Frequency > 2000 && Frequency <= 26000)
            {
                return ToString();

            }
            else
            {
                return "Frequency must be in rage 2000-26000";
            }
        }
        public override string ToString()
        {
            return $"Device: Radio \n\nSwitch: ON \nPower: {Power}" + 
               $"\nVolume: {Volume} \nFrequency: {Frequency}" ;       
        }
    }
}
