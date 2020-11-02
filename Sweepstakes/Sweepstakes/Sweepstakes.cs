using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sweepstakes
{
    class Sweepstakes
    {

        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Sweepstakes(string name)
        {
            Name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {

            contestants.Add(contestant.RegistrationNumber, contestant);


        }

        public Contestant PickWinner()
        {
            List<Contestant> winnerPot = new List<Contestant>();
            foreach (var person in contestants)
            {
                winnerPot.Add(person.Value);
            }

            Random randomNum = new Random();
            int randomWinner = randomNum.Next(0, contestants.Count - 1);
            

            return winnerPot[randomWinner];
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }




    }
}
