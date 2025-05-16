using System;

namespace Laba11
{
    public class Rectangle : Parallelogram
    {
        public Rectangle(double length, double width) : base(length, width, 90) { }

        public override string Name => "Rectangle";

        public override object Clone()
        {
            return new Rectangle(SideA, SideB);
        }
    }

}
