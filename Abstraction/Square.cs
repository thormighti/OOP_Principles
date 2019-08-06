using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Square:Shape
    {
        int side;
        public Square(int side)
        {
            this.side = side;
        }
        public override double Area()
        {
            return Math.Pow(side, 2.0);
        }
    }
}
