using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        private ISweepstakesManager _manager;


        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;

            
        }

        public void CreateSweepstake()
        {
            string name = UserInterface.GetUserInputForSweepStakeName();
            Sweepstakes newSweepstake = new Sweepstakes(name);
            _manager.InsertSweepstakes(newSweepstake);
    
        }

        public Sweepstakes GetSweepstake()
        {
            Sweepstakes chosenSweepstake = _manager.GetSweepstakes();
            return chosenSweepstake;
        }


    }
}
