using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Query
{
    class Problem2
    {
        List<string> listOfStings = new List<string>() { "90,100,82,89,55", "100,100,100,90,65", "100,80,100,100,85" };
        List<double> listOfAverages = new List<double>();


        private string[] ParseString(string grades)
        {
                string[] arrayOfStringGrades = grades.Split(',');
            
            return arrayOfStringGrades;
        }

        private List<double> ConvertFromStringToDoubleAndRemoveMinimum(string grades)
        {
            var listOfDoubleGrades = ParseString(grades).Select(x => ToDouble(x)).ToList();
            listOfDoubleGrades.Remove(listOfDoubleGrades.Min());
            return listOfDoubleGrades; 
        }

        private void AddToListOfAverages()
        {
            foreach (string grades in listOfStings)
            {
                    listOfAverages.Add(ConvertFromStringToDoubleAndRemoveMinimum(grades).Average());
            }
        }
              
        public void DisplayResults()
        {
            AddToListOfAverages();
            Console.WriteLine("\nProblem 2");
            Console.WriteLine("---------\n");
            foreach (double avg in listOfAverages)
                {
                    Console.WriteLine($"Average of each string: {avg:0.0}");
                }

                Console.WriteLine($"\nTotal average: {listOfAverages.Average():0.0}");
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
