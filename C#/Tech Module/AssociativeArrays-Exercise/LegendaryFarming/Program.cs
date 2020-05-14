using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> dicMaterials = new SortedDictionary<string, int>();
            dicMaterials.Add("shards", 0);
            dicMaterials.Add("fragments", 0);
            dicMaterials.Add("motes", 0);
            SortedDictionary<string, int> dicJunk = new SortedDictionary<string, int>();
            bool flEnought = true;
            while (flEnought)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length; i = i + 2)
                {
                    int intQuantity = int.Parse(input[i]);
                    string strMaterial = input[i + 1].ToLower();

                    //junk
                    if (!dicMaterials.ContainsKey(strMaterial))
                    {
                        if (!dicJunk.ContainsKey(strMaterial))
                        {
                            dicJunk.Add(strMaterial, 0);
                        }
                        dicJunk[strMaterial] = dicJunk[strMaterial] + intQuantity;
                    }
                    else
                    {
                        dicMaterials[strMaterial] = dicMaterials[strMaterial] + intQuantity;
                        if (dicMaterials[strMaterial] >= 250)
                        {
                            dicMaterials[strMaterial] = dicMaterials[strMaterial] - 250;
                            switch (strMaterial)
                            {
                                case "shards":
                                    Console.WriteLine("Shadowmourne obtained!");
                                    break;
                                case "fragments":
                                    Console.WriteLine("Valanyr obtained!");
                                    break;
                                case "motes":
                                    Console.WriteLine("Dragonwrath obtained!");
                                    break;
                            }

                            flEnought = false;
                            break;
                        }
                    }
                }
            }
            //print
            var orderMater = dicMaterials.OrderByDescending(x => x.Value);
            foreach (var material in orderMater)
            {
                Console.WriteLine("{0}: {1}", material.Key, material.Value);
            }
            foreach (var junk in dicJunk)
            {
                Console.WriteLine("{0}: {1}", junk.Key, junk.Value);
            }
        }
    }
}
