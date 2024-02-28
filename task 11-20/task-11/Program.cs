using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD()
            {
                Artist = "Nightwish",
                Name = "Endless Forms Most Beautiful",
                Genre = "Symphonic metal",
                Price = 18,
                Songs = new string[] {"Song 1", "Song 2", "Song 2", "Song 3", "Song 4", "Song 5", "Song 6", "Song 7", "Song 8", "Song 9", "Song 10"}
            };
            Console.WriteLine(cd.AllProp());

            Console.ReadKey();
        }
    }
    public class CD
    {
        public string Artist;
        public string Name;
        public string Genre;
        public int Price;
        public string[] Songs = {"Song 1", "Song 2", "Song 2", "Song 3", "Song 4", "Song 5", "Song 6", "Song 7", "Song 8", "Song 9", "Song 10"};
        public string AllProp()
        {
            return $"CD: \n\n Artist: {Artist} \n Name: {Name} \n Genre: {Genre} \n Price(in Euro): {Price} \n\n Songs: \n\n  {Songs[0]}\n  {Songs[1]}\n  {Songs[2]}\n  {Songs[3]}\n  {Songs[4]}\n  {Songs[5]}\n  {Songs[6]}\n  {Songs[7]}\n  {Songs[8]}\n  {Songs[9]} ";
        }

    }
}
