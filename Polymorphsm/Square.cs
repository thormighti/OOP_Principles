using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsm
{
    class Square: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing a Square");
            base.Draw();
        }
    }
}
