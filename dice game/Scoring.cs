using diceGame;
using System;
using System.Threading.Tasks;

namespace diceGame
{
    public class Scoring
    {
        public static Die valueOf = new();
        public int[] rollStorage = new int[valueOf.inPlay];

        //Consider the rest of the code below unfinished, im just laying down the foundations here.
        public bool hasStraight = false;
        public bool hasXOfKind = false;

        public void Triplets()
        {
            // 3 of a kind 1s: 1,000.
            // 3 of a kind 2-6 is 100x the number:
            // (2 = 200, 3 = 300, 4 = 400, 5 = 500, 6 = 600)
            int[] onesTriplet = { 1, 1, 1, };
            int[] twoTriplet = { 2, 2, 2, };
            int[] threeTriplet = { 3, 3, 3 };
            int[] fourTriplet = { 4, 4, 4, };
            int[] fiveTriplet = { 5, 5, 5, };
            int[] sixTriplet = { 6, 6, 6, };
            return;
            // Theres probably a less unga-bunga way to do this. 
        }

        public void XOfAKind(int x)
        {
            // In the game Farkle, there are triplets and there are "x of a kind" scores.
            // Within the "of a kind" category: 4 kind = 1k pts, 5 kind = 2k pts, and 6 kind = 3k pts.
            // I make this distinction because 3 "of a kind" (triplet) rolls are scored on a different system.
            // (See the Triplets method above)

            // This method will check for x of a kind in the rollStorage.
            // For example, if x = 4, it will check for quadruplets.
            // If x = 5, it will check for quintuplets, etc.
            return;
        }
    }
}
