using System;

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
            string inputEmail = "elek.viz@exam.com";

            Console.WriteLine(NameFromEmail(inputEmail));
            Console.ReadLine();
        }
        public static string NameFromEmail(string email)
        {
            char[] emailAddress = email.ToCharArray();
            string firstName = string.Empty;
            string lastName = string.Empty;

            //Console.WriteLine(lastName + " " + firstName);
            return email;
        }
    }
}
