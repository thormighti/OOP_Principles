using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesion_Coupling
{
    class Report
    {
        public string larry;
        public void LoadFile (string peter)
        {
            this.larry = peter;
            StreamWriter writer = new StreamWriter(larry);
            writer.Write("Nigga you good");
            writer.Close();
        }
    }
}
