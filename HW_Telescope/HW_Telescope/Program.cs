using System;

namespace HW_Telescope
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalMoney = 0;
            Console.WriteLine("Welcome to Telescope! The 1 minute cost is 10$.\nPlease enter money to see the stars.");
            string input = Console.ReadLine();

            while (input.ToLower() != "x")
            {
                if(int.TryParse(input, out int money))
                {
                    totalMoney += money;
                }
                else
                {
                    Console.WriteLine($"Your input is wrong. Try again.");
                }

                if(totalMoney >= 10)
                {
                    Console.WriteLine($"Your balance is {totalMoney}$, starting the Telescope.....");

                    Telescope telescope = new Telescope(totalMoney);
                    telescope.StartTelescope(Console.CursorTop);

                    totalMoney = 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please enter any key for continue or x for close");

                    var keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key != ConsoleKey.X)
                    {
                        Console.WriteLine("Welcome to Telescope! The 1 minute cost is 10$.\nPlease enter money to start see the stars.");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"You should enter at least 10$ to start the Telescope. Current balance is {totalMoney}$");
                }

                input = Console.ReadLine();
            }

        }
    }
}
