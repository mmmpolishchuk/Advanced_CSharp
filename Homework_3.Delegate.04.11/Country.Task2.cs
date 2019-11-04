using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_3.Delegate._04._11
{
    delegate void CountryDelegates();
    public static class Country
    {
        public static void ShowPopulation()
        {
            Console.WriteLine("\tThe population of the Great Braitain is 66 million inhabitats.");
        }
        public static void ShowCapital()
        {
            Console.WriteLine("\tLondon is the capital of Great Britain :) ");
        }
        public static void ShowQueen()
        {
            Console.WriteLine("\tElizabeth 2 - Queen of Great Britain.");
        }

        public static void DelegatesCombined()
        {
            CountryDelegates coutryPopulation = ShowPopulation;
            CountryDelegates countryCapital = ShowCapital;
            CountryDelegates countryQueen = ShowQueen;
            CountryDelegates countryInfo = coutryPopulation + countryCapital + countryQueen;

            Console.WriteLine("1+2+3");
            countryInfo();

            Console.WriteLine("1+2");
            CountryDelegates countryInfoOneTwo = coutryPopulation + countryCapital;
            countryInfoOneTwo();

            Console.WriteLine("1+2, another method");
            countryInfoOneTwo = countryInfo - countryQueen;
            countryInfoOneTwo();

            Console.WriteLine("1+2, and try to subtract 3");
            countryInfo = countryInfoOneTwo - countryQueen;
            countryInfo();

            Console.WriteLine("(1+3) and (1+2");
            CountryDelegates countryInfoOneThree = coutryPopulation + countryQueen;
            CountryDelegates countryInfoCombine = countryInfoOneThree + countryInfoOneTwo;
            countryInfoCombine();
        }

    }
}
