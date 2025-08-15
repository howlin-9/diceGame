namespace diceGame
{
    public class Die
    {
        public static int sidesCount = 6; //Made static so that field initializer in Random may reference it.
        public static int inPlay = 6; // Num of die to add to the player's hand / num of index in rollStorage.
        //public static int[] rollStorage = new int[inPlay];
        public static List<int> rollStorage = new List<int>(inPlay); //changing to List to support dynamic changes to index. 


        public static void DiceRoll()
        {
            //public int roll = Random.Shared.Next(1, sidesCount + 1);
            rollStorage.Clear();
            for (int i = 0; i < inPlay; i++)
            {
                int random = Random.Shared.Next(1, sidesCount + 1);
                //storageForStraight.rollStorage[i] = roll.random;
                //storageForTriplet.rollStorage[i] = roll.random;
                //rollStorage[i] = random;
                rollStorage.Add(random);
                //rollStorage.Insert(i, random);
            }
        }
    }
}
