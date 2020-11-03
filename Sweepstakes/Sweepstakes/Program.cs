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
            //Create contestants and sweepstakes
            Contestant contestant1 = new Contestant();
            Contestant contestant2 = new Contestant();
            Sweepstakes firstSweepstakes = new Sweepstakes("Monopoly");

            //register contestants and print info
            firstSweepstakes.RegisterContestant(contestant1);
            firstSweepstakes.RegisterContestant(contestant2);
            firstSweepstakes.PrintContestantInfo(contestant1);
            firstSweepstakes.PrintContestantInfo(contestant2);

            //Sweepstakes manager
            SweepstakesQueueManager queue1 = new SweepstakesQueueManager();
            queue1.InsertSweepstakes(firstSweepstakes);
            Sweepstakes contestThisTime = queue1.GetSweepstakes();
            Console.WriteLine($"The contest that was chosen this time was {contestThisTime.Name}!");


            Console.ReadLine();
        }
    }
}
