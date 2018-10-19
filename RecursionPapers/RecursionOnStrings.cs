using System;

namespace RecursionPapers
{
    public static class RecursionOnStrings
    {
        /// <summary>
        /// Prints the reversed string
        /// </summary>
        /// <param name="s">a given string</param>
        public static void Ex1(string s)
        {
            int length = s.Length;
            if (length == 1) //base case, prints the last character
            {
                Console.Write(s);
            }
            else
            {
                Console.Write(s[length - 1]); //print the last character
                Ex1(s.Remove(length - 1)); //print the next last character
            }
        }

        /// <summary>
        /// Returns the length of the string
        /// </summary>
        /// <param name="s">Given string</param>
        /// <returns></returns>
        public static int Ex2(string s)
        {
            if (s == "") //base case, the end
            {
                return 0;
            }
            else
            {
                string subString = ""; //a substring  for the recursive call(skip the first letter)
                for (int i = 1; i < s.Length; i++) //copying the string without the last letter
                {
                    subString += s[i];
                }

                return 1 + Ex2(subString);
            }
        }

        /// <summary>
        /// Returns the number of times the letter c exists in the given string
        /// </summary>
        /// <param name="s">Given string</param>
        /// <param name="c">Char</param>
        /// <returns></returns>
        public static int Ex3(string s, char c)
        {
            if (s.Length == 1) //base case, the end
            {
                return (s[0] == c) ? 1 : 0;
            }
            else
            {
                string subString = ""; //a substring, for the recursive call (skip the first letter)
                for (int i = 1; i < s.Length; i++)
                {
                    subString += s[i];
                }

                return (s[0] == c) ? 1 + Ex3(subString, c) : Ex3(subString, c); //add 1 if the char is in the string, and check next
            }
        }

        /// <summary>
        /// Returns if true if the given string is palindromic.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool Ex4(string s)
        {
            if (s.Length == 1 || s.Length == 0) //base case, the end (if odd length, it's 1. if even, ends in 0)
            {
                return true;
            }
            else
            {
                string subString = ""; //substring for the recursive call. without the first and last letter
                for (int i = 1; i < s.Length - 1; i++) //entering the values without the first and last letter
                {
                    subString += s[i];
                }
                //check if it is palindromic
                return (s[0] == s[s.Length-1]) ? Ex4(subString) : false;
            }
        }

        /// <summary>
        /// Returns 0 if both strings are of the same length. 1 if s1 is longer. 2 if s2 is longer
        /// </summary>
        /// <param name="s1">A string</param>
        /// <param name="s2">A string</param>
        /// <returns></returns>
        public static int Ex5(string s1, string s2)
        {
            if (s1 == "" && s2 == "") //base case, both of the same length
            {
                return 0;
            }
            else if (s1 == "") //base case, s1 is smaller than s2
            {
                return 2;
            }
            else if (s2 == "") //base case, s2 is smaller than s1
            {
                return 1;
            }
            else
            {
                string s1Sub = "", s2Sub = ""; //two substrings of s1 and s2, skipping the first part
                for (int i = 1; i < s1.Length; i++) //entering s1 into it's substring
                {
                    s1Sub += s1[i];
                }

                for (int i = 1; i < s2.Length; i++) //entering s2 into it's substring
                {
                    s2Sub += s2[i];
                }

                return Ex5(s1Sub, s2Sub); //check for next
            }
        }

        /// <summary>
        /// Checks if all the chars in the even places are numbers
        /// </summary>
        /// <param name="s">A string</param>
        /// <returns></returns>
        public static bool Ex6(string s)
        {
            return Ex6(s, 0);
        }

        /// <summary>
        /// Encapsulated function
        /// </summary>
        /// <param name="s"></param>
        /// <param name="i">Current index</param>
        /// <returns></returns>
        private static bool Ex6(string s, int i)
        {
            if (i >= s.Length) //base case, hadn't returned false until now
            {
                return true;
            }
            //checking if the current index is a digit. and check the next one
            return (s[i] >= 48 && (int)s[i] <= 57) ? Ex6(s, i + 2) : false;
        }
    }
}