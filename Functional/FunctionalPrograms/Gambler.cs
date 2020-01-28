using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Gambler
    {
        public static void GamblerSimulator()
        {
            int bets = 0;
            int wins = 0;
            Console.WriteLine("enter stake value");
            int stake = Utility.IntInput();
            Console.WriteLine("enter goals");
            int goal = Utility.IntInput();
            Console.WriteLine("enter trails");
            int trials = Utility.IntInput();
            Random random = new Random();
            for (int i = 0; i < trials; i++){
                int cash = stake;
                while (cash > 0 && cash < goal)
                {
                    bets++;
                    if (random.NextDouble() > 0)
                    {
                        cash++;
                    }
                    else
                    {
                        cash--;
                    }
                }
                if (cash == goal)
                {
                    wins++;
                }
            }
            Console.WriteLine(wins + " wins of " + trials);
            Console.WriteLine("Percent of games won = " + 100.0 * wins / trials);
            Console.WriteLine("Avg # bets           = " + 1.0 * bets / trials);

        }
    }
}
