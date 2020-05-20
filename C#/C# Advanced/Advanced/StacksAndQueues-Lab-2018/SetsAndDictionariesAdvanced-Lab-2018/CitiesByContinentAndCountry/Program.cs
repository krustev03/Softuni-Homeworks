using System;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> countries = new Dictionary<string, Dictionary<string, List<string>>>(); 

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ");
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!countries.ContainsKey(continent))
                {
                    countries[continent] = new Dictionary<string, List<string>>();
                }

                if (!countries[continent].ContainsKey(country))
                {
                    countries[continent][country] = new List<string>();
                }
                    
                

                countries[continent][country].Add(city);
            }

            foreach (var item in countries)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var country in item.Value)
                {
                    string cities = string.Empty;
                    var citiesArr = country.Value.ToArray();
                    for (int i = 0; i < citiesArr.Length; i++)
                    {
                        if (i == citiesArr.Length - 1)
                        {
                            cities += $"{citiesArr[i]}";
                        }
                        else
                        {
                            cities += $"{citiesArr[i]}, ";
                        }
                    }
                    Console.WriteLine($"  {country.Key} -> {cities}");
                }
            }
        }
    }
}
