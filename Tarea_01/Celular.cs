using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_01
{
    internal class Celular
    {
        public int numero { get; set; }
        public string usuario { get; set; }
        public int segCons { get; set; }
        public double precioSeg { get; set; }

        public Celular(int numero, string usuario, int seg_cons, double precio_seg)
        {
            this.numero = numero;
            this.usuario = usuario;
            this.segCons = seg_cons;
            this.precioSeg = precio_seg;
        }

        public double costoConsumo()
        {
            return segCons * precioSeg;
        }

        public double impuestoIGV()
        {
            return 0.18 * costoConsumo();
        }

        public double totalPagar()
        {
            return costoConsumo() + impuestoIGV();
        }

        public void listado(Celular c)
        {
            Console.WriteLine($"Numero              : {c.numero}");
            Console.WriteLine($"Usuario             : {c.usuario}");
            Console.WriteLine($"Segundos de consumo : {c.segCons}");
            Console.WriteLine($"Precio por segundo  : {c.precioSeg}");
            Console.WriteLine($"Costo de consumo    : {c.costoConsumo()}");
            Console.WriteLine($"Impuesto IGV        : {c.impuestoIGV()}");
            Console.WriteLine($"Total a pagar       : {c.totalPagar()}");
        }
    }
}
