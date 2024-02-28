using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st input");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Addition(a, b);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(a, b);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(a, b);
                        break;
                    }
                case 4:
                    {
                        result = Division(a, b);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }
        //Addition  
        public static int Addition(int a, int b)
        {
            int result = a + b;
            return result;
        }
        //Substraction  
        public static int Subtraction(int a, int b)
        {
            int result = a - b;
            return result;
        }
        //Multiplication  
        public static int Multiplication(int a, int b)
        {
            int result = a * b;
            return result;
        }
        //Division  
        public static int Division(int a, int b)
        {
            int result = a / b;
            return result;
        }
    }
}