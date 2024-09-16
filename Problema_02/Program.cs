using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora c = new Computadora(5214, "Samsung", "Negro", 70);
            c.listado(c);
            c.precioDoll = c.precioDoll - (c.precioDoll * 0.10);
            Console.WriteLine("------------------------");
            c.listado(c);

            Console.ReadKey();
        }
    }
}
