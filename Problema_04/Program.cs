using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Obrero o = new Obrero(541, "Julian", 8, 40.5);
                o.listado(o);
                Console.WriteLine("------------------");
                o.horasTrabajadas += 8;
                o.tarifaHora = o.tarifaHora - (o.tarifaHora * 0.015);
                o.listado(o);
                Console.ReadKey();

            }
        }
    }
}
