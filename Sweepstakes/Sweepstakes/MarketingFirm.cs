﻿using System;
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

        public Sweepstakes CreateSweepstake()
        {
            string name = UserInterface.GetUserInputForSweepStakeName();
            Sweepstakes newSweepstake = new Sweepstakes(name);
            return newSweepstake;
        }

       
    }
}
