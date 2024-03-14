using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSgbSantiagoLoaiza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = new List<Libro>();
            libros.Add(new Libro("El principito", "Antoine de Saint-Exupéry", true));
            libros.Add(new Libro("Harry Potter y la piedra filosofal", "J.K. Rowling", true));
            libros.Add(new Libro("Cien años de soledad", "Gabriel García Márquez", true));
            libros.Add(new Libro("1984", "George Orwell", true));
            libros.Add(new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", true));

            List<Usuario> users = new List<Usuario>();
            users.Add(new Usuario("Marlon Trujillo", 18));
            users.Add(new Usuario("Melany Valero", 20));
            users.Add(new Usuario("Ashley Valero", 25));

            string opcion = "";
            while (opcion != "4")
            {
                Biblioteca biblioteca = new Biblioteca("Biblioteca Central");

                Console.WriteLine("****** MENU ******");
                Console.WriteLine("1. Catálogo de libros");
                Console.WriteLine("2. Prestar libros");
                Console.WriteLine("3. Entregar libro");
                Console.WriteLine("4. Cerrar");
                Console.Write("Elige una opción:");
                opcion = Console.ReadLine();

                while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4")
                {
                    Console.WriteLine("Ingrese un número válido:");
                    opcion = Console.ReadLine();
                }

                if (opcion == "1")
                {
                    biblioteca.MostrarCatalogo(libros);
                }
                else if (opcion == "2")
                {
                    Console.Write("Cuál es tu nombre/apellido?: ");
                    string nombreUsuario = Console.ReadLine();
                    Usuario usuarioActual = null;

                    foreach (var usuario in users)
                    {
                        if (usuario.Nombre == nombreUsuario)
                        {
                            usuarioActual = usuario;
                            break;
                        }
                    }

                    if (usuarioActual != null)
                    {
                        biblioteca.PrestarLibro(libros, usuarioActual);
                    }
                    else
                    {
                        Console.WriteLine("Aún no estás registrado :C");
                    }
                }
                else if (opcion == "3")
                {
                    Console.Write("Cuál es tu nombre/apellido?: ");
                    string nombreUsuario = Console.ReadLine();
                    Usuario usuarioActual = null;

                    foreach (var usuario in users)
                    {
                        if (usuario.Nombre == nombreUsuario)
                        {
                            usuarioActual = usuario;
                            break;
                        }
                    }

                    if (usuarioActual != null)
                    {
                        Console.WriteLine(biblioteca.EntregarLibros(libros, usuarioActual));
                    }
                    else
                    {
                        Console.WriteLine("Aún no estás registrado :C");
                    }
                }
                else
                {
                    Console.WriteLine("Adios <3");
                }
            }
        }
    }
}
