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
            int randomWinner = randomNum.Next(0, contestants.Count);
            

            return winnerPot[randomWinner];
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("////////////////////////////////////");
            Console.WriteLine();
            Console.WriteLine($"First Name: {contestant.FirstName}");
            Console.WriteLine($"Last Name: {contestant.LastName}");
            Console.WriteLine($"Email Address: {contestant.EmailAddress}");
            Console.WriteLine($"Registration Number: {contestant.RegistrationNumber}");
            Console.WriteLine();
            Console.WriteLine("/////////////////////////////////////");
        }




    }
}
