using System;

namespace printer
{
    class Program
    {
        static void Main(string[] args)
        {
            printer printer;

            Console.WriteLine("Pilih Printer :");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor printer [1..3]: ");
            int nomorprinter = Convert.ToInt32(Console.ReadLine());

            if (nomorprinter == 1)
            {
                printer = new epson();
            }
            else if (nomorprinter == 2)
            {
                printer = new canon();
            }
            else
            {
                printer = new laserjet();
            }

            printer.show();
            printer.print();

            Console.ReadKey();
        }
    }
    }

