using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class CountryListView
    {
        public List<Country> Countries { get; set; } = new List<Country>();

        //The view takes in models to display their data 
        //And sometimes to allow the user to alter/select a specific model
        public CountryListView(List<Country> Countries)
        {
            this.Countries = Countries;
        }

        public void Display()
        {


            for (int i = 0; i < Countries.Count; i++)
            {
                Country c = Countries[i];
                Console.WriteLine($"{i}: {c.Name}");
            }

        }
    }
}
