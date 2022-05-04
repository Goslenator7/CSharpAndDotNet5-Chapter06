using System;

namespace Packt.Shared
{
    /* Struct types:
         Numbers:           byte, sbyte, short, ushort, int, uint, long, ulong, float, double, decimal
         Miscellaneous:     char, DateTime, bool
         System.Drawing:    Color, Point, Rectangle

    Almost all other types are class types!

    Structs are stored in the stack memory (small but fast)
    You cannot inherit from a struct */

    public struct DisplacementVector
    {
        public int X;
        public int Y;

        public DisplacementVector(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
        }

        public static DisplacementVector operator +(
            DisplacementVector vector1,
            DisplacementVector vector2)
        {
            return new DisplacementVector(vector1.X + vector2.X, vector1.Y + vector2.Y);
        }
    }
}