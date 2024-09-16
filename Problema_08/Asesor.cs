using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_08
{
    internal class Asesor
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int horas { get; set; }
        public double tarifa { get; set; }

        public Asesor(int codigo, string nombre, int horas, double tarifa)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horas = horas;
            this.tarifa = tarifa;
        }

        public double sueldoBruto()
        {
            return horas * tarifa;
        }
        public double descuento()
        {
            return 0.15 * sueldoBruto();
        }
        public double sueldoNeto()
        {
            return sueldoBruto() - descuento();
        }
        public void listado(Asesor a)
        {
            Console.WriteLine($"Codigo : {a.codigo}");
            Console.WriteLine($"Nombre : {a.nombre}");
            Console.WriteLine($"Horas trabajadas : {a.horas}");
            Console.WriteLine($"Tarifa por hora  : {a.tarifa}");
            Console.WriteLine($"Sueldo Bruto     : {a.sueldoBruto()}");
            Console.WriteLine($"Descuento        : {a.descuento()}");
            Console.WriteLine($"Sueldo Neto      : {a.sueldoNeto()}");
        }
    }
}
