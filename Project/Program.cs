using System;
using System.Threading.Tasks;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace diceGame
{
    public class Program
    {
        public static void Main()
        {

            StraightDetector straightDetector = new();
            SextupletDetector sextupletDetector = new();
            QuadrupletDetector quadrupletDetector = new();
            QuintupletDetector quintupletDetector = new();
            TripletDetector tripletDetector = new();
            OutputHandler outputHandler = new();
            ScoreHandler scoreHandlerInstance = new();
            
            int diceRollCount = 0;

            //int straightCount = 0;
            //int tripletCount = 0;
            //int totalPointsCount = 0;

            //DevControl.Info();

            while (true)
            {
                outputHandler.Log("\nPress [R key: roll] - [Q key: quit] - [D key: dev info] - [. key: Command prefix]\n");

                ConsoleKeyInfo rollKey = Console.ReadKey(true);

                switch (rollKey.Key)
                {
                    case ConsoleKey.OemPeriod:
                        Console.Write(".");
                        DevControl.Commands();
                        break;

                    case ConsoleKey.D:
                        DevControl.Info(true);

                        //outputHandler.Log("| ____rollStorage____ ");
                        /*foreach (var item in straightDetector.rollStorage.Select((value, index) => new { value, index }))
                        {
                            Console.WriteLine($"index:{item.index} - value:{item.value}");
                        }
                        
                        for (int i = 0; i < Die.inPlay; i++)
                        {
                            outputHandler.Log($"| index: {i} - value: {Die.rollStorage}");
                        }
                        */
                        break;

                    case ConsoleKey.R:
                        Die.DiceRoll(); // Roll the die.

                        diceRollCount++;

                        if (DevControl.Toggle2)
                        { DevControl.Info(true); }

                        outputHandler.Log($"Rolling dice... (Roll #{diceRollCount})");

                        foreach (int num in Die.rollStorage)
                        {
                            outputHandler.Log(num.ToString());
                        }

                        //detect straights
                        if (straightDetector.HasStraight())
                        {
                            ScoreHandler.straightCount++;
                            //DevControl.Info(false, +0, +0, +1); // this breaks the debug toggle
                            ScoreHandler.totalPointsCount = ScoreHandler.totalPointsCount + scoreHandlerInstance.StraightOutput(0);
                            outputHandler.Log("You rolled a straight! 1,500 points!");
                        }

                        //detect triplet
                        if (tripletDetector.HasTriplet())
                        {
                            ScoreHandler.tripletCount++;
                            //DevControl.Info(false, +0, +1); // this breaks the debug toggle
                            ScoreHandler.totalPointsCount += scoreHandlerInstance.TripletOutput(0);
                            outputHandler.Log($"You rolled triple {TripletDetector.i}'s! {scoreHandlerInstance.TripletOutput(0)} points!");
                        }

                        //detect quadruplet
                        if (quadrupletDetector.HasQuadruplet())
                        {
                            ScoreHandler.quadrupletCount++;
                            ScoreHandler.totalPointsCount += scoreHandlerInstance.QuadrupletOutput(0);
                            outputHandler.Log($"You rolled quadruple {QuadrupletDetector.i}'s! {scoreHandlerInstance.QuadrupletOutput(0)} points!");
                        }

                        //detect quintuplet
                        if (quintupletDetector.HasQuintuplet())
                        {
                            ScoreHandler.quintupletCount++;
                            ScoreHandler.totalPointsCount += scoreHandlerInstance.QuintupletOutput(0);
                            outputHandler.Log($"You rolled quintuple {QuintupletDetector.i}'s! {scoreHandlerInstance.QuintupletOutput(0)} points!");
                        }

                        //detect sextuplet
                        if (sextupletDetector.HasSextuplet())
                        {
                            ScoreHandler.sextupletCount++;
                            ScoreHandler.totalPointsCount += scoreHandlerInstance.SextupletOutput(0);
                            outputHandler.Log($"You rolled sextuple {SextupletDetector.i}'s! {scoreHandlerInstance.SextupletOutput(0)} points!");
                        }

                        outputHandler.Log($"totalPointsCount: {ScoreHandler.totalPointsCount}");
                        break;

                    case ConsoleKey.Q:
                        outputHandler.Log("Writing log...");
                        outputHandler.WriteLogToFile();
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