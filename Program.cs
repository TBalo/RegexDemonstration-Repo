using System;
using System.Net;
using System.Text.RegularExpressions;
using RegexDemonstration;

namespace SimpleWebScraper
{
    public class Program
    {
        static void Main(string[] args)
        {
            RegexValidation regex = new RegexValidation();
            bool validFirstName = regex.validateFirstName();
            bool validID = regex.validateID();
            bool validMobileNumber = regex.validateMobileNumber();
            bool validEmail = regex.validateEmail();
            bool validPassword = regex.validatePassword();


            Console.WriteLine("Name: " + validFirstName);

            Console.WriteLine("Mobile: " + validMobileNumber);

            Console.WriteLine("ID: " + validID);

            Console.WriteLine("Email: " + validEmail);

            Console.WriteLine("Password: " + validPassword);

        }
    }
}