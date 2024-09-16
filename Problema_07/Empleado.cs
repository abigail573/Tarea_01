using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_07
{
    internal class Empleado
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int numero { get; set; }
        public double sueldo { get; set; }

        public Empleado(int codigo, string nombre, int numero, double sueldo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.numero = numero;
            this.sueldo = sueldo;
        }

        public string Texto()
        {
            if (sueldo < 3500)
                return "menor a 3500";
            else if (sueldo > 3500)
                return "mayor a 3500";
            else
                return "igual a 3500";
        }

        public void listado(Empleado e)
        {
            Console.WriteLine($"Codigo : {e.codigo}");
            Console.WriteLine($"Nombre : {e.nombre}");
            Console.WriteLine($"Numero de celular : {e.numero}");
            Console.WriteLine($"Sueldo en soles   : {e.sueldo} - {e.Texto()}");
        }
    }
}
