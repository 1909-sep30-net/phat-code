using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DelegateApp
{
    public class MoviePlayer
    {
        public string CurrentMovie { get; set; }
        //event are entities that work on a publish-subcribe idea
        //C# lets us subcribe event handler delegates to event

        //define delegate for handling event
        public delegate void MovieFinishHandler();
        //for void-return and zero params
        //describes the shape of function that can subcribes to this event

        public event MovieFinishHandler MovieFinished;

        public void PlayMovie()
        {
            Console.WriteLine($"Play movie {CurrentMovie}");
            Thread.Sleep(3000);

            //Fire event
            MovieFinished?.Invoke();
        }
    }
}
