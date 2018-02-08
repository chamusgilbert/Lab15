using System;
using System.Collections.Generic;

namespace Lab15
{
    class view
    {
        public static void UserMenu(List<string> listOfCountries)
        {
            Console.WriteLine("Welcome to Earth");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. See a list of Countries");
            Console.WriteLine("2. Add to the list of Countries");
            Console.WriteLine("3. Save and quit");
            Console.WriteLine("4. Quit without saving");
            bool menuOptionWorks = int.TryParse(Console.ReadLine(), out int userOption);
            if (menuOptionWorks == false || userOption > 4 || userOption < 1)
            {
                Console.WriteLine("That is not a valid menu option");
                UserMenu(listOfCountries);
            }
            else
            {
                if (userOption == 1)
                {
                    Controller.ListList(listOfCountries);
                    UserMenu(listOfCountries);
                }
                else if (userOption == 2)
                {
                    Controller.AddToList(listOfCountries);
                    UserMenu(listOfCountries);
                }
                else if (userOption == 3)
                {
                    Controller.SaveTxt(listOfCountries);
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    Console.WriteLine("Goodbye");
                }
            }
        }
    }
}
