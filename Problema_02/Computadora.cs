using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_02
{
    internal class Computadora
    {
        public int codigo { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public double precioDoll { get; set; }

        public Computadora(int codigo, string marca, string color, double precioDoll)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.precioDoll = precioDoll;
        }
        public double precioSol()
        {
            return precioDoll * 3.35;
        }
        public double precioEuros()
        {
            return precioDoll * 1.20;
        }
        public void listado(Computadora c)
        {
            Console.WriteLine($"Codigo  : {c.codigo}");
            Console.WriteLine($"Marca   : {c.marca}");
            Console.WriteLine($"Color   : {c.color}");
            Console.WriteLine($"Precio  Dolares : {c.precioDoll}");
            Console.WriteLine($"Precio  Soles   : {c.precioSol()}");
            Console.WriteLine($"Precio  Euros   : {c.precioEuros()}");
        }

    }
}
