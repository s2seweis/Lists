using System;
using System.Collections.Generic;

namespace Lists.ListVariaties
{
    internal class ListFindAllDelegates
    {
        public ListFindAllDelegates()
        {
            ListThreeMethod();

            int result = Squaring(5);

            Console.WriteLine($"The square of 5 is: {result}");

        }

        private void ListThreeMethod()
        {
            List<int> numbers = new List<int> { 10, 5, 15, 3, 9, 25, 18 };

            numbers.Sort();
          
            /*
             * In C#, a delegate is like a pointer or a reference to a method. 
             * It allows you tp pass methods as arguments to other methods,
             * store them in variables, and call them later.
             * This is useful when you want your code to be flexible and 
             * able to handle different behavious that aren't predetermined.
             */

            // Define the predicate to check if a number is greater then 10
            //Predicate<int> isGreaterThanTen = x => x >= 10;

            Predicate<int> isGreaterThanTen = IsGreaterThenTen;

            List<int> higherTen = numbers.FindAll( isGreaterThanTen );

            Console.WriteLine("Higher Ten List & Sorted:");

            foreach (int number in higherTen)
            {
                Console.WriteLine(number);
            }

            // This will return a list of numbers that are 10 and higher
            List<int> higherEqualTen = numbers.FindAll(x => x >= 10);
            //numbers.FindAll(x => x >= 10);

            Console.WriteLine("Higher or Equal Ten List & Sorted:");

            foreach (int number in higherEqualTen)
            {
                Console.WriteLine(number);
            }
            //Console.WriteLine("Hello from ListThree class!");

        }

        static int Squaring(int num1)
        {
            return num1 * num1;
        }

        public static bool IsGreaterThenTen(int x)
        {
            return x >10;
        }
    }
}

// Lambda Expressions
// 1. A lambda expression consits of 2 Parts
// 2. Expressions or Statement Block

// Parameters are written on the left side of =>
// (this symbol is read a "goes to" or "becomes").
// The expression or action to perform is on the right side. 

// This reads as:
// "Take an input x and turn it into x multiplied by x."
// x => x* x;
