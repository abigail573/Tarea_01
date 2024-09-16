using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video v = new Video(235, "Pasteleria desde cero", 45, 23, 3.35);
            v.listado(v);
            Console.WriteLine("------------------");
            v.precioSol += 5.50;
            v.listado(v);
            Console.ReadKey();
        }
    }
}
