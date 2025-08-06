using System;

namespace diceGame
{
    public class Program
    {
        public static void Main()
        {
            Die testDie = new();
            Scoring testScoring = new(); // Scoring class is used to store rolls / check for scoring conditions.
            OutputHandler outputHandler = new();
            int diceRollCount = 0;
            int straightCount = 0;


            while (true)
            {
                outputHandler.Log("\nPress R key to roll, or Q to quit. (Optionally, D to debug.)\n");
                ConsoleKeyInfo rollKey = Console.ReadKey(true);
                switch (rollKey.Key)
                {
                    case ConsoleKey.D:
                        outputHandler.Log("---------DEBUG---------"); //Spelled "ebug" intentionally, run the code and see why.
                        outputHandler.Log("| inPlay: " + testDie.inPlay);
                        outputHandler.Log("| sidesCount: " + Die.sidesCount);
                        outputHandler.Log("| ____rollStorage____ ");
                        /*foreach (var item in testScoring.rollStorage.Select((value, index) => new { value, index }))
                        {
                            Console.WriteLine($"index:{item.index} - value:{item.value}");
                        }*/
                        for (int i = 0; i < testScoring.rollStorage.Length; i++)
                        {
                            outputHandler.Log($"| index: {i} - value: {testScoring.rollStorage[i]}");
                        }
                        outputHandler.Log("| --------------------");
                        outputHandler.Log("| hasStraight: " + testScoring.HasStraight());
                        Console.WriteLine($"| straightCount: {straightCount}");
                        break;

                    case ConsoleKey.R:
                        diceRollCount++;

                        if (testScoring.HasStraight())
                        { straightCount++; } // Increment straight count if a straight was rolled, for debugging purposes.

                        outputHandler.Log($"Rolling dice... (Roll #{diceRollCount})"); //Spelled "olling" intentionally.
                        testDie.DiceRoll(testScoring); // Roll the die.
                        foreach (int num in testScoring.rollStorage)
                        {
                            outputHandler.Log(num.ToString()); //Tell players what they just rolled.
                        }
                        if (testScoring.HasStraight())
                        {
                            outputHandler.Log("You rolled a straight! 1,500 points!");
                        }
                        else
                        {
                            outputHandler.Log("No straight rolled.");
                        }
                        break;

                    case ConsoleKey.Q:
                        outputHandler.Log("Writing log...");
                        outputHandler.WriteLogToFile(); // Write all logs to file before exiting
                        outputHandler.Log("Quiting program...");
                        return;

                    default:
                        outputHandler.Log("Invalid key pressed.");
                        break;
                }
            }
        }
    }
}