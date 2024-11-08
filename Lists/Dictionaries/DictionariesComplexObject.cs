using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

using Lists.Dictionaries;

namespace Lists.Dictionaries
{
    internal class DictionariesComplexObject
    {
        public DictionariesComplexObject()
        {
            DictionariesComplexObjectMethod();
        }

        private void DictionariesComplexObjectMethod()
        {
            // key - value
            // Declaring and initializing a Dictionary
            // Before: ConcurrentDictionary<int, string> employees = new ConcurrentDictionary<int, string>();
            // Iterate through our entire dictionary that now has a complex data type: "Employee" from class Employee as the value
            ConcurrentDictionary<int, Employee> employees = new ConcurrentDictionary<int, Employee>();

            employees.TryAdd(1, new Employee("Richard Sans Terre ", 35, 120000));
            employees.TryAdd(2, new Employee("John Beaufort ", 35, 70000));
            employees.TryAdd(3, new Employee("Henry Bourbon ", 35, 90000));
            employees.TryAdd(4, new Employee("Charles Valois ", 35, 220000));
            
            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.Key} Named: {item.Value.Name}" 
                    + $"earns: {item.Value.Salary}" 
                    + $" and is {item.Value.Age} ");
            }
        }
    }
}

        /*
        In summary, while arrays are suitable for simple, 
        ordered collections that are accessed sequentially, 
        dictionaries provide superior performance 
        and flexibility for accessing data via unique keys, 
        handling sparse data, and performing efficient insertions and deletions. 
        This makes dictionaries especially suited for applications like 
        databases, caching solutions, and any context 
        where quick lookup and data integrity are crucial.
        */