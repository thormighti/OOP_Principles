using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    class Lion : Felidae
    {
        int weight;

        public Lion(string male , int weight): base(male)      // inherits all the methods too
        {
            
            this.weight = weight;
        }
        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
    }
}
