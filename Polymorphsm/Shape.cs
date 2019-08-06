using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsm
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Base class is drawing");
        }
    }
}
