using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;


namespace diceGame
{
    public class TripletDetector
    {
        // 3 of a kind 1s: 1,000.
        // 3 of a kind 2-6 is 100x the number:
        // (2 = 200, 3 = 300, 4 = 400, 5 = 500, 6 = 600)
        public bool hasTriplet;

        public bool HasTriplet()
        {
            for (int i = 1; i < 7; i++)
            {
                int countTriplets = Die.rollStorage.Count(x => x == i);
                if (countTriplets >= 3)
                {
                    return hasTriplet = true;
                }
            }
            return hasTriplet = false;
        }

    }
}