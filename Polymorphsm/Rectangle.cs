using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsm
{
    class Rectangle: Shape
    {
        public sealed override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
          //  base.Draw();
        }

    }
}
