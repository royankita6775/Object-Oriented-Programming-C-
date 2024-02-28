using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Television television = new Television();

            Console.WriteLine("Welcome to your Television!!!");

            Console.WriteLine("Channel: " + television.channel);
            Console.WriteLine("Volume: " + television.volume);

            Console.WriteLine("Set the channel and volume!!!");

            Console.Write("Channel: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Volume: ");
            int b = Convert.ToInt32(Console.ReadLine());

            television.channel = a;
            television.volume = b;

            Console.WriteLine("You are on channel number " + a);
            Console.WriteLine("Volume you set is " + b);

            Console.ReadLine();
        }
    }
    public class Television
    {
        public int channel { get; set; }
        public int volume { get; set; }

        public Television(int aChannel, int aVolume)
        {
            channel = aChannel;
            volume = aVolume;
        }
        public Television()
        {
            channel = 0;
            volume = 0;
        }
    }
}
