using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Query
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Problem #1
            //List<string> listOfStrings = new List<string>() { "Hello", "Hello", "World", "!!!", "!!!" };

            //var result = listOfStrings.Distinct();
            //foreach (string value in result)
            //{
            //    Console.Write($"{value} ");
            //}

            //Problem #2
            List<string> listOfStings = new List<string>() { "90,100,82,89,55", "100,100,100,90,65", "100,80,100,100,85" };
            List<double> listOfAverages = new List<double>();

            foreach (string list in listOfStings)
            {
                string[] arrayOfStringGrades = list.Split(',');
                var listOfDoubleGrades = arrayOfStringGrades.Select(x => ToDouble(x)).ToList();
                listOfDoubleGrades.Remove(listOfDoubleGrades.Min());
                listOfAverages.Add(listOfDoubleGrades.Average());
            }

            foreach (double avg in listOfAverages)
            {
                Console.WriteLine($"Each Average: {avg:0.0}");
            }

            Console.WriteLine($"\nTotal Average: {listOfAverages.Average():0.0}");

            Console.Read();
    }
        public static double ToDouble(string s)
        {
            try
            {
                return double.Parse(s);
            }
            catch
            {
            }
            return 0;
        }
    }
}
