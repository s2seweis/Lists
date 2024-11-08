using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Lists.Dictionaries
{
    internal class DictionariesMethods
    {
        public DictionariesMethods()
        {
            DictionariesOneMethod();
        }

        private void DictionariesOneMethod()
        {
            // key - value
            // Declaring and initializing a Dictionary
            //Dictionary<int, string> employees = new Dictionary<int, string>();

            ConcurrentDictionary<int, string> employees = new ConcurrentDictionary<int, string>();


            // Adding Items to a Dictionary
            employees.TryAdd(101, "John Doe");
            employees.TryAdd(102, "Bob Smith");
            employees.TryAdd(103, "Rob Fetcher");
            employees.TryAdd(104, "Paul Striker");
            employees.TryAdd(105, "Robert Durham");

            // access items in a dictionary
            string name = employees[101];
            //Console.WriteLine(name);

            // update data in a dictionary
            employees[102] = "Ywain Lancaster";

            // remove an item from a dictionary
            //employees.Remove(101);

            // To handles duplicates, you can check if an item exists,
            // and you can add it if you want too,
          
            if(!employees.ContainsKey(104))
            {
                employees.TryAdd(104, "Raymond Walter");
            }

            bool added = employees.TryAdd(102, "Richard Martel");
            if (!added)
            {
                Console.WriteLine("Employee with the id of 102 already exists");
            }

            // Otherwise you need to find the id that is still free
            // and add it then there with a while loop

            /*
            int counter = 101;
            while (employees.ContainsKey(counter))
            {
                counter++;
            }
            employees.Add(counter, "Philip Anjour");
            */


            // Item with the same key was already added, results in an error
            //employees.Add(104, "Raymond Walter");

            // Updates the position 104
            //employees[104] = "Rymond Walter";



            // kvp => key value pair => employee
            //foreach(KeyValuePair<int, string> kvp in employees)

            // Iterating over a dictionary
            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }

            //Console.WriteLine("Hello from DictionariesOne class!");
        }
    }
}
