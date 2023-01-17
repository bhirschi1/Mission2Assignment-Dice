using System;

namespace Mission2Assignment_Dice
{
    class Program
    {
        static void Main(string[] args)
        {

            int numRolls = 0;

            Console.WriteLine("Welcome to the dice throwing simulator!" +
                "\n\nHow many dice rolls would you like to simulate ? ");
            numRolls = int.Parse(Console.ReadLine());

            // Call the function that actually runs the logic and prints out the output,
            //passing the num rolls the user wants
            RollDice(numRolls);

        }
        //This iNum is the number of rolls the user inputs
        static void RollDice(int iNum)
        {
            // Creating 2 arrays, 1 to hold the total times the combo was rolled
            // output holds the '*' as a percentage
            int[] rollCount = new int[11];
            string[] output = new string[11];

            // Generate a random number between 1-6 for each dice rolled
            for (int i = 0; i < iNum; i++)
            {
                Random rnd = new Random();

                int diceOne = rnd.Next(1, 7);
                int diceTwo = rnd.Next(1, 7);

                int totDice = (diceOne + diceTwo) - 2;

                // Assign the total to the correct place in the array
                rollCount[totDice]++;
            }
            Console.WriteLine("\n\nDICE ROLLING SIMULATION RESULTS" + 
                "\nEach \"*\" represents 1 % of the total number of rolls." +
                "\nTotal number of rolls = " + iNum + ".\n\n");

            
            for (int n = 0; n < 11; n++)
            {
                // converting the totals to a %
                rollCount[n] = ((rollCount[n] * 100) / iNum);

                // Ensuring no output is null in case that causes an error
                if (rollCount[n] == 0)
                {
                    output[n] = "";
                }

                // Assinging an '*' for each percentage for the output
                for (int iCount = 0; iCount < rollCount[n]; iCount++)
                {
                    output[n] += "*";
                }
            }

            for (int num = 0; num < 11; num++)
            {
                Console.WriteLine((num + 2) + ": " + output[num]);
            }

            Console.WriteLine("\n\nThank you for using the dice throwing simulator. Goodbye!");

        }
    }
}
