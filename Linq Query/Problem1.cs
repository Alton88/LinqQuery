using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Query
{
    public class Problem1
    {
        private List<string> listOfStrings;

        public Problem1() {
            listOfStrings = new List<string>() { "Hello", "Hello", "World", "!!!", "!!!" };
        }

        public void DisplayResults()
        {
            Console.WriteLine("Problem 1");
            Console.WriteLine("---------\n");

            Console.Write("Original list of strings: ");

            foreach(string value in listOfStrings){
                Console.Write($"{value} ");
            }

            Console.Write("\nNew list of strings without duplicates: ");

            var result = listOfStrings.Distinct();

            foreach (string value in result)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine("\n");
        }
        
}
}
