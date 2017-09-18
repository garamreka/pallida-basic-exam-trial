using System;

namespace NameFromEmail
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
        public static void NameFromEmail (string email)
        {
            char[] emailAddress = email.ToCharArray();
            string firstName = string.Empty;
            string lastName = string.Empty;

            while (emailAddress[i] == ".")
            {
                firstName += email[i];
            }

            for (int i = 0; i < emailAdress.Length; i++)
            {
                if (emailAddress[i] == ".")
            }

            Console.WriteLine(lastName + " " + firstName);
        }
    }
}
