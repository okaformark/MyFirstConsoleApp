using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Not hello world
            Console.WriteLine("Please state your full name!");
            var fullname = Console.ReadLine();
            Console.WriteLine($"Welcome to Bangazon {fullname}");

            // Accepting user Input
            // Number multiplier
            Console.WriteLine("Enter strings seperated with a comma");
            var stringInput = Console.ReadLine();
            var variables = stringInput.Split(",");
            var result = 1;
            for (int i = 0; i < variables.Length; i++)
            {
                var intAnswer = int.Parse(variables[i]);
                result = intAnswer * result;
            }
            Console.WriteLine($"The reult is {result}");
        }
    }
}
