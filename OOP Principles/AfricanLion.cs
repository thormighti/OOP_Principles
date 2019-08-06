using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    class AfricanLion:Lion
    {
        public AfricanLion(string male, int size):base(male,size)
        {

        }
        public override string ToString()
        {
            return string.Format($" weight is : {this.Weight} kg and the name is {this.Male} and he is good");
        }
    }
}
