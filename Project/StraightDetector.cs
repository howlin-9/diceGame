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
    }
}
