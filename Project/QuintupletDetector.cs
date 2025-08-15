namespace diceGame
{
    public class QuintupletDetector
    {
        // 4 kind = 1k pts, 5 kind = 2k pts, and 6 kind = 3k pts.
        public static bool hasQuintuplet;

        public static int i;
        public bool HasQuintuplet()
        {
            for (i = 1; i < Die.inPlay; i++)
            {
                int countQuintuplet = Die.rollStorage.Count(x => x == i);
                if (countQuintuplet >= 5)
                {
                    return hasQuintuplet = true;
                }
            }
            return hasQuintuplet = false;
        }
    }
}