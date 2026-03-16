using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Autor
    {
        public string nombre;
        public string nacionalidad;

        public Autor(string nombre, string nacionalidad)
        {
            this.nombre = nombre;
            this.nacionalidad = nacionalidad;
        }
    }

    public class Libro
    {
        private string _titulo;
        public List<Autor> autores;

        public Libro(string titulo, Autor autor)
        {
            _titulo = titulo;
            autores = new List<Autor>();
            autores.Add(autor);
        }
    }

    public class Prestamo
    {
        public DateTime fechaInicial;
        public DateTime fechaLimite;
        public DateTime fechaDevolucion;
        public Libro libro;

        public Prestamo(Libro libro)
        {
            this.libro = libro;
        }

        public void Devolver()
        {
            fechaDevolucion = DateTime.Now;
        }
    }

    public class Usuario
    {
        public string cedula;
        public string nombre;
        public string telefono;
        public string direccion;
        public List<Prestamo> prestamos;

        public Usuario(string cedula, string nombre, string telefono, string direccion)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            prestamos = new List<Prestamo>();
        }

        public void Prestar(Libro libro)
        {
            Prestamo p = new Prestamo(libro);
            prestamos.Add(p);
        }

        public void Devolver(Prestamo p)
        {
            p.Devolver();
        }
    }
}
