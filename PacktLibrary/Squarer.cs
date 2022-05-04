using System;
using System.Threading;

namespace Packt.Shared
{
    public static class Squarer // class is non-generic
    {
        public static double Square<T>(T input) where T : IConvertible // This method IS generic however
        {
            // convert using the current culture (no idea what this means)
            double d = input.ToDouble(Thread.CurrentThread.CurrentCulture);

            return d * d;
        }
    }
}