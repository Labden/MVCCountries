using System;

namespace MVCCountriesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController cc = new CountryController();
            string getContinue = null;
            do
            {
                cc.WelcomeAction();

                Console.WriteLine("Would you like to learn about another country?(y/n)");
                getContinue = Console.ReadLine().ToLower().Trim();

            } while (getContinue == "y");
        }
    }
}
