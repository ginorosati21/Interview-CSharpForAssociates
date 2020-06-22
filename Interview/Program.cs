using System;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to the interview");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            string message = "";
            if(age >= 21)
            {
                message = "Have a beer after work";
            } else
            {
                message = "You should have a rootbeer";
            }

            Console.WriteLine("Hello, " + name);
            Console.WriteLine(message);

            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}
