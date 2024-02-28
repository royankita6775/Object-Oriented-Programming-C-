namespace Task1
{
    public class Grade
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Numbner: ");
            bool Valid = false;
            int number = 0;
            int grade = 0;
            while (Valid)
            {
                string userprint = Console.ReadLine();
                if (int.TryParse(userprint, out grade))
                {
                    number=grade;
                    Valid = false;
                }
                else
                {
                    Console.Write("please input a number");
                }
            }

            number = Convert.ToInt32(Console.ReadLine());

            if (number < 20)
            {
                Console.WriteLine("Your grade is 0");
            }
            else if (number < 30)
            {
                Console.WriteLine("Your grade is 1");
            }
            else if (number < 40)
            {
                Console.WriteLine("Your grade is 2");
            }
            else if (number < 50)
            {
                Console.WriteLine("Your grade is 3");
            }
            else if (number < 60)
            {
                Console.WriteLine("Your grade is 4");
            }
            else if (number < 71)
            {
                Console.WriteLine("Your grade is 5");
            }
            else
            {
                Console.WriteLine("Put a number in range 0-70");
            }
        }
    }
}