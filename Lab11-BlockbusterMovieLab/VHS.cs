using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_BlockbusterMovieLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }
        public VHS(string Title, int RunTime, Genre Category, List<string> Scenes, int CurrentTime = 0) : base(Title, RunTime, Category, Scenes)
        {
            this.CurrentTime = CurrentTime;
        }


        public void Rewind()
        {
            if(CurrentTime > 0)
            {
                Console.Write("Would you like to rewind? ");
                if (Console.ReadLine().Trim().ToString() == "y")
                {
                    Console.WriteLine("Thank you for being kind\nPress any key to continue...");
                    CurrentTime = 0;
                    Console.ReadLine();
                }
            }
        }

        public override void Play()
        {
            Console.WriteLine("You've picked a VHS");
            string userInput = "y";
            while (userInput == "y")
            {
                if (CurrentTime < Scenes.Count)
                {
                    Console.WriteLine(Scenes[CurrentTime]);
                    CurrentTime++;
                }
                else
                {
                    Rewind();
                }

                Console.Write("Would you like to watch another scene? y/n ");
                userInput = Console.ReadLine().Trim().ToLower();
            }
            Rewind();
        }
    }
}
