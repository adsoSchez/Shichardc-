using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static tallerEj.punto1;
using static tallerEj.punto2;   

namespace tallerEj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PUNTO 1
            //List<Persona> personas = new List<Persona>();

            //personas.Add(new Persona("Juan Perez", 30, "12345678"));
            //personas.Add(new Persona("Maria Lopez", 25, "87654321"));
            //personas.Add(new Persona("Carlos Gomez", 40, "11223344"));  


            //Console.WriteLine("┌──────────────────────────────┐");  
            //foreach (var persona in personas)
            //{
            //    Console.WriteLine("│ Persona:                    │");
            //    persona.MostrarDatos();
            //    Console.WriteLine("└──────────────────────────────┘");
            //}


            Console.WriteLine("\n=== EJERCICIO 2: Cuenta Bancaria ===");
            List<Persona> cuenta = new List<Persona>();

            cuenta.Add(new Persona("Juan Perez", 30, "12345678"));
            cuenta.Add(new Persona("Maria Lopez", 25, "87654321"));

            cuenta.Depositar(1000);
            cuenta.Retirar(500);
            cuenta.MostrarSaldo();
        }
    }
}
