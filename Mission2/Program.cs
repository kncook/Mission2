using System;

namespace Mission2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintStuff ps = new PrintStuff();

            //initialize values
            string userinput = "";
            int diceRoll;

            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            //allows user to inputand converts input to an int
            userinput = Console.ReadLine();
            diceRoll = Convert.ToInt32(userinput);

            //prints at end
            Console.WriteLine("\n" + "DICE ROLLING SIMULATION RESULTS" + "\n" + "Each '*' represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + diceRoll + "\n");

            ps.GetRandomNum(diceRoll);
        }
    }
}
