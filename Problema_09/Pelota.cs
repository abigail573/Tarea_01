using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_09
{
    internal class Pelota
    {
        public string marca { get; set; }
        public double pesoGramo { get; set; }
        public double presionLib { get; set; }
        public double diametro { get; set; }
        public double precio { get; set; }

        public Pelota(string marca, double pesoGramo, double presionLib, double diametro, double precio)
        {
            this.marca = marca;
            this.pesoGramo = pesoGramo;
            this.presionLib = presionLib;
            this.diametro = diametro;
            this.precio = precio;
        }

        public double radio()
        {
            return diametro / 2;
        }
        public double volumen()
        {
            return (4 * 3.1416) * (radio() * radio()) * (radio() / 3);
        }
        public double descuento()
        {
            return 0.10 * precio;
        }
        public double importe()
        {
            return precio - descuento();
        }
        public void listado(Pelota p)
        {
            Console.WriteLine($"Marca : {p.marca}");
            Console.WriteLine($"Peso en Gramos    : {p.pesoGramo}");
            Console.WriteLine($"Presión en Libras : {p.presionLib}");
            Console.WriteLine($"Diametro (cm)     : {p.diametro}");
            Console.WriteLine($"Precio : {p.precio}");
            Console.WriteLine($"Radio : {p.radio()}");
            Console.WriteLine($"Volumen del balón : {p.volumen()}");
            Console.WriteLine($"Descuento : {p.descuento()}");
            Console.WriteLine($"Importe a Pagar : {p.importe()}");

        }
    }
}
