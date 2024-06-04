using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // bool playAgain = true;

            do
            {
                Console.WriteLine("Define the range\n");
                int minimumValue = GetValidInteger("Enter the minimum value:");

                int maximumValue = GetValidInteger("Enter the maximum value:");

                while (minimumValue > maximumValue)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Minimum value can not be greater than maximum value");
                    Console.ResetColor();
                    maximumValue = GetValidInteger("Enter the maximum value:");
                   
                }

                int chances = GetValidInteger("How many chances you want to have");

                while (chances <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Chances must be greater than 0");
                    Console.ResetColor();
                    chances = GetValidInteger("How many chances you want to have");
                  
                }

                Console.WriteLine($"Range : {minimumValue} - {maximumValue} / You have {chances} chances");

                Random random = new Random();
                int randomNumber = random.Next(minimumValue, maximumValue + 1);


                int guess = GetValidInteger("Enter your guess:");


                do
                {
                    if (randomNumber > guess)
                    {
                        chances--;
                        if (chances == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine($"You lost. The number is {randomNumber}");
                            Console.ResetColor();
                        }
                        else
                        {
                            
                            guess = GetValidInteger($"Wrong. {chances} chances remained. Enter higher number:");
                            
                        }

                    }
                    else if (randomNumber < guess)
                    {
                        chances--;
                        if (chances == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine($"You lost. The number is {randomNumber}");
                            Console.ResetColor();
                        }
                        else
                        {

                            guess = GetValidInteger($"Wrong. {chances} chances remained. Enter lower number:");
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Congratulations. You found the right number!");
                        Console.ResetColor();
                        break;
                    }
                } while (chances > 0);



            } while (AskPlayAgain());






        }


        public static int GetValidInteger(string message)
        {
            int number;
            Console.WriteLine(message);
            string input = Console.ReadLine();
            while (!int.TryParse(input, out number))
            {
                Console.WriteLine("Wrong input! Please try again:");
                input = Console.ReadLine();

            }

            return number;
        }









        public static bool AskPlayAgain()
        {
            Console.WriteLine("If you want to plag again, press number 1. Otherwise the program will be terminated");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Thanks for playing!");
                return false;
            }
        }




    }
}
