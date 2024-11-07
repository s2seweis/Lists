using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.ListVariaties
{
    internal class ListSortFindAll
    {
        public ListSortFindAll()
        {
            ListTwoMethod();
        }

        private void ListTwoMethod()
        {
            List<int> numbers = new List<int> { 10, 5, 15, 3, 9, 25,18 };


            Console.WriteLine("Unsorted List:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Sort the List
            numbers.Sort();


            Console.WriteLine("Sorted List:");

            foreach (int number in numbers)
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



            //Console.WriteLine("Hello from ListTwo class!");
        }
    }
}
