using System;

namespace RecursionPapers
{
    public static class RecursionOnArrays
    {
        /// <summary>
        /// Prints the elements of the array (in descending index order)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="arrLength">The length of the array</param>
        public static void Ex1(int[] a, int arrLength)
        {
            Console.Write(a[arrLength - 1] + " ");
            if (arrLength - 1 != 0)
            {
                Ex1(a, arrLength - 1);
            }
        }

        /// <summary>
        /// Returns the sum of the array
        /// </summary>
        /// <param name="a"></param>
        /// <param name="arrLength">The length of the array</param>
        /// <returns></returns>
        public static int Ex2(int[] a, int arrLength)
        {
            //on the base case, return the last element
            return (arrLength - 1 == 0) ? a[arrLength - 1] : a[arrLength - 1] + Ex2(a, arrLength - 1);
                                                            //else add the element to the next
        }

        /// <summary>
        /// Returns the maximal number in the array
        /// </summary>
        /// <param name="a"></param>
        /// <param name="arrLength">The length of the array</param>
        /// <returns></returns>
        public static int Ex3(int[] a, int arrLength)
        {
            //on the base case, return the last element
            return (arrLength - 1 == 0) ? a[arrLength - 1] : Math.Max(a[arrLength - 1], Ex3(a, arrLength - 1));
                                                            //else check the current number with the next
        }

        /// <summary>
        /// Returns how many zeroes there are in the array
        /// </summary>
        /// <param name="a"></param>
        /// <param name="arrlength">The length of the array</param>
        /// <returns></returns>
        public static int Ex4(int[] a, int arrlength)
        {
            if (arrlength - 1 == 0) //base case, the end
            {
                return (a[arrlength - 1] == 0) ? 1 : 0; //if the last number is 0, add one to the total of zeroes. else don't add anything
            }
            //add one to sum if the element is 0, else check if the next element is 0
            return (a[arrlength - 1] == 0) ? 1 + Ex4(a, arrlength - 1) : Ex4(a, arrlength - 1);
        }

        /// <summary>
        /// Returns the amount of 3 digit numbers there are in the array
        /// </summary>
        /// <param name="a"></param>
        /// <param name="arrLength">The length of the array</param>
        /// <returns></returns>
        public static int Ex5(int[] a, int arrLength)
        {
            int digits = RecursionOnNumbers.Ex2(a[arrLength - 1]); //the number of digits in the current number
            if (arrLength - 1 == 0) //base case, the end
            {
                return (digits == 3) ? 1 : 0; //add 1 if there are 3 digits
            }
            //add 1 if the element has 3 digits, and check next one. else just check the next element
            return (digits == 3) ? 1 + Ex5(a, arrLength - 1) : Ex5(a, arrLength - 1);
        }
    }
}