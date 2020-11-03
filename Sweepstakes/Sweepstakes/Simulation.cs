using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public MarketingFirm marketingFirm;
        public Contestant contestant1;
        public Contestant contestant2;
        public Contestant contestant3;
        public Sweepstakes sweepstakes;

        public Simulation()
        {
            //Create Firm, manager and sweepstakes
            CreateMarketingFirmWithManager();
            sweepstakes = marketingFirm.CreateSweepstake();

            //Create contestants, register them and print info
            contestant1 = new Contestant();
            contestant2 = new Contestant();
            contestant3 = new Contestant();
            sweepstakes.RegisterContestant(contestant1);
            sweepstakes.RegisterContestant(contestant2);
            sweepstakes.RegisterContestant(contestant3);
            sweepstakes.PrintContestantInfo(contestant1);
            sweepstakes.PrintContestantInfo(contestant2);
            sweepstakes.PrintContestantInfo(contestant3);

            //Pick random winner
            sweepstakes.PickWinner();
            

        }

        public void CreateMarketingFirmWithManager()
        {
            marketingFirm = new MarketingFirm(GetUserInputForManagerType());
        }

        public ISweepstakesManager GetUserInputForManagerType()
        {
            Console.WriteLine("What type of sweepstakes manager would you like to use.");
            Console.WriteLine("Please enter 1 for StackManager or 2 for QueueManager: ");
            string numText = Console.ReadLine();
            bool isNumValid = int.TryParse(numText, out int num);

            while (!isNumValid || (num != 1 && num != 2))
            {
                Console.WriteLine("Please Enter a valid number!!!.");
                Console.WriteLine("1 for SweepstakesStackManager or 2 for SweepstakesQueueManager: ");
            }

            ISweepstakesManager sweepstakesManager;

            if (num == 1)
            {
                sweepstakesManager = new SweepstakesStackManager();
            }
            else
            {
                sweepstakesManager = new SweepstakesQueueManager();
            }

            return sweepstakesManager;

        }
    }
}
