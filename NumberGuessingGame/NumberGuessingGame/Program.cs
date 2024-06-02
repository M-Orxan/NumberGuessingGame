using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Define the range");
            Console.WriteLine();



            string minimumValueInput= EnterValuesForDefiningRange("Enter the minimum value:");
            int minimumValue= ConvertUserInputToInteger(minimumValueInput);
            string maximumValueInput = EnterValuesForDefiningRange("Enter the maximum value:");
            int maximumValue = ConvertUserInputToInteger(maximumValueInput);

           
        }


        public static string EnterValuesForDefiningRange(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }

        public static int ConvertUserInputToInteger(string input)
        {
            int number;

            

            while (!int.TryParse(input, out number))
            {
                Console.WriteLine("Wrong input! Please try again:");
                input = Console.ReadLine();
               
            }

            return number;
        }




    }
}
