using System;
using System.Text.RegularExpressions;
namespace RegexPatternMatchingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Password : ");
            string name=Console.ReadLine();
            Console.WriteLine(name);
            //string namepattern="^[A-Z]{1}[a-z]{2,}$";
            //string namepattern =  "^[0-9a-zA-Z]+[._-]{0,2}[0-9a-zA-z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
            //string namepattern = "^[0-9]{2,}[ ][0-9]{10}$";
            string namepattern = "[0-9a-zA-Z]{8,}";
            Regex regex = new Regex(namepattern);
            if (regex.IsMatch(name))
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
