namespace diceGame
{
    public class QuadrupletDetector
    {
        // 4 kind = 1k pts, 5 kind = 2k pts, and 6 kind = 3k pts.
        public static bool hasQuadruplet;
        public static int i;

        public bool HasQuadruplet()
        {
            for (i = 1; i < Die.inPlay; i++)
            {
                int countQuadruplet = Die.rollStorage.Count(x => x == i);
                if (countQuadruplet >= 4)
                {
                    return hasQuadruplet = true;
                }
            }
            return hasQuadruplet = false;
        }
    }
}