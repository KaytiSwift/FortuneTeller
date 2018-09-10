using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{//namespace
    class Program
    {//class
        static void Main(string[] args)
        {//main

            //User interface displays a title then asks the user questions regarding first name, last name, age, birth month, favorite color, and number of siblings
            Console.WriteLine("Fortune Teller");
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your birth month? (Please provide a numeric value 1 - 12)");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your favorite color? (Please select from ROYGBIV. For help, enter \"help\"");
            string color = Console.ReadLine().ToLower();

            if (color == "help")//displays a help menu if the user types in help
            {
                Console.WriteLine("Help Menu");
                Console.WriteLine("R - Red");
                Console.WriteLine("O - Orange");
                Console.WriteLine("Y - Yellow");
                Console.WriteLine("G - Green");
                Console.WriteLine("B - Blue");
                Console.WriteLine("I - Indigo");
                Console.WriteLine("V - Violet");
                Console.WriteLine("What is your favorite color? (Please select from ROYGBIV.)");
                color = (Console.ReadLine().ToLower());
            }
            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());

            string retirement;

            if ((age % 2)== 0)//determines whether the users age is even or odd
            {
                retirement = "10 years";
            }
            else
            {
                retirement = "5 years";
            }

            string vacationHome;

            if (siblings == 0)//determines the users vacation home based on the number of siblings
            {
                vacationHome = "England";
            }
            else if (siblings == 1) 
            {
                vacationHome = "France";
            }
            else if (siblings == 2)
            {
                vacationHome = "Spain";
            }
            else if (siblings == 3)
            {
                vacationHome = "Germany";
            }
            else if (siblings > 3)
            {
                vacationHome = "Ireland";
            }
            else
            {
                vacationHome = "Iraq";
            }

            string transporation;

            switch (color)//determines the mode of transportation based on their favorite color
            {
                case "r":
                    transporation = "bike";
                    break;
                case "o":
                    transporation = "car";
                    break;
                case "y":
                    transporation = "plane";
                    break;
                case "g":
                    transporation = "horse";
                    break;
                case "b":
                    transporation = "camel";
                    break;
                case "i":
                    transporation = "wagon";
                    break;
                default:
                    transporation = "train";
                    break;
            }
            double money;

            //determines how much money the user will have based on their birth month
            if ((birthMonth==1)|| (birthMonth == 2) || (birthMonth == 3) || (birthMonth == 4))
            {
                money = 100.00;
            }
            else if ((birthMonth == 5) || (birthMonth == 6) || (birthMonth == 7) || (birthMonth == 8))
            {
                money = 1000.00;
            }
            else if ((birthMonth == 9) || (birthMonth == 10) || (birthMonth == 11) || (birthMonth == 12))
            {
                money = 10000.00;
            }
            else
            {
                money = 0.00;
            }

            //displays the fortune to the user based on their answers
            Console.WriteLine("{0} {1} will retire in {2} with {3} in the bank, a vacation home in {4}, and a {5}.", firstName, lastName, retirement, money, vacationHome, transporation);

        }//main
    }//class
}//namespace
