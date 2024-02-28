using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromecheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1, rev;
            Console.Write("Give a string");
            string1 = Console.ReadLine();
            char[] ch = string1.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + string1 + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + string1 + " is not a Palindrome!");
            }
            Console.Read();
        }
    }
}
