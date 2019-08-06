using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsm
{
    class SemiRectangle : Rectangle
    {
        public override bool Draw()  // stops further inheriting cause it was sealed
        {
            
        }
    }
}
