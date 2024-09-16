using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente p = new Paciente("Laura", "Gomez", 25, 1.65, 56);
            p.listado(p);
            Console.WriteLine("-------------------------");
            p.edad = 12;
            p.listado(p);

            Console.ReadKey();
        }
    }
}
