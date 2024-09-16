using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asesor a = new Asesor(641, "Gaby", 8, 30);
            a.listado(a);
            Console.WriteLine("-------------------------");
            a.horas += 10;
            a.tarifa = a.tarifa - (a.tarifa * 0.15);
            a.listado(a);
            Console.ReadKey();
        }
    }
}
