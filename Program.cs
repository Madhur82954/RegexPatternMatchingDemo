using System;
using System.Text.RegularExpressions;
namespace RegexPatternMatchingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter FirstName : ");
            string Firstname=Console.ReadLine();

            Console.WriteLine("Enter LastName : ");
            string Lastname = Console.ReadLine();

            Console.WriteLine("Enter PhoneNo : ");
            string Phoneno = Console.ReadLine();

            Console.WriteLine("Enter Email : ");
            string Email = Console.ReadLine();

            Console.WriteLine("Enter Password : ");
            string Password = Console.ReadLine();

            string Firstnamepattern="^[A-Z]{1}[a-z]{2,}$";
            string Lastnamepattern = "^[A-Z]{1}[a-z]{2,}$";
            string Emailpattern =  "^[0-9a-zA-Z]+[.+_-]{0,2}[0-9a-zA-Z]+[@][0-9a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
            string Phonenopattern = "^[0-9]{2,}[ ][0-9]{10}$";
            string Passwordpattern = ("^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[a-z])(?=.*?[#?!@$%^&*-]).{8,}$");

            bool isvalidFirstName = Regex.IsMatch(Firstname, Firstnamepattern);
            bool isvalidLastName = Regex.IsMatch(Lastname, Lastnamepattern);
            bool isvalidPhoneNo = Regex.IsMatch(Phoneno, Phonenopattern);
            bool isvalidEmail = Regex.IsMatch(Email, Emailpattern);
            bool isvalidPassword = Regex.IsMatch(Password, Passwordpattern);

            if (isvalidFirstName)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid");
                Console.ResetColor();
            }
            if (isvalidLastName)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid");
                Console.ResetColor();
            }
            if (isvalidPhoneNo)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid");
                Console.ResetColor();
            }
            if (isvalidEmail)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid");
                Console.ResetColor();
            }
            if (isvalidPassword)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid");
                Console.ResetColor();
            }
        }
    }
}
