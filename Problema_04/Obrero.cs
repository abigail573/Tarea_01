using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_04
{
    internal class Obrero
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int horasTrabajadas { get; set; }
        public double tarifaHora { get; set; }

        public Obrero(int codigo, string nombre, int horasTrabajadas, double tarifaHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaHora = tarifaHora;
        }

        public double sueldoBruto()
        {
            return horasTrabajadas * tarifaHora;
        }
        public double descuentoAFP()
        {
            return 0.10 * sueldoBruto();
        }
        public double descuentoEPS()
        {
            return 0.05 * sueldoBruto();
        }
        public double sueldoNeto()
        {
            return sueldoBruto() - descuentoAFP() - descuentoEPS();
        }

        public void listado(Obrero o)
        {
            Console.WriteLine($"Codigo : {o.codigo}");
            Console.WriteLine($"Nombre : {o.nombre}");
            Console.WriteLine($"Horas  : {o.horasTrabajadas}");
            Console.WriteLine($"Tarifa : {o.tarifaHora}");
            Console.WriteLine($"Sueldo Bruto  : {o.sueldoBruto()}");
            Console.WriteLine($"Descuento AFP : {o.descuentoAFP()}");
            Console.WriteLine($"Descuento EPS : {o.descuentoEPS()}");
            Console.WriteLine($"Sueldo Neto   : {o.sueldoNeto()}");
        }
    }
}
