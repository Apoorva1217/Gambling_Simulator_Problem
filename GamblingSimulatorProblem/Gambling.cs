using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingSimulatorProblem
{
    class Gambling
    {
        ///UC1 Start Stake and bet
        public const int BET = 1;
        public const int STARTSTAKE = 100;
        public const int DAY = 0;
        public int startstake = STARTSTAKE;
        Random random = new Random();
        int numberOfWins = 0;
        int numberOfLoss = 0;
        int stakeValue = STARTSTAKE * 50 / 100;


        /// <summary>
        /// UC2 win or loose
        /// </summary>
        public void GetBetWinOrLoose()
        {
            int win = random.Next(0, 2);
            if (win == 1)
                startstake += 1;

            else
                startstake -= 1;
        }

        /// <summary>
        /// UC3 if win or loose 50% of stake would resign for day
        /// </summary>
        public void ResignStake()
        {
            for (int i = 0; i < 20; i++)
            {
                while (startstake > (startstake - stakeValue) && (startstake < (startstake + stakeValue)))
                {
                    int win = random.Next(0, 2);
                    if (win == 1)
                    {
                        startstake += 1;
                        numberOfWins++;
                    }
                    else
                    {
                        startstake -= 1;
                        numberOfLoss++;
                    }
                }
                if (numberOfWins > numberOfLoss)
                {
                    numberOfWins++;
                }
                else
                {
                    numberOfLoss++;
                }
                Console.WriteLine("You have done the bet for day:" + startstake);
            }
        }

        /// <summary>
        /// UC4 After 20 days of playing every day would like to know total amount win or loose
        /// </summary>
        public void GetAmountCalculate()
        {
            if (numberOfWins > numberOfLoss)
            {
                int result = numberOfWins * stakeValue;
                Console.WriteLine("Amount won:" + result);
            }
            else
            {
                int result = numberOfLoss * stakeValue;
                Console.WriteLine("Amount loss:" + result);
            }
        }
    }
}
