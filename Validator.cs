using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab12
{
   public class Validator
    {
        public static string validate(string OpponentChoice)
        {
            

            while (!(Regex.Match(OpponentChoice, "^j$|^s$", RegexOptions.IgnoreCase).Success))
            {
                Console.WriteLine("Enter  valid choice");
                OpponentChoice = Console.ReadLine();
                
                
            }
             return OpponentChoice;


        } 
        public static string validatechoice(string choice)
        {
            while (!(Regex.Match(choice, "^rock$|^scissors$|^paper$", RegexOptions.IgnoreCase).Success))
            {
                Console.WriteLine("Enter  valid choice");
                choice = Console.ReadLine();


            }
            return choice;


        }


    }
}
