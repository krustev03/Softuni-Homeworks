using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine().ToLower().Trim();
            bool rightFirst = CheckIfPassIs6To10Characters(password);
            bool rightSecond = CheckIfConsistsOnlyLettersAndDigitsAndAtLeast2Digits(password);
            bool rightThird = CheckIfConsistsAtLeast2Digits(password);
            if (rightFirst && rightSecond && rightThird)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (rightFirst == false)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (rightSecond == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (rightThird == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
        static bool CheckIfPassIs6To10Characters(string pass)
        {
            bool right = true;
            if (!(pass.Length >= 6 && pass.Length <= 10))
            {
                right = false;
            }
            return right;
        }
        static bool CheckIfConsistsOnlyLettersAndDigitsAndAtLeast2Digits(string pass)
        {
            bool right = true;
            int[] nums = new int[10];
            char[] letters = new char[26];
            for (int i = 0; i < 10; i++)
            {
                nums[i] = (char)(i + 48); 
            }
            for (int i = 0; i < 26; i++)
            {
                letters[i] = (char)(i + 97);
            }
            char[] elements = pass.ToCharArray();
            for (int i = 0; i < elements.Length; i++)
            {
                int check1 = 0;
                for (int k = 0; k < nums.Length; k++)
                {
                    if ((char)elements[i] == (char)nums[k])
                    {
                        check1 = 1;
                    }
                }
                int check2 = 0;
                for (int k = 0; k < letters.Length; k++)
                {
                    if ((char)elements[i] == (char)letters[k])
                    {
                        check2 = 1;
                    }
                }
                if (check1 == 0 && check2 == 0)
                {
                    right = false;
                }
            }
            return right;
        }
        static bool CheckIfConsistsAtLeast2Digits(string pass)
        {
            bool right = true;
            int[] nums = new int[10];
            for (int i = 0; i < 10; i++)
            {
                nums[i] = (char)(i + 48);
            }
            char[] elements = pass.ToCharArray();
            int count = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                for (int k = 0; k < nums.Length; k++)
                {
                    if (elements[i] == nums[k])
                    {
                        count++;
                    }
                }
            }
            if (count < 2)
            {
                right = false;
            }
            return right;
        }
    }
}
