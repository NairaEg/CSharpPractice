using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HW_Telescope
{
    class Telescope
    {
        int seconds;
        const double priceForAMinute = 10;

        public Telescope(double money)
        {
            seconds = (int) ((money / priceForAMinute) * 60);
        }

        public void StartTelescope(int cursorTop)
        {
            while(seconds > 0)
            {
                TimerRun(cursorTop);
            }
        }

        private void ShowStars()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\tSeeing the stars........................");
        }

        private void TimerRun(int cursorTop)
        {
            Console.SetCursorPosition(0, cursorTop);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Time left: " + TimeSpan.FromSeconds(seconds).ToString());

            ShowStars();

            if (seconds == 60)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You have 1 minute until the telescope will close.");
            }            

            Thread.Sleep(1000);
            seconds--;

            if (seconds == 0)
            {
                TimerRun(cursorTop);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your time has expired and the telescope is closed");
            }
        }
    }
}
