using System.Collections.Generic;
using System;

namespace Lists.ListVariaties
{
    internal class ListAddRemove
    {
        public ListAddRemove()
        {
            // Call the method to handle list operations
            ManageColorsList();
        }

        private void ManageColorsList()
        {
            // Create a new list of strings
            List<string> colors = new List<string>
                {
                    "red",
                    "blue",
                    "green"
                };

            //List<string> colors = new List<string>();

            //colors.Add("red");
            //colors.Add("green");
            //colors.Add("blue");

            // Remove color from the list
            bool isDeletingSuccessful = colors.Remove("red");
            while (isDeletingSuccessful)
            {
                isDeletingSuccessful = colors.Remove("red");
            }

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
