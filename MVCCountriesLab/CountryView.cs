using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }


        public void Display()
        {
            Console.WriteLine($"Country name: {DisplayCountry.Name}");
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            Console.WriteLine($"Colors: {DisplayCountry.Colors}");
            
        }
    }
}
