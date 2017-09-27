using System;
namespace YazX
{
    public class DiceSet
    {
        public DiceSet()
        {
            int Dice1Value;
            int Dice2Value;
            int Dice3Value;
            int Dice4Value;
            int Dice5Value;

            int HowManyOnes() {
                int r = 0;

                if (Dice1Value == 1) r = r + 1;
                if (Dice2Value == 1) r = r + 1;
                if (Dice3Value == 1) r = r + 1;
                if (Dice4Value == 1) r = r + 1;
                if (Dice5Value == 1) r = r + 1;

                return r;
            }

            int HowManyTwos() {
                int r = 0;

                if (Dice1Value == 2) r = r + 1;
                if (Dice2Value == 2) r = r + 1;
                if (Dice3Value == 2) r = r + 1;
                if (Dice4Value == 2) r = r + 1;
                if (Dice5Value == 2) r = r + 1;

                return r;
            }

            int HowManyThrees() {
                int r = 0;

                if (Dice1Value == 3) r = r + 1;
                if (Dice2Value == 3) r = r + 1;
                if (Dice3Value == 3) r = r + 1;
                if (Dice4Value == 3) r = r + 1;
                if (Dice5Value == 3) r = r + 1;

                return r;
            }

            int HowManyFours() {
                int r = 0;

                if (Dice1Value == 4) r = r + 1;
                if (Dice2Value == 4) r = r + 1;
                if (Dice3Value == 4) r = r + 1;
                if (Dice4Value == 4) r = r + 1;
                if (Dice5Value == 4) r = r + 1;

                return r;
            }
        }
    }
}
