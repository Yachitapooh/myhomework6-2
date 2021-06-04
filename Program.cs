using System;

namespace myhpmework
{
    class Program
    {
        static void Main(string[] args)
        {
            int ddd, yyy;
            Console.Write("Input your birthday : ");
            ddd = int.Parse(Console.ReadLine());
            string mmm;
            Console.Write("Input your mount of birth : ");
            mmm = Console.ReadLine();
            Console.Write("Input your year of birth : ");
            yyy = int.Parse(Console.ReadLine());

            int year = 2564;
            Console.WriteLine("Your age is {0} years old.", year - yyy);
            int age = year - yyy;
           

            if (age >= 18)
            {
                Console.WriteLine("You can sign up.");
                string name, surname;
                Console.Write("Input your name : ");
                name = Console.ReadLine();
                Console.Write("Input your surnsme : ");
                surname = Console.ReadLine();
                Console.WriteLine("Ready to use");
            }
            else 
            {
                Console.Write("Sorry Under age cannot apply for sign up.");
            }

            Console.ReadLine();
        }
    }
}
