using System;

namespace diceGame
{
    public class Program
    {
        public static void Main()
        {
            //this is a change to test things on github, ooooo, aaaaaa.
            Die testDie = new();
            Scoring testScoring = new(); // Scoring class is used to store rolls / check for scoring conditions.


            while (true)
            {
                Console.WriteLine("\nPress R key to roll, or Q to quit. (Optionally, D to debug.)\n");
                ConsoleKeyInfo rollKey = Console.ReadKey();
                switch (rollKey.Key)
                {
                    case ConsoleKey.D:
                        Console.WriteLine("ebug:"); //Spelled "ebug" intentionally, run the code and see why.
                        Console.WriteLine("inPlay: " + testDie.inPlay);
                        Console.WriteLine("rollStorage: ");
                        foreach (var item in testScoring.rollStorage.Select((value, index) => new { value, index }))
                        {
                            Console.WriteLine($"index:{item.index} - value:{item.value}");
                        }
                        for (int i = 0; i < testScoring.rollStorage.Length; i++)
                        {
                            Console.WriteLine($"index: {i} - value: {testScoring.rollStorage[i]}");
                        }
                        break;
                        
                    case ConsoleKey.R:
                        Console.WriteLine("olling dice..."); //Spelled "olling" intentionally.
                        testDie.Randomized(); // Roll the die.
                        break;

                    case ConsoleKey.Q:
                        Console.WriteLine("uiting program..."); //Spelled "uitig" intentionally.
                        return;

                    default:
                        Console.WriteLine("Invalid key pressed.");
                        break;
                }
            }
        }
    }
}