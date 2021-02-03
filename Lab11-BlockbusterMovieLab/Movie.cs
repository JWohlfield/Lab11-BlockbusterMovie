using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_BlockbusterMovieLab
{
    public enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }
    public abstract class Movie
    {
        public string Title { get; set; }
        public int RunTime { get; set; }
        public Genre Category { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, int RunTime, Genre Category, List<string> Scenes)
        {
            this.Title = Title;
            this.RunTime = RunTime;
            this.Category = Category;
            this.Scenes = Scenes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Category);
            Console.WriteLine(RunTime);
        }

        public void PrintScenes()
        {
            int i = 0;
            foreach (string s in Scenes)
            {
                Console.WriteLine($"{i} {s}");
                i++;
            }
        }

        public abstract void Play();
    }



}
