using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The idea of this progrm is to arrange my bookshelf as an ICT student.
            //It is designed to provide the info on what do i keep on which shelf.

            FirstShelf shelf1 = new FirstShelf()
            {
                Books = "Old",
                Laptop = "No",
                OldVersion = "All programming language related"
            };
            Console.WriteLine(shelf1.ShowInfo());
            SecondShelf shelf2 = new SecondShelf()
            {
                Books = "JavaScript, C#, Python, Hacking",
                Laptop = "Yes",
                Electronics = "Laptop, iPad",
                DecorativeObjects = "FlowerVase, TableWatch",
                Magazine = "From JAMK"

            };
            Console.WriteLine(shelf2.ShowInfo());
            ThirdShelf shelf3 = new ThirdShelf()
            {
                Players =  "CD & DVD Player",
                Books = "JavaScript, C#, Python, Hacking",
                Laptop = "No",
                CDs = "JavaScript, C#",
                DVDs = "Hacking, JavaScript, C#"

            };
            Console.WriteLine(shelf3.ShowInfo());
        }

    }
    public class BookShelf
    {
        public string Books { get; set; }
        public string Laptop { get; set; }


        public string Magazine { get; set; }
        public string CDs { get; set; }
        public string DVDs { get; set; }

    }
    public class FirstShelf : BookShelf
    {
        public string OldVersion { get; set; }
        public string ShowInfo()
        {
            return $"Shelf 1:\n{Books}\n{Laptop}\n{OldVersion}";
        }
    }
    public class SecondShelf : BookShelf
    {
        public string Electronics { get; set; }
        public string DecorativeObjects { get; set; }
        public string ShowInfo()
        {
            return $"\n\nShelf 2:\n{Books}\n{Electronics}\n{Magazine}\n{Laptop}\n{DecorativeObjects}";
        }
    }
    public class ThirdShelf : BookShelf
    {
        public string Players { get; set; }
        public string ShowInfo()
        {
            return $"\n\nShelf 3:\n\n{Books}\n{Players}\n{CDs}\n{DVDs}\n{Laptop}";
        }
    }
}
