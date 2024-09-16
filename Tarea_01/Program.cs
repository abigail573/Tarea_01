using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular c = new Celular(963258147, "Kary", 500, 2);

            c.listado(c);
            Console.WriteLine("--------------------------------");

            c.segCons += 20;
            c.precioSeg = c.precioSeg - (c.precioSeg * 0.05);

            c.listado(c);


            Console.ReadKey();
        }
    }
}
