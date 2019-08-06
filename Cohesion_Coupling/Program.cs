using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesion_Coupling
{
    class Program
    {
        static void Main(string[] args)
        {
            Report myReport = new Report();
            myReport.LoadFile("peter.txt");
            Looser.PrintFile(myReport);
            Console.ReadKey();
        }
    }
}
