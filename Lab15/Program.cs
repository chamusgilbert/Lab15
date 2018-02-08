using System.Collections.Generic;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfCountries = Controller.ListMaker();
            view.UserMenu(listOfCountries);
        }
    }
}
