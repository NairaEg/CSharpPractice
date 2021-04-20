using System;
using System.Text.RegularExpressions;

namespace Regex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            string number = Console.ReadLine();
            while (!CheckNumber(number))
            {
                Console.WriteLine("Enter correct number");
                number = Console.ReadLine();
            }
            Console.WriteLine(CheckNumber(number));
        }
        static bool CheckNumber(string number)
        {
            Regex rg = new Regex(@"^(\+374-|0)\d{2}\-\d{6}$");
            return rg.IsMatch(number);
        }
    }
}
