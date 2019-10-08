using System;

namespace DelegateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var moviePlayer = new MoviePlayer 
            {
                CurrentMovie = "frozen"
            };

            MoviePlayer.MovieFinishHandler handler = PrintMovie;
            moviePlayer.PlayMovie();
            Func<int, int, int> add = (a, b) => a + b; //Lambda Expression 
        }

        static void PrintMovie()
        {
            Console.WriteLine("Movie Finished");
        }
    }
}
