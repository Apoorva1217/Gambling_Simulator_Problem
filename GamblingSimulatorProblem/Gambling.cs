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
            int stakeValue = STARTSTAKE * 50 / 100;
            while (startstake > (startstake - stakeValue) && (startstake < (startstake + stakeValue)))
            {
                int win = random.Next(0, 2);
                if (win == 1)
                {
                    startstake += 1;
                }
                else
                {
                    startstake -= 1;
                }
            }
            Console.WriteLine("You have done the bet for day:" + startstake);
        }
    }
}
