using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba11
{
    public interface IFigure : IComparable<IFigure>, ICloneable
    {
        string Name { get; }
        double Area();
        double Perimeter();
    }
}
