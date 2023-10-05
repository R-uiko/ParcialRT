using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialRT
{
    internal class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fechaCumpleaños;

        public Persona()
        { 
        
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaCumpleaños { get => fechaCumpleaños; set => fechaCumpleaños = value; }
    }
}
