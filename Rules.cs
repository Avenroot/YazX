
namespace YazX
{
    public class Rules
    {
        public Rules()
        {
            // Constructor
        }


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

        // Three of a Kind
        bool IsThreeOfKind(DiceSet diceSet)
        {
            if (diceSet.HowManyOnes() >= 3) return true;
            else if
              (diceSet.HowManyTwos() >= 3) return true;
            else if
              (diceSet.HowManyThrees() >= 3) return true;
            else if
              (diceSet.HowManyFours() >= 3) return true;
            else if
              (diceSet.HowManyFives() >= 3) return true;
            else if
                (diceSet.HowManySixes() >= 3) return true;
            else
                return false;       
        } 

        // Four of a Kind
        bool IsFourOfKind(DiceSet diceSet)
        {
            if (diceSet.HowManyOnes() >= 4) return true;
            else if
              (diceSet.HowManyTwos() >= 4) return true;
            else if
              (diceSet.HowManyThrees() >= 4) return true;
            else if
              (diceSet.HowManyFours() >= 4) return true;
            else if
              (diceSet.HowManyFives() >= 4) return true;
            else if
                (diceSet.HowManySixes() >= 4) return true;
            else
                return false;
        }

        // Five of a Kind (Yaz)
        bool IsFiveOfKind(DiceSet diceSet)
        {
            if (diceSet.HowManyOnes() == 5) return true;
            else if
              (diceSet.HowManyTwos() == 5) return true;
            else if
              (diceSet.HowManyThrees() == 5) return true;
            else if
              (diceSet.HowManyFours() == 5) return true;
            else if
              (diceSet.HowManyFives() == 5) return true;
            else if
                (diceSet.HowManySixes() == 5) return true;
            else
                return false;
        }

        // Small Straight
        bool IsSmallStraight(DiceSet diceSet)
        {
            // Dice 1-4
            if ((diceSet.HowManyOnes() == 1) && (diceSet.HowManyTwos() == 1) && (diceSet.HowManyThrees() == 1) &&
                    (diceSet.HowManyFours() == 1)) return true;
            // Dice 2-5
            else if ((diceSet.HowManyTwos() == 1) && (diceSet.HowManyThrees() == 1) && (diceSet.HowManyFours() == 1) &&
                    (diceSet.HowManyFives() == 1)) return true;
            // Dice 3-6
            else if ((diceSet.HowManyThrees() == 1) && (diceSet.HowManyFours() == 1) && (diceSet.HowManyFives() == 1) &&
                     (diceSet.HowManySixes() == 1)) return true;
            else
                return false;
        }

        // Large Straight
        bool IsLargeStraight(DiceSet diceSet)
        {
            // Dice 1-5
            if ((diceSet.HowManyOnes() == 1) && (diceSet.HowManyTwos() == 1) && (diceSet.HowManyThrees() == 1) &&
                    (diceSet.HowManyFours() == 1) && (diceSet.HowManyFives() == 1)) return true;

            // Dice 2-6
            if ((diceSet.HowManyTwos() == 1) && (diceSet.HowManyThrees() == 1) && (diceSet.HowManyFours() == 1) &&
                (diceSet.HowManyFives() == 1) && (diceSet.HowManySixes() == 1)) return true;
            else
                return false;
        }

        // Full House
        bool IsFullHouse(DiceSet diceSet)
        {
            return (diceSet.IsTwoOfSameKind().TrueFalse && (diceSet.IsThreeOfSameKind().TrueFalse));
        }
    }
}
