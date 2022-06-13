using System;
using System.Collections.Generic;
using System.Text;

namespace printer
{
    class canon:printer
    {
        public override void show()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }

        public override void print()
        {
            Console.WriteLine("Canon printer printing ...");
        }
    }
}
