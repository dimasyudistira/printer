using System;
using System.Collections.Generic;
using System.Text;

namespace printer
{
    class epson:printer
    {
        public override void show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }

        public override void print()
        {
            Console.WriteLine("Epson printer printing ...");
        }
    }
}
