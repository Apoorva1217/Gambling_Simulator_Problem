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

        /// <summary>
        /// UC2 win or loose
        /// </summary>
        public void GetBetWinOrLoose()
        {
            Random random = new Random();
            int win = random.Next(0, 2);
            if (win == 1)
                startstake += 1;

            else
                startstake -= 1;
        }

    }
}
