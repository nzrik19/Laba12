using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba11
{
    public class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }

        public override string Name => "Square";

        public override object Clone()
        {
            return new Square(SideA);
        }
    }

}
