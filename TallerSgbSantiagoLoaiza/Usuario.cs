using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSgbSantiagoLoaiza
{
    internal class Usuario
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Libro LibroPrestado { get; set; }

        public Usuario(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public string ObtenerNombre()
        {
            return Nombre;
        }

        public int ObtenerEdad()
        {
            return Edad;
        }
    }
}
