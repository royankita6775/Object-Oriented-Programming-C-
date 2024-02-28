using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the window(in metres): ");
            int H = Convert.ToInt32(Console.Read());

            Console.WriteLine("Enter the weidth of the window(in metres): ");
            int W = Convert.ToInt32(Console.Read());

            int A = H * W;
            Console.WriteLine("Area of the window(in squaremetres): " + A);

            int C = 2 * (H * W);
            Console.WriteLine("Circumference of the window(in metres): " + C);

        }
    }
}
