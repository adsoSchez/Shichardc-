using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerEj
{
    internal class punto1
    {
        public interface IPersona
        {
            string Nombre { get; set; }
            int Edad { get; set; }
            string Documento { get; set; }
            void MostrarDatos();
        }

        // CLASE BASE ABSTRACT
        public abstract class PersonaBase : IPersona
        {
            private string _nombre;
            private int _edad;
            private string _documento;

            public string Nombre
            {
                get { return _nombre; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("El nombre no puede estar vacío");
                    else
                        _nombre = value;
                }
            }

            public int Edad
            {
                get { return _edad; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("La edad no puede ser negativa");
                    else
                        _edad = value;
                }
            }

            public string Documento
            {
                get { return _documento; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("El documento no puede estar vacío");
                    else
                        _documento = value;
                }
            }

            protected PersonaBase(string nombre, int edad, string documento)
            {
                Nombre = nombre;
                Edad = edad;
                Documento = documento;
            }

            public virtual void MostrarDatos()
            {
                Console.WriteLine($"│ Nombre:    {Nombre,-25} │");
                Console.WriteLine($"│ Edad:      {Edad,-25} │");
                Console.WriteLine($"│ Documento: {Documento,-25} │");
            }
        }

        // CLASE CONCRETA
        public class Persona : PersonaBase
        {
            public Persona(string nombre, int edad, string documento) : base(nombre, edad, documento)
            {
            }

            public override void MostrarDatos()
            {   Console.WriteLine("│*************************│");
                base.MostrarDatos();
            }

            public bool CrearPersona(string nombre, int edad, string documento)
            {
                try
                {
                    Nombre = nombre;
                    Edad = edad;
                    Documento = documento;
                    return true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"\n❌ ERROR: {ex.Message}");
                    return false;
                }
            }
        }

    }
}
