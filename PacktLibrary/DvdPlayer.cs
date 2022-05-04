using System;

namespace Packt.Shared
{
    public class DvdPlayer : IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("DVD player pausing.");
        }

        public void Play()
        {
            Console.WriteLine("DVD player playing.");
        }

    }
}