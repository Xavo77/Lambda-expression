using System;
using System.Collections.Generic;
using System.Linq;

namespace ExampleLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Datos> listadatos = new List<Datos>() {
                new Datos{ Nombre="Andres",Edad=24,Pais="Argentina",estatura=1.67},
                new Datos{ Nombre="Santos",Edad=34,Pais="Mexico",estatura=1.67},
                new Datos{ Nombre="Hugo",Edad=64,Pais="Peru",estatura=1.67},
                new Datos{ Nombre="Gustavo",Edad=24,Pais="Jamaica",estatura=1.67}
            };

            var datos = listadatos.Select(x => x.Nombre = "Hugo");
            Console.WriteLine(datos.First());
            Console.ReadLine();
        }
    }

    public class Datos
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Pais { get; set; }
        public double estatura { get; set; }
    }
}