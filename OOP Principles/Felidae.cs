using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    class Felidae
    {
        string male;

        public Felidae()
        {

        }
        public Felidae(string male)
        {
            this.male = male;

        }
        public string Male
        {
            get { return this.male; }
            set { this.male = value; }
        }
        public  void Roar()
        {
            Console.WriteLine($"{this.male} is roaring");
        }
    }
}
