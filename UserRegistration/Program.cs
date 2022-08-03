﻿using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the  FirstName :");
            string firstName = Console.ReadLine();
            if (RegistrationPattern.ValidetingFirstName(firstName))
                Console.WriteLine("First Name is VALID !");
            else
                Console.WriteLine("First Name is INVALID !");

            Console.WriteLine("Enter LastName :");
            string LastName = Console.ReadLine();
            if (RegistrationPattern.ValidetingLastName(LastName))
                Console.WriteLine("LastName is VALID !");
            else
                Console.WriteLine("LastName is INVALID !");

            Console.WriteLine("Enter email :");
            string Email = Console.ReadLine();
            if (RegistrationPattern.ValidetingEmailAddress(Email))
                Console.WriteLine("email is VALID !");
            else
                Console.WriteLine("email is INVALID !");

            Console.WriteLine("Enter MobileNumber :");
            string MobileNumber = Console.ReadLine();
            if (RegistrationPattern.ValidetingMobileFormat(MobileNumber))
                Console.WriteLine("MobileNumber is VALID !");
            else
                Console.WriteLine("MobileNumber is INVALID !");
        }
    }

}
