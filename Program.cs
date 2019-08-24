using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
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
