using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_05
{
    internal class Video
    {
        public int codigo { get; set; }
        public string nombreVid { get; set; }
        public double duracion { get; set; }
        public double precioSol { get; set; }
        public double tipCambio { get; set; }

        public Video(int codigo, string nombreVid, double duracion, double precioSol, double tipCambio)
        {
            this.codigo = codigo;
            this.nombreVid = nombreVid;
            this.duracion = duracion;
            this.precioSol = precioSol;
            this.tipCambio = tipCambio;
        }
        public double precioVidDoll()
        {
            return precioSol / tipCambio;
        }
        public void listado(Video v)
        {
            Console.WriteLine($"Codigo                  : {v.codigo}");
            Console.WriteLine($"Nombre del video        : {v.nombreVid}");
            Console.WriteLine($"Duracion                : {v.duracion}");
            Console.WriteLine($"Precio en soles         : {v.precioSol}");
            Console.WriteLine($"Tipo de Cambio          : {v.tipCambio}");
            Console.WriteLine($"Precio video en dolares : {v.precioVidDoll()}");
        }
    }
}
