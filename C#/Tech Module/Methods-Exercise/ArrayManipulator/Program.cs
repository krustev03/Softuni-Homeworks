using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    Console.Write("[");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i != arr.Length - 1)
                        {
                            Console.Write(arr[i] + ", ");
                        }
                        else
                        {
                            Console.WriteLine(arr[i] + "]");
                        }
                    }
                    break;
                }
                if (input.Contains("exchange"))
                {
                    int index = Convert.ToInt32(input.Substring(9, input.Length - 9));
                    if (index >= 0 && index < arr.Length)
                    {
                        Exchange(arr, index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                if (input.Contains("max"))
                {
                    if (input == "max even")
                    {
                        MaxEven(arr);
                    }
                    if (input == "max odd")
                    {
                        MaxOdd(arr);
                    }
                }
                if (input.Contains("min"))
                {
                    if (input == "min even")
                    {
                        MinEven(arr);
                    }
                    if (input == "min odd")
                    {
                        MinOdd(arr);
                    }
                }
                if (input.Contains("first"))
                {
                    int count = Convert.ToInt32(input.Substring(input.IndexOf(" "), input.LastIndexOf(" ") - input.IndexOf(" ")));
                    if (count > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (input.Contains("even"))
                        {
                            FirstEven(arr, count);
                        }
                        if (input.Contains("odd"))
                        {
                            FirstOdd(arr, count);
                        }
                    }
                }
                if (input.Contains("last"))
                {
                    int count = Convert.ToInt32(input.Substring(input.IndexOf(" "), input.LastIndexOf(" ") - input.IndexOf(" ")));
                    if (count > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (input.Contains("even"))
                        {
                            LastEven(arr, count);
                        }
                        if (input.Contains("odd"))
                        {
                            LastOdd(arr, count);
                        }
                    }
                }
            }
        }
        static void Exchange(int[] arr, int index)
        {
            for (int i = 0; i <= index; i++)
            {
                var element = arr[0];
                for (int k = 1; k < arr.Length; k++)
                {
                    arr[k - 1] = arr[k];
                }
                arr[arr.Length - 1] = element;
            }
        }
        static void MaxEven(int[] arr)
        {
            int max = -1;
            int maxIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max <= arr[i] && arr[i] % 2 == 0)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }
            if (maxIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }
        static void MinEven(int[] arr)
        {
            int min = int.MaxValue;
            int minIndex = 1000000;
            for (int i = 0; i < arr.Length; i++)
            {
                if (min >= arr[i] && arr[i] % 2 == 0)
                {
                    min = arr[i];
                    minIndex = i;
                }
            }
            if (minIndex == 1000000)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIndex);
            }
        }
        static void MinOdd(int[] arr)
        {
            int min = int.MaxValue;
            int minIndex = 1000000;
            for (int i = 0; i < arr.Length; i++)
            {
                if (min >= arr[i] && arr[i] % 2 != 0)
                {
                    min = arr[i];
                    minIndex = i;
                }
            }
            if (minIndex == 1000000)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIndex);
            }
        }
        static void MaxOdd(int[] arr)
        {
            int max = -1;
            int maxIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max <= arr[i] && arr[i] % 2 != 0)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }
            if (maxIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }
        static void FirstEven(int[] arr, int count)
        {
            int[] first = new int[count];
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    first[k] = arr[i];
                    k++;
                }
                if (k == count)
                {
                    break;
                }
            }
            if (k == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Array.Resize(ref first, k);
                Console.Write("[");
                for (int i = 0; i < first.Length; i++)
                {
                    if (i != first.Length - 1)
                    {
                        Console.Write(first[i] + ", ");
                    }
                    else
                    {
                        Console.WriteLine(first[i] + "]");
                    }
                }
            }
        }
        static void FirstOdd(int[] arr, int count)
        {
            int[] first = new int[count];
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    first[k] = arr[i];
                    k++;
                }
                if (k == count)
                {
                    break;
                }
            }
            
            if (k == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Array.Resize(ref first, k);
                Console.Write("[");
                for (int i = 0; i < first.Length; i++)
                {
                    if (i != first.Length - 1)
                    {
                        Console.Write(first[i] + ", ");
                    }
                    else
                    {
                        Console.WriteLine(first[i] + "]");
                    }
                }
            }
        }
        static void LastEven(int[] arr, int count)
        {
            int[] first = new int[count];
            int k = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0)
                {
                    first[k] = arr[i];
                    k++;
                }
                if (k == count)
                {
                    break;
                }
            }
            
            if (k == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Array.Resize(ref first, k);
                Console.Write("[");
                for (int i = 0; i < first.Length; i++)
                {
                    if (i != first.Length - 1)
                    {
                        Console.Write(first[i] + ", ");
                    }
                    else
                    {
                        Console.WriteLine(first[i] + "]");
                    }
                }
            }
        }
        static void LastOdd(int[] arr, int count)
        {
            int[] first = new int[count];
            int k = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 != 0)
                {
                    first[k] = arr[i];
                    k++;
                }
                if (k == count)
                {
                    break;
                }
            }
            if (k == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Array.Resize(ref first, k);
                Console.Write("[");
                for (int i = 0; i < first.Length; i++)
                {
                    if (i != first.Length - 1)
                    {
                        Console.Write(first[i] + ", ");
                    }
                    else
                    {
                        Console.WriteLine(first[i] + "]");
                    }
                }
            }
        }
    }
}
