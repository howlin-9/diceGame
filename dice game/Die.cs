namespace diceGame
{
    public class Die
    {
        public static int sidesCount = 6; //Made static so that field initializer in Random may reference it.
        public static int inPlay = 6; // Num of die to add to the player's hand, num of index in rollStorage.
        public static int[] rollStorage = new int[inPlay];

        public static void DiceRoll(StraightDetector storageForStraight, TripletDetector storageForTriplet)
        {
            //public int roll = Random.Shared.Next(1, sidesCount + 1);
            for (int i = 0; i < inPlay; i++)
            {
                int random = Random.Shared.Next(1, sidesCount + 1);
                //storageForStraight.rollStorage[i] = roll.random;
                //storageForTriplet.rollStorage[i] = roll.random;
                rollStorage[i] = random;
            }
        }
    }
}
