using System;
using System.Globalization;

namespace ProjectNameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes an email address as input in the following format: firstName.lastName@exam.com
            //and returns a string that represents the user name in the following format: lastName firstName
            //example: "elek.viz@exam.com" for this input the output should be: "Viz Elek"
            //accents does not matter 

            Console.WriteLine(NameFromEmail("elek.viz@exam.com"));
            Console.ReadLine();
        }
        public static string NameFromEmail(string email)
        {
            string unifiedEmail = email.Replace('.', ' ').Replace('@', ' ');
            string[] splittedEmail = unifiedEmail.Split(' ');
            string firstName = splittedEmail[0];
            string lastName = splittedEmail[1];

            return lastName + " " + firstName;
        }
    }
}
