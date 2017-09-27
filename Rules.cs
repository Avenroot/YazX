using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazX
{
    public class Rules
    {
        public Rules()
        {
            // Constructor
        }

        public int FullHouseValue = 25;
        public int SmallStraightValue = 30;
        public int LargeStraightValue = 40;
        public int YazValue = 50;
        public int UpperBonusValue = 35;

        // Ones
        bool IsOnes(DiceSet diceSet)
        {
            bool r = (diceSet.HowManyOnes() > 0);

            return r;
        }

       // Twos
       bool IsTwos(DiceSet diceSet)
        {
            bool r = (diceSet.HowManyTwos() > 0);

            return r;
        }

        // Threes
        bool IsThrees(DiceSet diceSet)
        {
            bool r = (diceSet.HowManyThrees() > 0);

            return r;
        }

        // Fours
        bool IsFours(DiceSet diceSet)
        {
            bool r = (diceSet.HowManyFours() > 0);

            return r;
        }

        // Fives
        bool IsFives(DiceSet diceSet)
        {
            bool r = (diceSet.HowManyFives() > 0);

            return r;
        }

        // Sixes
        bool IsSixes(DiceSet diceSet)
        {
            bool r = (diceSet.HowManySixes() > 0);

            return r;
        }



    }
}
