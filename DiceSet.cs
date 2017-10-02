using System;
namespace YazX
{
    public class DiceSet
    {
        public DiceSet()
        {
            // Constructor
        }

        int Dice1Value;
        int Dice2Value;
        int Dice3Value;
        int Dice4Value;
        int Dice5Value;

        public int HowManyOnes()
        {
            var r = 0;

            if (Dice1Value == 1) r = r + 1;
            if (Dice2Value == 1) r = r + 1;
            if (Dice3Value == 1) r = r + 1;
            if (Dice4Value == 1) r = r + 1;
            if (Dice5Value == 1) r = r + 1;

            return r;
        }

        public int HowManyTwos()
        {
            var r = 0;

            if (Dice1Value == 2) r = r + 1;
            if (Dice2Value == 2) r = r + 1;
            if (Dice3Value == 2) r = r + 1;
            if (Dice4Value == 2) r = r + 1;
            if (Dice5Value == 2) r = r + 1;

            return r;
        }

        public int HowManyThrees()
        {
            var r = 0;

            if (Dice1Value == 3) r = r + 1;
            if (Dice2Value == 3) r = r + 1;
            if (Dice3Value == 3) r = r + 1;
            if (Dice4Value == 3) r = r + 1;
            if (Dice5Value == 3) r = r + 1;

            return r;
        }

        public int HowManyFours()
        {
            var r = 0;

            if (Dice1Value == 4) r = r + 1;
            if (Dice2Value == 4) r = r + 1;
            if (Dice3Value == 4) r = r + 1;
            if (Dice4Value == 4) r = r + 1;
            if (Dice5Value == 4) r = r + 1;

            return r;
        }

        public int HowManyFives()
        {
            var r = 0;

            if (Dice1Value == 5) r = r + 1;
            if (Dice2Value == 5) r = r + 1;
            if (Dice3Value == 5) r = r + 1;
            if (Dice4Value == 5) r = r + 1;
            if (Dice5Value == 5) r = r + 1;

            return r;
        }

        public int HowManySixes()
        {
            var r = 0;

            if (Dice1Value == 6) r = r + 1;
            if (Dice2Value == 6) r = r + 1;
            if (Dice3Value == 6) r = r + 1;
            if (Dice4Value == 6) r = r + 1;
            if (Dice5Value == 6) r = r + 1;

            return r;
        }

        public DiceResults IsTwoOfSameKind()
        {
            DiceResults r = new DiceResults();

            // Handles how many ones
            if (HowManyOnes() == 2)
            {
                r.TrueFalse = true;
                r.Value1 = 1;
            }
                

            // Handles how many twos
            if (HowManyTwos() == 2)
            {
                r.TrueFalse = true;

                if (r.Value1 > 0)
                    r.Value2 = 2;
                else
                    r.Value1 = 2;
            }

            // Handles how many threes
            if (HowManyThrees() == 2)
            {
                r.TrueFalse = true;

                if (r.Value1 > 0)
                    r.Value2 = 3;
                else
                    r.Value1 = 3;
            }

            // Handles how many fours
            if (HowManyFours() == 2)
            {
                r.TrueFalse = true;

                if (r.Value1 > 0)
                    r.Value2 = 4;
                else
                    r.Value1 = 4;
            }

            // Handles how many fives
            if (HowManyFives() == 2)
            {
                r.TrueFalse = true;

                if (r.Value1 > 0)
                    r.Value2 = 5;
                else
                    r.Value1 = 5;
            }

            // Handles how many sixes
            if (HowManySixes() == 2)
            {
                r.TrueFalse = true;

                if (r.Value1 > 0)
                    r.Value2 = 6;
                else
                    r.Value1 = 6;
            }

            return r;
        }

        public DiceResults IsThreeOfSameKind()
        {
            DiceResults r = new DiceResults();

            // Handles how many ones
            if (HowManyOnes() == 3)
            {
                r.TrueFalse = true;
                r.Value1 = 1;
            }

            // Handles how many twos
            if (HowManyTwos() == 3)
            {
                r.TrueFalse = true;

                if (r.Value1 > 0)
                    r.Value2 = 2;
                else
                    r.Value1 = 2;
            }

            // Handles how many threes
            if (HowManyThrees() == 3)
            {
                r.TrueFalse = true;

                if (r.Value1 > 0)
                    r.Value2 = 3;
                else
                    r.Value1 = 3;
            }

            // Handles how many fours
            if (HowManyFours() == 3)
            {
                r.TrueFalse = true;

                if (r.Value1 > 0)
                    r.Value2 = 4;
                else
                    r.Value1 = 4;
            }

            // Handles how many fives
            if (HowManyFives() == 3)
            {
                r.TrueFalse = true;

                if (r.Value1 > 0)
                    r.Value2 = 5;
                else
                    r.Value1 = 5;
            }

            // Handles how many sixes
            if (HowManySixes() == 3)
            {
                r.TrueFalse = true;

                if (r.Value1 > 0)
                    r.Value2 = 6;
                else
                    r.Value1 = 6;
            }

            return r;
        }


    }
}
