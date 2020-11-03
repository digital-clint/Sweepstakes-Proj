using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            

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
