using System;

namespace Packt.Shared
{
    public class Singer
    {
        // virtual keyword allows this method to be overridden
        public virtual void Sing()
        {
            Console.WriteLine("Singing...");
        }
    }

    public class LadyGaga : Singer
    {
        //sealed prevents overriding the method in subclasses
        public sealed override void Sing()
        {
            Console.WriteLine("Singing in a Lady Gaga way...");
        }
    }
}