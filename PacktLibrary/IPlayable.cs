using System;

namespace Packt.Shared
{
    public interface IPlayable
    {
        void Play();
        void Pause();

        void Stop() // default interface implementation
        {
            Console.WriteLine("Default implementation of stop");
        }
    }
}
