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
        public Contestant winningContestant;
        public ISweepstakesManager sweepstakesManager;

        public Simulation()
        {
            //Create Firm, manager and add sweepstakes
            CreateMarketingFirmWithManager();
            marketingFirm.CreateSweepstake();

            while (UserInterface.GetUserInputToAddMoreSweepstakes() == "y")
            {
                marketingFirm.CreateSweepstake();
                
            }
            

            //Pull sweepstake from stack or queue
            sweepstakes = marketingFirm.GetSweepstake();

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
            
            winningContestant = sweepstakes.PickWinner();
            Console.WriteLine($"The winner of {sweepstakes.Name} is Registration number {winningContestant.RegistrationNumber}. {winningContestant.FirstName} {winningContestant.LastName}!!!");
            Console.WriteLine("Thanks to everyone who entered!");



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
