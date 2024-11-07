using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.ListVariaties
{
    internal class ListArrayList
    {

        public ListArrayList()
        {
            ListArrayListMethod();
        }

        private void ListArrayListMethod()
        {
            // declaring an ArrayList with undefined amount of object
            ArrayList myArrayList1 = new ArrayList();
            // declaring an ArrayList with undefined amount of object
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList1.Add(25);
            myArrayList1.Add("Hello");
            myArrayList1.Add(13.37);
            myArrayList1.Add(13);
            myArrayList1.Add(128);
            myArrayList1.Add(25.3);

            // delete element with specific value from the arraylist
            myArrayList1.Remove(13);

            // delete element at specific position
            myArrayList1.RemoveAt(0);

            double sum = 0;

            Console.WriteLine("String in the ArrayList:");

            foreach (object obj in myArrayList1)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                } else if(obj is double)
                {
                    sum += (double)obj;
                } else if( obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine("Total sum of the items in the ArrayList:");
            Console.WriteLine(sum);

            //Console.WriteLine("Items in the ArrayList:");
            //// Use foreach with var to handle different types
            //foreach (var item in myArrayList1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(myArrayList1.Count);
        }
    }
}
