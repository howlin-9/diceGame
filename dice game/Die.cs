using diceGame;
using System;
using System.Threading.Tasks;

namespace diceGame
{
    public class Die
    {
        public static int sidesCount = 6; //Made static so that field initializer in Random may reference it.
        public int inPlay = 6; // Num of die to add to the player's hand, num of index in rollStorage.
        public int roll;

        public int Randomized()
        {
            Scoring storage = new();
            for (int i = 0; i < inPlay; i++)
            {
                roll = Random.Shared.Next(1, sidesCount + 1);
                storage.rollStorage[i] = roll;
            }
            foreach (int num in storage.rollStorage)
            {
                Console.WriteLine(num); //Tell players what they just rolled.
            }
            return roll; //Honestly not sure wtf i should return here...lol.
        }
    }
}
