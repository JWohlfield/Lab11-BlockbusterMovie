using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_BlockbusterMovieLab
{
    class BlockBuster
    {
        public List<Movie> Movies { get; set; }
        public List<string> Scenes = new List<string>() { "Opening scene", "Build up scene", "Intensifying scene", "Climax scene", "Final Scene" };

        public BlockBuster()
        {
            Movies = new List<Movie>();
            Movie m1 = new DVD("The Godfather", 200, Genre.Drama, new List<string>() 
            {"Meet the Undertaker", "Here's Johnny","Michael pops caps", "Five families","Another wedding", "Vegas", "New Era" });
            Movie m2 = new VHS("The Texas Chainsaw Massacre", 118, Genre.Horror, new List<string>() 
            {"Sombody dies","There's been another senseless death","Go in the house and you get killed","That basement must really stink","Hide and he'll find & kill you" });
            Movie m3 = new DVD("The Shawshank Redemption", 140, Genre.Drama, new List<string>() 
            { "Fresh Fish","In the Yard","Parole Rejection","The Sisters", "Tar the Roof","On the Outside","The Breakout","No Rejection", "Justice Cometh","Reunited"});
            Movie m4 = new DVD("There's Something about Mary", 112, Genre.Comedy, Scenes);
            Movie m5 = new VHS("Braveheart", 165, Genre.Drama, Scenes);
            Movie m6 = new VHS("The Notebook", 120, Genre.Romance, Scenes);
            Movie m7 = new VHS("First Blood", 115, Genre.Action, new List<string>() 
            {"The Drifter", "Office Mayhem", "On the Run", "Don't go in the Woods", "CaveMan","Meanwhile, Back in Town"});
            Movie m8 = new DVD("Titanic", 162, Genre.Romance, new List<string>() 
            {"A Game of Chance","All Aboard!","Set Sail!","Don't Jump","A Day in the Life","Below Deck","Ice Anyone?","Mad Scramble","Time for a Swim","Reflection" });
            Movies.Add(m1);
            Movies.Add(m2);
            Movies.Add(m3);
            Movies.Add(m4);
            Movies.Add(m5);
            Movies.Add(m6);
            Movies.Add(m7);
            Movies.Add(m8);
        }

        public void PrintMovies()
        {
            int i = 0;
            foreach (Movie m in Movies)
            {
                Console.WriteLine($"{i} {m.Title}");
                i++;
            }
        }

        public Movie CheckOut()
        {
            int movieIndex = -1;
            PrintMovies();
            while (movieIndex == -1)
            {
                try
                {
                    Console.Write("Select a movie? ");

                    movieIndex = int.Parse(Console.ReadLine());

                    Movies[movieIndex].PrintInfo();
                }
                catch
                {
                    Console.WriteLine("Invalid Selection.\nPlease try again");
                }
            }

            return Movies[movieIndex];
           
        }
    }
}
