using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSgbSantiagoLoaiza
{
    internal class Biblioteca
    {
        private string nombre;
        private List<Libro> libros;

        public Biblioteca(string nombre)
        {
            this.nombre = nombre;
            this.libros = new List<Libro>();
        }

        public void PrestarLibro(List<Libro> _libros, Usuario usuario)
        {
            if (usuario.LibroPrestado != null)
            {
                Console.WriteLine("Ya tienes un libro prestado. Devuélvelo antes de tomar otro.");
                return;
            }

            Console.Write("Qué libro deseas prestar?: ");
            string buscar_libro = Console.ReadLine();

            foreach (var libro in _libros)
            {
                if (libro.Disponibilidad && libro.Titulo == buscar_libro)
                {
                    Console.WriteLine("Acabas de prestar el libro");
                    libro.Disponibilidad = false;
                    usuario.LibroPrestado = libro;
                    break;
                }
            }
        }

        public string EntregarLibros(List<Libro> _libros, Usuario usuario)
        {
            if (usuario.LibroPrestado == null)
            {
                return "No tienes ningún libro prestado.";
            }

            Console.Write("Qué libro deseas devolver?: ");
            string buscar_libro = Console.ReadLine();

            foreach (var libro in _libros)
            {
                if (libro == usuario.LibroPrestado && libro.Titulo == buscar_libro)
                {
                    libro.Disponibilidad = true;
                    usuario.LibroPrestado = null;
                    return "Acabas de devolver el libro.";
                }
            }

            return "No tienes ese libro prestado.";
        }

        public void MostrarCatalogo(List<Libro> _libros)
        {
            Console.WriteLine("Catálogo de Libros:");
            foreach (var libro in _libros)
            {
                if (libro.Disponibilidad == true)
                {
                    Console.WriteLine($"{libro.ObtenerTitulo()} - {libro.ObtenerAutor()}");
                }
            }
        }
    }
}
