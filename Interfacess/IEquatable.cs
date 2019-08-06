using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacess
{
    interface IEquatable<T>
    {
         bool Equal(T obj);
    }
}
