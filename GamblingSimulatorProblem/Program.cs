using System;

namespace GamblingSimulatorProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambling Simulator Problem!");
            Gambling gambling = new Gambling();
            gambling.GetBetWinOrLoose();
        }
    }
}
