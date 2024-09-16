using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelota p = new Pelota("Mikasa", 260, 0.3, 18, 55);
            p.listado(p);
            Console.WriteLine("----------------------------------");
            p.precio = p.precio - (p.precio * 0.25);
            p.diametro += 1;
            p.listado(p);
            Console.ReadKey();
        }
    }
}
