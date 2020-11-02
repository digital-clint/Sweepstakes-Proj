using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static string GetUserInputForFirstName()
        {
            Console.WriteLine("What is your first name? ");
            string firstName = Console.ReadLine();

            return firstName;
        }

        public static string GetUserInputForLastName()
        {
            Console.WriteLine("What is your last name? ");
            string lastName = Console.ReadLine();

            return lastName;
        }

        public static string GetUserInputForEmailAddress()
        {
            Console.WriteLine("What is your email address? ");
            string emailAddress = Console.ReadLine();
            while (!emailAddress.Contains("@"))
            {
                Console.WriteLine("What is your email address? ");
                emailAddress = Console.ReadLine();
            }

            return emailAddress;
        }

        public static int GetUserInputForRegistrationNumber()
        {
            Random randomNum = new Random();
            int registrationNumber = randomNum.Next(100, 1000);
          

            return registrationNumber;
        }

      


    }
}
