using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Felidae fela = new Felidae();
            Type t = typeof(Felidae);
            
            Lion simba = new Lion("peter",56);
            simba.Male = "Simba";
            AfricanLion mustafa = new AfricanLion("Mustafa", 56);
            mustafa.Roar();
          
           simba.Roar();
            Console.WriteLine(new object());
            Console.WriteLine(new bool());
            Console.WriteLine(new Lion("mm",67));
            Console.WriteLine(new AfricanLion("Mufasa",50));
            Console.ReadKey();

        }
    }
}
