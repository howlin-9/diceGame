using System;
using System.Threading.Tasks;
using System.Linq;
using System.Runtime.CompilerServices;

namespace diceGame
{
    public class Program
    {
        public static void Main()
        {
            //Die testDie = new();
            StraightDetector straightDetector = new();
            TripletDetector tripletDetector = new();
            OutputHandler outputHandler = new();
            int diceRollCount = 0;
            int straightCount = 0;
            int tripletCount = 0;


            while (true)
            {
                outputHandler.Log("\nPress R key to roll, or Q to quit. (Optionally, D to debug.)\n");
                ConsoleKeyInfo rollKey = Console.ReadKey(true);
                switch (rollKey.Key)
                {
                    case ConsoleKey.D:
                        outputHandler.Log("---------DEBUG---------");
                        outputHandler.Log("| inPlay: " + Die.inPlay);
                        outputHandler.Log("| sidesCount: " + Die.sidesCount);
                        outputHandler.Log("| ____rollStorage____ ");
                        /*foreach (var item in straightDetector.rollStorage.Select((value, index) => new { value, index }))
                        {
                            Console.WriteLine($"index:{item.index} - value:{item.value}");
                        }*/
                        for (int i = 0; i < Die.rollStorage.Length; i++)
                        {
                            outputHandler.Log($"| index: {i} - value: {Die.rollStorage[i]}");
                        }
                        outputHandler.Log("| --------------------");
                        outputHandler.Log("| HasStraight: " + straightDetector.HasStraight());
                        outputHandler.Log("| HasTriplet: " + tripletDetector.HasTriplet());
                        Console.WriteLine($"| straightCount: {straightCount}");
                        Console.WriteLine($"| tripletCount: {tripletCount}");
                        break;

                    case ConsoleKey.R:
                        Die.DiceRoll(straightDetector, tripletDetector); // Roll the die.

                        outputHandler.Log($"Rolling dice... (Roll #{diceRollCount})");
                        diceRollCount++;

                        foreach (int num in Die.rollStorage)
                        {
                            outputHandler.Log(num.ToString()); //Tell players what they just rolled.
                        }

                        //detect straights
                        if (straightDetector.HasStraight())
                        {
                            straightCount++; // Increment straight count if a straight was rolled, for debugging purposes.
                            outputHandler.Log("You rolled a straight! 1,500 points!");
                        }
                        else
                        {
                            outputHandler.Log("No straight rolled.");
                        }

                        //detect triplet
                        if (tripletDetector.HasTriplet())
                        {
                            tripletCount++; // Increment triplet count if a straight was rolled, for debugging purposes.
                            outputHandler.Log("You rolled a triplet! 'xyz' points!");
                        }
                        else
                        {
                            outputHandler.Log("No triplet rolled.");
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