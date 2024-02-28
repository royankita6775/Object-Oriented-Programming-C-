using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a point: ");
            int point1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Give a point: ");
            int point2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Give a point: ");
            int point3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Give a point: ");
            int point4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Give a point: ");
            int point5 = Convert.ToInt32(Console.ReadLine());

            int[] list_of_scores = { point1, point2, point3, point4, point5 };
            int totalpoints = list_of_scores.Sum() - list_of_scores.Max() - list_of_scores.Min();
            Console.WriteLine("Your final score is " + totalpoints);
        }
    }
}
