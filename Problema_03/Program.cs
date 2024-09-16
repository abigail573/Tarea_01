using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edificio e = new Edificio(654, 2, 5, 42.5);
            e.listado(e);
            e.precioDoll = e.precioDoll + (e.precioDoll * 0.20);
            Console.WriteLine("------------------------");
            e.listado(e);
            Console.ReadKey();
        }
    }
}
