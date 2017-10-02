
namespace YazX
{
    public class Scoreboard
    {
        public Scoreboard()
        {
            // Constructor
        }

        public int FullHouseValue = 25;
        public int SmallStraightValue = 30;
        public int LargeStraightValue = 40;
        public int YazValue = 50;
        public int UpperBonusValue = 35;

        public int Ones;
        public int Twos;
        public int Threes;
        public int Fours;
        public int Fives;
        public int Sixes;
        private int threeOfKind;
        public int FourOfKind;
        public int Fullhouse;
        public int SmallStraight;
        public int LargeStraight;
        public int Yaz;
        public int Chance;
        public bool Bonus;

        // Get Upper Total
        public int UpperTotal
        {
            get
            {
                var r = Ones + Twos + Threes + Fours + Fives + Sixes;

                if (Bonus) r = r + UpperBonusValue;

                return r;
            }
        }

        // Get Lower Total
        public int LowerTotal
        {
            get
            {
                var r = ThreeOfKind + FourOfKind + Fullhouse + SmallStraight + LargeStraight + Yaz + Chance;

                return r;
            }
        }

        // Get Grand Total
        public int GrandTotal
        {
            get
            {
                var r = UpperTotal + LowerTotal;

                return r;
            }            
        }

        public int ThreeOfKind
        {
            get
            {
                return threeOfKind;
            }

            set
            {
                threeOfKind = value;
            }
        }
    }
}
