using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesion_Coupling
{
    class Looser
    {
        public static string PrintFile(Report file)
        {
            string fr = file.larry;
            StreamReader reader = new StreamReader(fr);
           Console.WriteLine (reader.ReadToEnd());
            reader.Close();
            return fr;
        }
    }
}
