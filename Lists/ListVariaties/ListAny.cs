using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.ListVariaties
{
    internal class ListAny
    {

        public ListAny()
        {
            ListAnyMethod();
        }

        private void ListAnyMethod()
        {
            Console.WriteLine("Sorted List:");

            List<int> numbers = new List<int> { 10, 5, 15, 3, 9, 25, 18 };

            numbers.Sort();

            // Filter out the numbers greater than 20
            var largeNumbers = numbers.Where(x => x > 10).ToList();

            if (largeNumbers.Any())
            {
                Console.WriteLine("These are the numbers greater than 10:");

                // Display the large numbers in one line
                foreach (var number in largeNumbers)
                {
                    Console.Write(number + " "); // Print each number on the same line
                }
                Console.WriteLine(); // Move to the next line after the numbers are printed
            }
            else
            {
                Console.WriteLine("There are no large numbers in the numbers list.");
            }
        }
    }
}
