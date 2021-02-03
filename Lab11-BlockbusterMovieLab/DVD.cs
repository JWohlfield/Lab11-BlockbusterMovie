using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_BlockbusterMovieLab
{
    class DVD : Movie
    {
        public DVD(string Title, int RunTime, Genre Category, List<string> Scenes) : base(Title, RunTime, Category, Scenes)
        {
          
        }

        public override void Play()
        {
            Console.WriteLine($"You've picked a DVD.\nWhich scene of { Title } do you want to watch?");
            bool again = true;
            while (again)
            {
                try
                {
                    Console.Write($"Select scene 1 - { Scenes.Count }: ");
                    int sceneIndex = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine($"{Scenes[sceneIndex]}");
                    Console.Write("Would you like to watch another scene? ");
                    again = Console.ReadLine().Trim().ToLower() == "y";
                }
                catch
                {
                    Console.WriteLine("Invalid selection.\nPlease try again!");
                }

            }

        }
    }
}
