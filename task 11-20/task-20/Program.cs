using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {

            Human human = new Human()
            {
                name = "John",
                weight = 55,
                height = 165,
                age = 17,
            };
            Console.WriteLine(human.Humaninfo());
            human.grow();



            Baby baby = new Baby()
            {
                name = "Kaia",
                weight = 18,
                height = 85,
                age = 5,
                diaper = "pampers",
            };
            Console.WriteLine(baby.Babyinfo());
            baby.move();

            Adult adult = new Adult()
            {
                name = "Jess",
                weight = 53,
                height = 185,
                age = 24,
                auto = "talk",
            };
            Console.WriteLine(adult.Adultinfo());
            adult.move();

            Console.ReadKey();

        }

        abstract class Mammal
        {
            public int age = 18;

            public void move()
            {
                Console.WriteLine("Moving");
            }
        }


        class Human : Mammal
        {
            public string name;
            public int weight;
            public int height;
            public int age;

            public virtual void move()
            {
                Console.WriteLine("Moving");
            }
            public void grow()
            {
                age++;
            }
            public string Humaninfo()
            {
                return $"Name: {name} \n Weight: {weight} \n Height: {height} \n Age: {age} ";
            }
        }

        class Baby : Human
        {
            public string diaper;

            public override void move()
            {
                Console.WriteLine("Crawling");
            }
            public string Babyinfo()
            {
                return $"Name: {name} \n Weight: {weight} \n Height: {height} \n Age: {age} \n Diaper: {diaper}";
            }

        }

        class Adult : Human
        {
            public string auto;

            public override void move()
            {
                Console.WriteLine("Walking");
            }
            public string Adultinfo()
            {
                return $"Name: {name} \n Weight: {weight} \n Height: {height} \n Age: {age} \n Auto: {auto}";
            }

        }

    }
}