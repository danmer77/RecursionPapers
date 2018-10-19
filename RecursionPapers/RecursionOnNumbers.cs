using System;

namespace RecursionPapers
{
    public static class RecursionOnNumbers
    {
        /// <summary>
        /// Prints numbers from 0 up to n
        /// </summary>
        /// <param name="n">Positive integer</param>
        public static void Ex1(int n)
        {
            Ex1(n, 0);
        }

        /// <summary>
        /// Encapsulated function, which prints the numbers from 0 up to n
        /// </summary>
        /// <param name="n"></param>
        /// <param name="i">The number we are printing</param>
        private static void Ex1(int n, int i)
        {
            if (i != n) //if it isn't the base case
            {
                Console.Write(i + " "); 
                Ex1(n, i + 1); //the recursive call
            }
            else //base case, the end
            {
                Console.Write(i);
            }
        }

        /// <summary>
        /// Returns the number of digits of the given number
        /// </summary>
        /// <param name="n">Positive integer</param>
        /// <returns></returns>
        public static int Ex2(int n)
        {
            return (n < 10) ? 1 : 1 + Ex2(n / 10);
        }

        /// <summary>
        /// Returns the sum of the digits of the given number
        /// </summary>
        /// <param name="n">Positive integer</param>
        /// <returns></returns>
        public static int Ex3(int n)
        {
            return (n < 10) ? n : n % 10 + Ex3(n / 10);
        }

        /// <summary>
        /// Returns the diff of the digits (not really sure what that means)
        /// </summary>
        /// <param name="n">Positive integer</param>
        /// <returns></returns>
        public static int Ex4(int n)
        {
            return (n < 10) ? n : -(n % 10) + Ex4(n / 10);
        }

        /// <summary>
        /// Returns the largest digit of the given number
        /// </summary>
        /// <param name="n">Positive integer</param>
        /// <returns></returns>
        public static int Ex5(int n)
        {
            return (n < 10) ? n : Math.Max(n % 10, Ex5(n / 10));
        }

        /// <summary>
        /// Returns whether or not the digit (given by the digitInput) is in the number n.
        /// </summary>
        /// <param name="n">Positive number</param>
        /// <param name="digitInput">Digit</param>
        /// <returns></returns>
        public static bool Ex6(int n, int digitInput)
        {
            if (n >= 10) //if not the base case
            {
                return (n % 10 == digitInput) ? true : Ex6(n / 10, digitInput);
            }

            return (n == digitInput);
        }

        /// <summary>
        /// Returns how many times the digit occurred in the number n
        /// </summary>
        /// <param name="n">Positive integer</param>
        /// <param name="digit">Positive integer, single digit</param>
        /// <returns></returns>
        public static int Ex7(int n, int digit)
        {
            if (n < 10) //base case, last digit of the number n
            {
                return (n == digit) ? 1 : 0;
            }
            else //recursive call - if the n%10 = digit, add 1. else don't add one and check next
            {
                return (n % 10 == digit) ? 1 + Ex7(n / 10, digit) : Ex7(n / 10, digit);
            }
        }

        /// <summary>
        /// Returns the lowest common factor (returns 1 if a factor wasn't found)
        /// </summary>
        /// <param name="n1">Positive integer</param>
        /// <param name="n2">Positive integer</param>
        /// <returns></returns>
        public static int Ex8(int n1, int n2)
        {
            return Ex8(n1, n2, 2);
        }

        //The encapsulated function
        private static int Ex8(int n1, int n2, int i)
        {
            if (i == n1) //one base case (we don't know which is minimal)
            {
                return ((n2 % n1) == 0) ? n1 : 1; //check lastly if n1 is a factor
            }
            else if (i == n2) //the other base case
            {
                return ((n1 % n2) == 0) ? n2 : 1; //check lastly if n2 is a factor
            }
            //check if the current i divides both, recursive call to next i.
            return (n1 % i == 0 && n2 % i == 0) ? i : Ex8(n1, n2, i + 1);
        }

        /// <summary>
        /// Prints all of the factors of the given number (in descending order)
        /// </summary>
        /// <param name="n">Positive integer</param>
        public static void Ex9(int n)
        {
            Console.Write(n + " ");
            Ex9(n, (int)Math.Sqrt(n));
        }

        //the encapsulated function
        private static void Ex9(int theNum, int i)
        {
            if (i != 0) //if the number we are currently checking isn't 0 (not base case)
            {
                if(theNum % i == 0) //if the number we are checking divides the input
                    Console.Write(i + " "); //print the number
                Ex9(theNum, i-1); //check next number
            }
        }

        /// <summary>
        /// Returns true if the number is prime
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool Ex10(int n)
        {
            return Ex10(n, (int)Math.Sqrt(n));
        }

        /// <summary>
        /// The encapsulated function
        /// </summary>
        /// <param name="n"></param>
        /// <param name="i">the number we are on, to check if it divides</param>
        /// <returns></returns>
        private static bool Ex10(int n, int i)
        {
            //base case, got to 1, means is prime
            return (i == 1) ? true : ((n % i == 0) ? false : Ex10(n, i - 1));
                                    //if a number divides it, isn't prime. check next
        }
    }
}