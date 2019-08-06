using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(4, 5);
          //  int result = rec.Area();
            Square sq = new Square(7);
            double res = sq.Area();
            Console.WriteLine($"the area of the square is {res}");
            Console.ReadKey();
        }
    }
}
