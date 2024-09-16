using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado e = new Empleado(123, "Sebastian", 951357258, 354.0);
            e.listado(e);
            Console.WriteLine("------------------------------");
            e.numero = 999888777;
            e.sueldo += 200;
            e.listado(e);
            Console.ReadKey();
        }
    }
}
