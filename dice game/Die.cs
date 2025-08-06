using diceGame;
using System;
using System.Threading.Tasks; 

namespace diceGame
{
    public class Die
    {
        public static int sidesCount = 6; //Made static so that field initializer in Random may reference it.
        public int inPlay = 6; // Num of die to add to the player's hand, num of index in rollStorage.
        public int random = Random.Shared.Next(1, sidesCount + 1);

        public void DiceRoll(Scoring storage)
        {
            //public int roll = Random.Shared.Next(1, sidesCount + 1);
            for (int i = 0; i < inPlay; i++)
            {
                //roll = Random.Shared.Next(1, sidesCount + 1);
                Die roll = new();
                storage.rollStorage[i] = roll.random;
            }
        }
    }
}
