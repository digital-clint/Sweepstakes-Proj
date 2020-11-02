using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestant contestant1 = new Contestant();
            Contestant contestant2 = new Contestant();
            Sweepstakes firstSweepstakes = new Sweepstakes("Monopoly");

            firstSweepstakes.RegisterContestant(contestant1);
            firstSweepstakes.RegisterContestant(contestant2);

            firstSweepstakes.PrintContestantInfo(contestant1);
            firstSweepstakes.PrintContestantInfo(contestant2);

            Console.ReadLine();
        }
    }
}
