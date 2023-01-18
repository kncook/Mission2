using System;
using System.Collections.Generic;
using System.Text;

//Katherine Cook
// 1/18/2022
// This program simulates the rolling of two 6-sided dice.  The user chooses how many times the “dice” will be thrown. Then, once the dice have
//been thrown the specified number of times, a histogram is printed (using the* character) that shows
//the total percentage each number was rolled. Each * will represent 1% of the total rolls.

namespace Mission2
{
    class PrintStuff
    {
        // Finding Random Number 1 and 2 --static int instead of void
        public void GetRandomNum(int diceRoll)
        {
            int[] totals = new int[13];

            //simulate the roll of die for # of times user inputs
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
         

        }
    }
}
