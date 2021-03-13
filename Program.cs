using System;
using System.Collections.Generic;
using System.Linq;

namespace QueryGenericListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
           //populate a list of strings
           var items = new List<string>();
            items.Add("AQua"); //add "aQua" to the end of the list
            items.Add("RusT"); //add "RusT" to the end of the list
            items.Add("yElLow"); // add "yElLow" to the end of the List 
            items.Add("rEd"); //add "rEd" to the end of the list 

            //display initial List
            Console.WriteLine("items contains:");
            foreach (var item in items)
            {
                Console.WriteLine(item); 
            }

            Console.WriteLine(); //output end of line

            //convert to uppercase, select those starting with "R" and sort
            var startsWithR =
                from item in items
                let uppercaseString = item.ToUpper()
                where uppercaseString.StartsWith("R")
                orderby uppercaseString
                select uppercaseString;

            //display query results
            Console.WriteLine("results of query startsWithR");
            foreach (var item in startsWithR)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();// output end of the line

           items.Add("rUby");
           items.Add("SaFfRon");

           //display initial List
           Console.WriteLine("items contains");
           foreach (var item in items)
           {
               Console.WriteLine(item);
           }

           Console.WriteLine(); //output end of line
            
           //display updated query results
           Console.WriteLine("results of query startsWithR");
           foreach (var item in startsWithR)
           {
               Console.WriteLine(item);
           }

           Console.WriteLine(); //output end of the line
        }
    }
}
