using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_03
{
    internal class Edificio
    {
        public int codigo { get; set; }
        public int departamento { get; set; }
        public int cantPisos { get; set; }
        public double precioDoll { get; set; }

        public Edificio(int codigo, int departamento, int cantPisos, double precioDoll)
        {
            this.codigo = codigo;
            this.departamento = departamento;
            this.cantPisos = cantPisos;
            this.precioDoll = precioDoll;
        }
        public double precioEdif()
        {
            return departamento * precioDoll;
        }

        public void listado(Edificio e)
        {
            Console.WriteLine($"Codigo                  : {e.codigo}");
            Console.WriteLine($"Numero de Departamentos : {e.departamento}");
            Console.WriteLine($"Cantidad de pisos       : {e.cantPisos}");
            Console.WriteLine($"Precio Departamento en Dolares : {e.precioDoll}");
            Console.WriteLine($"Precio Edificio en Dolares     : {e.precioEdif()}");
        }
    }
}
