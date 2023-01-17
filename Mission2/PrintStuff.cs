using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2
{
    class PrintStuff
    {
        // Finding Random Number 1 and 2 --static int instead of void
        public void GetRandomNum(int diceRoll)
        {
            int[] totals = new int[13];

            for (int i = 0; i < diceRoll; i++)
            {
                int diceTotal = 0;
                Random random = new Random();
                int dice1 = random.Next(1, 7);   // creates a number between 1 and 6 
                int dice2 = random.Next(1, 7);

                // Adding Random Numbers Together
                diceTotal = dice1 + dice2;

                totals[(diceTotal)]++;
   
                
        
            }

            // print histogram
            for (int i = 2; i <= 12; i++)
            {
                Console.Write("{0}: ", i);
                // calculate percentage and scale to number of asterix
                int asterix = (int)((double)totals[i] / diceRoll * 100); 
                for (int j = 0; j < asterix; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            
            }
         

            //PRINT
            //for (int i = 0; i < diceRoll; i++)
            //{
            //  int NumPct = 0;
            //NumPct = (char)(i + 12);

            // Console.WriteLine(NumPct + ": " + totals[i]);
            //}

        }
    }
}
