using System;
using System.Collections.Generic;
using System.Text;

namespace printer
{
    class laserjet:printer
    {
        public override void show()
        {
            Console.WriteLine("Laserjet display dimension : 12*12");
        }

        public override void print()
        {
            Console.WriteLine("Laserjet printer printing ...");
        }
    }
}
