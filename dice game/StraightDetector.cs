namespace diceGame
{
    public class StraightDetector
    {
        //public static Die valueOf = new();
        //public int[] rollStorage = new int[valueOf.inPlay];
        public static int[] straight = { 1, 2, 3, 4, 5, 6 };

        //Consider the rest of the code below unfinished, im just laying down the foundations here.
        public bool HasStraight()
        {
            return Die.rollStorage.OrderBy(n => n).SequenceEqual(straight);
        }
        
        //
        //public bool hasXOfKind = false;
        /*
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
        */
    }
}
