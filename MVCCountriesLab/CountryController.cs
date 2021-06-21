using System;
using System.Collections.Generic;

namespace MVCCountriesLab
{
    class CountryController
    {
        public List<Country> CountryDB { get; set; }

        public CountryController()
        {
            List<string> usaColors = new List<string>() { "red", "white", "blue" };
            CountryDB.Add(new Country() { Name = "USA", Continent = "North America" , Colors = usaColors });

            List<string> canadaColors = new List<string>() { "red", "white" };
            CountryDB.Add(new Country() { Name = "Canada", Continent = "North America", Colors = canadaColors });

            List<string> swedenColors = new List<string>() { "blue", "yellow" };
            CountryDB.Add(new Country() { Name = "USA", Continent = "North America", Colors = swedenColors });

        }
        public void CountryAction(Country c)
        {

            CountryView cv = new CountryView(c);
            cv.Display();
        }

        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDB);

            Console.WriteLine("Hello, welcome to the country app.");
            Console.WriteLine("Please select a country, from the following list, by index:");

            clv.Display();
            int userSelect = Int32.Parse(Console.ReadLine());

            CountryAction(CountryDB[userSelect]);

            Console.WriteLine("Would you like to learn about another country? (y/n)");

        }

        
    }
}
