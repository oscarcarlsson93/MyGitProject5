using System;
using System.Collections.Generic;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstSolution();
            string response = InputFromUser();

            string[] names = CreateArrayOfPeople(response);

            //string cleaned = CleanUpArray(names); Här tog jag bort din cleaned och skickar med 'names' istället
            CleanUpArray(names);


            //ViewToUser(cleaned); Samma här
            ViewToUser(names);


            Console.WriteLine();
            Console.ResetColor();
        }

        private static string CleanUpArray(string[] list)
        {
            List<string> x = new List<string>();
            foreach (var element in list)
            {
                var cleanedElement = element.Trim();
                x.Add(cleanedElement); //Här hade du glömt semikolon 
            }
            return x.ToString();
        }

        private static string InputFromUser()
        {

            Console.Write("Enter seperate names by coma: ");
            string input = Console.ReadLine();

            return input;

        }

        private static string[] CreateArrayOfPeople(string ccc)
        {
            string[] names = ccc.Split(',');

            return names;
        }

        private static void ViewToUser(string[] names)
        {
            Console.WriteLine();
            foreach (var name in names)
            {
                string clean = name.Trim();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"***SUPER-{clean.ToUpper()}***");
            }
        }




        private static void FirstSolution()
        {

            Console.Write("Enter seperate names by coma: ");
            string input = Console.ReadLine();

            Console.WriteLine();

            string[] name = input.Split(',');

            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var namn in name)
            {
                string upper = namn.ToUpper();
                string clean = upper.Trim();
                Console.WriteLine($"***SUPER-{clean}***");
            }
            Console.WriteLine();
            Console.ResetColor();
            }
        }
    }
}
