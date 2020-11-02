using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int RegistrationNumber { get; set; }

        public string testName;


        public Contestant()
        {
            FirstName = UserInterface.GetUserInputForFirstName();
            LastName = UserInterface.GetUserInputForLastName();
            EmailAddress = UserInterface.GetUserInputForEmailAddress();
            RegistrationNumber = UserInterface.GetUserInputForRegistrationNumber();
        }



    }

  
}
