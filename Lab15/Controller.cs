using System;
using System.Collections.Generic;
using System.IO;

namespace Lab15
{
    class Controller
    {
        public static List<string> ListMaker()
        {
            List<string> listOfCountries = new List<string>();
            string lineList;
            StreamReader countryRead = new StreamReader(@"C: \Users\Grand Circus Student\source\repos\Lab15\ListOfCountries.txt");
            while (true)
            {
                lineList = countryRead.ReadLine();
                if (lineList == null)
                {
                    break;
                }
                listOfCountries.Add(lineList);

            }
            countryRead.Close();
            return listOfCountries;
        }
        public static void ListList(List<string> listOfCountries)
        {
            foreach (string country in listOfCountries)
            {
                Console.WriteLine(country);
            }
        }
        public static void AddToList(List<string> listOfCountries)
        {
            Console.WriteLine("What country would you like to add to the list?");
            string userAdd = Console.ReadLine();
            listOfCountries.Add(userAdd);
            listOfCountries.Sort();
            ListList(listOfCountries);
        }
        public static void RemoveFromList(List<string> listOfCountries)
        {
            Console.WriteLine("What country would you like to remove from the list?");
            string userBoom = Console.ReadLine();
            if (listOfCountries.Contains(userBoom) == false)
            {
                Console.WriteLine("That is not a currently existing country in our database");
                RemoveFromList(listOfCountries);
            }
            else
            {
                listOfCountries.Remove(userBoom);
                listOfCountries.Sort();
                ListList(listOfCountries);
            }
        }
        public static void SaveTxt(List<string> listOfCountries)
        {
            StreamWriter countryWrite = new StreamWriter(@"C: \Users\Grand Circus Student\source\repos\Lab15\ListOfCountries.txt");
            foreach (string country in listOfCountries)
            {
                countryWrite.WriteLine(country);
            }
            countryWrite.Close();
        }
    }
}
