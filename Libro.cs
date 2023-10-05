using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialRT
{
    internal class Libro
    {
        private string nombreLibro;
        private string autor;
        private DateTime fechaPublicacion;

        public string NombreLibro { get => nombreLibro; set => nombreLibro = value; }
        public string Autor { get => autor; set => autor = value; }
        public DateTime FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }

        public Libro()
        {


        }
    }
}
