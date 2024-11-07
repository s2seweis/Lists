using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lists.ListVariaties; // Import the namespace for ListOne and Index

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Index and call its method
            Index indexList = new Index();

            indexList.IndexMainRun(); // Calling the method from Index class



            // #######################################################

            Console.ReadKey(); // Wait for a key press before closing the application
        }
    }
}
