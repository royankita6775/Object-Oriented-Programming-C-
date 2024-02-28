using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main()
            {
                string name = "";
                int year;
                string[] userinputsplit;
                Dictionary<string, Int32> nameage = new Dictionary<string, Int32>();
                int age = 0;
                int mycount = 0;
                string userinput;
                Console.WriteLine("Please, give names and birth year of a person. Empty input will stop the input.");

                bool t = true;
                while (t)
                {
                Console.Write("please enter a name: ");
                    userinput = Console.ReadLine();
                    mycount++;

                    if (userinput.Length == 0)
                    {
                        mycount--;
                        t = false;
                    }
                    else
                    {
                        userinputsplit = userinput.Split(',');
                        name = userinputsplit[0];
                        year = Convert.ToInt32(userinputsplit[1]);
                        age = DateTime.Now.Year - year;
                        nameage.Add(name, age);
                        t = true;
                    }
                }
                Console.WriteLine(mycount + "names are given:");
                for(int i = 0; i < nameage.Count; i++)
                {
                    Console.WriteLine($"{nameage.ElementAt(i).Key} is {nameage.ElementAt(i).Value} Years old.");
                }

            }
    }
}
