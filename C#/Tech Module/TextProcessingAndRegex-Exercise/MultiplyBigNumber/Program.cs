using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string multiplicand = Console.ReadLine().TrimStart(new char[] { '0' });
            string multiplier = Console.ReadLine().TrimStart(new char[] { '0' });
            if (multiplier.Equals("") || multiplicand.Equals(""))
            {
                Console.WriteLine("0");
                return;
            }
            List<string> products = GetProducts(multiplicand, multiplier);
            products = MakeDigitsEqual(products);
            string sum = SumAllProducts(products, 0).TrimStart(new char[] { '0' });
            Console.WriteLine(sum);
        }

        static List<string> GetProducts(string multiplicand, string multiplier)
        {
            List<string> products = new List<string>();
            int multiplierAsInt = int.Parse(multiplier);

            for (int index = multiplicand.Length - 1, zeroCount = 0; index >= 0; index--, zeroCount++)
            {
                string currentProduct =
                    (int.Parse(multiplicand[index].ToString()) * multiplierAsInt).ToString()
                    + new string('0', zeroCount);
                products.Add(currentProduct);
            }

            return products;
        }

        static List<string> MakeDigitsEqual(List<string> products)
        {
            int numberOfDigits = products[products.Count - 1].Length;

            List<string> temp = new List<string>();

            foreach (string product in products)
            {
                int zeroCount = numberOfDigits - product.Length;
                string concat = new string('0', zeroCount) + product;
                temp.Add(concat);

            }

            products = null;
            products = temp;
            return products;

        }
        static string SumTwoProducts(string firstProduct, string secondProduct)
        {
            StringBuilder sb = new StringBuilder();

            int carry = 0;

            for (int i = firstProduct.Length - 1; i >= 0; i--)
            {
                int sumDigits = int.Parse(firstProduct[i].ToString())
                    + int.Parse(secondProduct[i].ToString()) + carry;
                carry = sumDigits >= 10 ? 1 : 0;
                int remainder = sumDigits % 10;
                sb.Append(remainder);

            }

            sb.Append(carry == 0 ? "" : "1");

            char[] reverseStringBuilder = sb.ToString().ToCharArray();
            Array.Reverse(reverseStringBuilder);
            string summedProducts = new string(reverseStringBuilder);

            return summedProducts;
        }

        static string SumAllProducts(List<string> products, int index)
        {
            if (index == products.Count - 1)
            {
                return products[index];
            }

            string firstProduct = products[index];
            string secondProduct = SumAllProducts(products, index + 1);

            return SumTwoProducts(firstProduct, secondProduct);


        }
    }
    }

