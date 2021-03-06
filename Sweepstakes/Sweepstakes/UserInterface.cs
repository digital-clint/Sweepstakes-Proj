﻿using System;
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
            Console.WriteLine($"//////////////////////////////////////////////////");
            Console.WriteLine("*** NEW CONTESTANT FORM ***");
            Console.WriteLine();
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
                Console.WriteLine("Please enter a valid email address? ");
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

        public static string GetUserInputForSweepStakeName()
        {
            Console.WriteLine($"----------------------------------------------------");
            Console.WriteLine("What is the name of your Sweepstake? ");
            string sweepstakeName = Console.ReadLine();

            return sweepstakeName;
        }

        public static string GetUserInputToAddMoreSweepstakes()
        {
            Console.WriteLine($"Would you like to add another sweepstake. Y or N? ");
            string userAnswer = Console.ReadLine();

            while (userAnswer.ToLower() != "y" && userAnswer.ToLower() != "yes" && userAnswer.ToLower() != "n" && userAnswer.ToLower() != "no")
            {
                Console.WriteLine($"Would you like to add another sweepstake? ");
                Console.WriteLine("Please enter yes or no!");
            }

            string userResponseString;

            if (userAnswer.ToLower() == "y" || userAnswer.ToLower() == "yes")
            {
                userResponseString = "y";
            }
            else
            {
                userResponseString = "n";
            }

            return userResponseString;
        }

    }
}
