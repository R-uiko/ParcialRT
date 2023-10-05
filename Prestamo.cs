using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialRT
{
    internal class Prestamo : Formulario, AdministrarPrestamo
    {
        private string fechaPrestamo;
        private List<Libro> Libros;


    

        public string FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        internal List<Libro> Libros1 { get => Libros; set => Libros = value; }

        public Prestamo()
        {
            Libros = new List<Libro>();

        }
        public void RealizarPrestamo()
        {
            Console.WriteLine("Préstamo realizado el " + FechaPrestamo);
        }
        //** Me aparece en rojo cuando pongo el AdministrarPrestamo en la asosacion por eso esto **//
        void AdministrarPrestamo.Prestamo()
        {
            throw new NotImplementedException();
        }
    }
}
