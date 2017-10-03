
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

        public int Ones { get; set; }
        public int Twos { get; set; }
        public int Threes { get; set; }
        public int Fours { get; set; }
        public int Fives { get; set; }
        public int Sixes { get; set; }
        
        public int ThreeOfKind { get; set; }
        public int FourOfKind { get; set; }        
        public int FullHouse { get; set; }        
        public int SmallStraight { get; set; }        
        public int LargeStraight { get; set; }        
        public int Yaz { get; set; }        
        public int Chance { get; set; }        
        public bool Bonus { get; set; }

      

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
                var r = ThreeOfKind + FourOfKind + FullHouse + SmallStraight + LargeStraight + Yaz + Chance;

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

        // Resets the Scoreboard
        public void Reset()
        {
            Ones = 0;
            Twos = 0;
            Threes = 0;
            Fours = 0;
            Fives = 0;
            Sixes = 0;
            ThreeOfKind = 0;
            FourOfKind = 0;
            FullHouse = 0;
            SmallStraight = 0;
            LargeStraight = 0;
            Yaz = 0;
            Chance = 0;
            Bonus = false;
        }
    }
}
