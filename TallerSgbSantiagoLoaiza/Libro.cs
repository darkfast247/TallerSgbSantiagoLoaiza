using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSgbSantiagoLoaiza
{
    internal class Libro
    {
        public string Titulo { get; set; }
        private string autor;
        public bool Disponibilidad { get; set; }

        public Libro(string titulo, string autor, bool disponibilidad)
        {
            this.Titulo = titulo;
            this.autor = autor;
            this.Disponibilidad = disponibilidad;
        }

        public string ObtenerTitulo()
        {
            return Titulo;
        }

        public string ObtenerAutor()
        {
            return autor;
        }
    }
}
