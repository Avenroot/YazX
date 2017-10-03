
namespace YazX
{
    public class DiceSet
    {
        public DiceSet()
        {
            // Constructor
        }

        public int Dice1Value { get; set; }
        public int Dice2Value { get; set; }
        public int Dice3Value { get; set; }
        public int Dice4Value { get; set; }
        public int Dice5Value { get; set; }

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

        // Calculate all dice values
        public int CalculateAllValues()
        {
            var r = Dice1Value + Dice2Value + Dice3Value + Dice4Value + Dice5Value;

            return r; 
        }
        
        // Calculate Ones
        public int CalculateOnes()
        {
            var r = 0;

            if (Dice1Value == 1) r = r + 1;
            if (Dice2Value == 1) r = r + 1;
            if (Dice3Value == 1) r = r + 1;
            if (Dice4Value == 1) r = r + 1;
            if (Dice5Value == 1) r = r + 1;

            return r;
        }

        // Calculate Twos
        public int CalculateTwos()
        {
            var r = 0;

            if (Dice1Value == 2) r = r + 2;
            if (Dice2Value == 2) r = r + 2;
            if (Dice3Value == 2) r = r + 2;
            if (Dice4Value == 2) r = r + 2;
            if (Dice5Value == 2) r = r + 2;

            return r;
        }

        public int CalculateThrees()
        {
            var r = 0;

            if (Dice1Value == 3) r = r + 3;
            if (Dice2Value == 3) r = r + 3;
            if (Dice3Value == 3) r = r + 3;
            if (Dice4Value == 3) r = r + 3;
            if (Dice5Value == 3) r = r + 3;

            return r;
        }

        public int CalculateFours()
        {
            var r = 0;

            if (Dice1Value == 4) r = r + 4;
            if (Dice2Value == 4) r = r + 4;
            if (Dice3Value == 4) r = r + 4;
            if (Dice4Value == 4) r = r + 4;
            if (Dice5Value == 4) r = r + 4;

            return r;
        }

        public int CalculateFives()
        {
            var r = 0;

            if (Dice1Value == 5) r = r + 5;
            if (Dice2Value == 5) r = r + 5;
            if (Dice3Value == 5) r = r + 5;
            if (Dice4Value == 5) r = r + 5;
            if (Dice5Value == 5) r = r + 5;

            return r;
        }

        public int CalculateSixes()
        {
            var r = 0;

            if (Dice1Value == 6) r = r + 6;
            if (Dice2Value == 6) r = r + 6;
            if (Dice3Value == 6) r = r + 6;
            if (Dice4Value == 6) r = r + 6;
            if (Dice5Value == 6) r = r + 6;

            return r;
        }

        public int CalculateThreeOfKind()
        {
            var r = CalculateAllValues();

            return r;
        }

        public int CalculateFourOfKind()
        {
            var r = CalculateAllValues();

            return r;
        }

        public int CalculateFullHouse()
        {
            var scoreboard = new Scoreboard();
            var r = scoreboard.FullHouseValue;

            return r;
        }

        public int CalculateSmallStraight()
        {
            var scoreboard = new Scoreboard();
            var r = scoreboard.SmallStraightValue;

            return r;
        }

        public int CalculateLargeStraight()
        {
            var scoreboard = new Scoreboard();
            var r = scoreboard.LargeStraightValue;

            return r;
        }

        public int CalculateYaz()
        {
            var scoreboard = new Scoreboard();
            var r = scoreboard.YazValue;

            return r;
        }

        public int CalculateChance()
        {
            var r = CalculateAllValues();

            return r;
        }
    }
}
