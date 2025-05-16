using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba11
{
    public class Rhombus : Parallelogram
    {
        public Rhombus(double side, double angle) : base(side, side, angle) { }

        public override string Name => "Rhombus";

        public override object Clone()
        {
            return new Rhombus(SideA, Angle);
        }
    }

}
