using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.ListVariaties
{
    internal class ListNullables
    {
        public ListNullables()
        {
            ListNullablesMethof();
        }

        private void ListNullablesMethof()
        {
            // You can not convert null to int because its non-nullable value type
            //int age = null; 

            int? age = null; // int? is a nullable int => its able to be null
            int myAge = 35;

            if (age.HasValue)
            {
                Console.WriteLine("Age is: " + age.Value);
                int sum = age.Value + myAge;
            }
            else
            {
                Console.WriteLine("Age is not specified!" + age);
            }

            //Console.WriteLine("Hello from ListNullables Class!");
        }
      
    }
}

// Usage Nullable types
// Database Interaction: Database fields may return null if they are not set,
// Nullable types are perfect for handling such cases
// Prevents runtime erros that can occur when dealing with types that may not have values
// Makes it clear in your code that a variable might not always have a value
