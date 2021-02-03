using System;

namespace Lab11_BlockbusterMovieLab
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockBuster b = new BlockBuster();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Grand Circus BlockBuster!");
                Movie selectedMovie = b.CheckOut();

                Console.Write("Do you want to watch the Movie? y/n: ");
                string userInput = Console.ReadLine().Trim().ToLower();

                if (userInput == "y")
                {
                    selectedMovie.Play();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{selectedMovie.Title} has been returned");
                }
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Would you like to keep looking for movies at BlockBuster? ");
                Console.ResetColor();
                if (Console.ReadLine().Trim().ToLower() != "y")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

            }

        }
    }
}
