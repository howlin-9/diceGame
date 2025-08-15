using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace diceGame
{
    public class DevControl
    {
        //public static string? commandLine = Console.ReadLine();


        public static void Commands()
        {
            string? commandLine = Console.ReadLine();

            //string helpCommand = "/help";
            //string inPlayCommand = "/inPlay";
            //string sidesCountCommand = "/sidesCount";

            string[] commandArray = { "help", "inPlay", "sidesCount" };

            if (commandLine == commandArray[0]) //helpCommand
            {
                Console.WriteLine("| .inPlay (set num of die per roll)\n"
                + "| .sidesCount (set num of sides per die)\n");
            }

            if (commandLine == commandArray[1]) //inPlayCommand
            {
                Console.Write("| Input a number: ");
                string? inputInPlay = Console.ReadLine();
#pragma warning disable CS8604 // Possible null reference argument.
                int inputToInt = int.Parse(inputInPlay);
                Die.inPlay = inputToInt;
            }

            if (commandLine == commandArray[2]) //sidesCountCommand
            {
                Console.Write("| Input a number: ");
                string? inputSidesCount = Console.ReadLine();
#pragma warning disable CS8604 // Possible null reference argument.
                int inputToInt = int.Parse(inputSidesCount);
                Die.sidesCount = inputToInt;
            }
        }
        public static bool Toggle2;

        public static void Info(bool Toggle = false) //int totalPointsCount = 0, int tripletCount = 0, int straightCount = 0)
        {
            OutputHandler outputHandler = new();
            //TripletDetector tripletDetector = new();
            //StraightDetector straightDetector = new();


            if (Toggle)
            {
                DevControl.Toggle2 = true;
                outputHandler.Log("Dev-info--------------");
                outputHandler.Log("| inPlay: " + Die.inPlay);
                outputHandler.Log("| sidesCount: " + Die.sidesCount);
                outputHandler.Log("| --------------------");
                //outputHandler.Log("| HasStraight: " + straightDetector.HasStraight());
                //outputHandler.Log("| HasTriplet: " + tripletDetector.HasTriplet());
                Console.WriteLine($"| straightCount: {ScoreHandler.straightCount}");
                Console.WriteLine($"| tripletCount: {ScoreHandler.sextupletCount}");
                Console.WriteLine($"| tripletCount: {ScoreHandler.quintupletCount}");
                Console.WriteLine($"| tripletCount: {ScoreHandler.quadrupletCount}");
                Console.WriteLine($"| tripletCount: {ScoreHandler.tripletCount}");
                Console.WriteLine($"| totalPointsCount: {ScoreHandler.totalPointsCount}");
                //pretty sure this doesnt work because rollStorage is an array, not a list. The size is set at runtime.
            }
            else if (!Toggle)
            { DevControl.Toggle2 = false; }
        }
    }
}