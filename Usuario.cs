using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialRT
{
    internal class Usuario
    {

        //** No puede tener el mismo nombre la clase y el campo ej: Usurio.Usuario**//
        private string NombreUsuario;
        private string contrasenia;

        private Persona persona;

        public Usuario()
        {

        }

        public string NombreUsuario1 { get => NombreUsuario; set => NombreUsuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        internal Persona Persona { get => persona; set => persona = value; }



        public Usuario(string nombreUsuario, string contrasenia)
        {
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
            
        }
        //** No se te olvide cambiar esto **//
        public void RealizarPrestamo()
        {
            Console.WriteLine("Préstamo realizado por el usuario: " + NombreUsuario);

        }
    }
}
