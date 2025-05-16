using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba11
{
    public class Parallelogram : IFigure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double Angle { get; }

        public Parallelogram(double sideA, double sideB, double angle)
        {
            if (sideA <= 0 || sideB <= 0)
                throw new ArgumentException("Sides must be positive");
            if (angle <= 0 || angle >= 180)
                throw new ArgumentException("Angle must be between 0 and 180 degrees");

            SideA = sideA;
            SideB = sideB;
            Angle = angle;
        }

        public virtual string Name => "Parallelogram";
        public double Area() => SideA * SideB * Math.Sin(Angle * Math.PI / 180);
        public double Perimeter() => 2 * (SideA + SideB);
        public virtual object Clone() => new Parallelogram(SideA, SideB, Angle);
        public virtual int CompareTo(IFigure other)
        {
            if (other == null)
                return 1;
            return Area().CompareTo(other.Area());
        }

        public override string ToString() => $"{Name} | Area: {Area():F2} | Perimeter: {Perimeter():F2}";
    }
}
