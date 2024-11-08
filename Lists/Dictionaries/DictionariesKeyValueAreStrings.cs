using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Dictionaries
{
    internal class DictionariesKeyValueAreStrings
    {

        public DictionariesKeyValueAreStrings()
        {
            DictionariesKeyValueAreStringsMethod();
        }

        private void DictionariesKeyValueAreStringsMethod()
        {
            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["LA"] = "Los Angles",
                ["CA"] = "California",
                ["TX"] = "Texas",
            };

            /*
            if(codes.TryGetValue("NY1", out string state))
            {
                Console.WriteLine($"State was found successfully: {state}");
            } else
            {
                Console.WriteLine("State was not found!");
            }
            */

            foreach ( var item in codes )
            {
                Console.WriteLine($"The statecode is {item.Key} and the state name {item.Value}");
            }



            //Console.WriteLine("Hello World from DictionariesKeyValueAreStrings class!");
        }
    }
}
