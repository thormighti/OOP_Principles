using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Rectangle : Shape
    {
        int breadth;
        int length;
        public Rectangle(int breadth, int length)
        {
            this.breadth = breadth;
            this.length = length;
        }
        public override double Area()
        {
            return length * breadth;
        }
    }
}
