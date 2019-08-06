using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacess
{
    class Car:IEquatable<Car>
    {
        string make;
        string model;
        public bool Equal(Car car)
        {
            return this.make == car.make;
        }
    }
}
