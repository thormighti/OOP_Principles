using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsm
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = new List<Shape>
            {
                new Rectangle(),
            new Square()

            };
            foreach(var shapes in shape)
            {
                shapes.Draw();
            }
            Console.ReadKey();
        }
    }
}
