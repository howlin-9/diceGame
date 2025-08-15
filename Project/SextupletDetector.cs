namespace diceGame
{
    public class SextupletDetector
    {
        // 4 kind = 1k pts, 5 kind = 2k pts, and 6 kind = 3k pts.
        public static bool hasSextuplet;

        public static int i;
        public bool HasSextuplet()
        {
            for (i = 1; i < Die.inPlay; i++)
            {
                int countSextuplet = Die.rollStorage.Count(x => x == i);
                if (countSextuplet >= 6)
                {
                    return hasSextuplet = true;
                }
            }
            return hasSextuplet = false;
        }
    }
}