using System;
using System.Collections.Generic;

namespace ParqueDiversiones
{
    // Clase Persona representa a cada usuario que se forma en la cola
    public class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }
    }

    // Clase que maneja la cola de personas y la asignación de asientos
    public class ColaAtraccion
    {
        private Queue<Persona> cola = new Queue<Persona>();
        private const int LIMITE_ASIENTOS = 30;

        // Método para registrar una persona en la cola
        public void RegistrarPersona(string nombre)
        {
            if (cola.Count < LIMITE_ASIENTOS)
            {
                cola.Enqueue(new Persona(nombre));
                Console.WriteLine($"✔ {nombre} ha sido registrado en la cola.");
            }
            else
            {
                Console.WriteLine($"❌ No se puede registrar a {nombre}: todos los asientos están ocupados.");
            }
        }

        // Mostrar las personas que están actualmente en la cola
        public void MostrarCola()
        {
            Console.WriteLine("\n📋 Lista de personas en la cola:");
            foreach (var persona in cola)
            {
                Console.WriteLine($"- {persona.Nombre}");
            }
        }

        // Asignación de asientos en el orden de llegada
        public void AsignarAsientos()
        {
            Console.WriteLine("\n🎢 Iniciando la asignación de asientos...");
            int numeroAsiento = 1;

            while (cola.Count > 0)
            {
                Persona persona = cola.Dequeue();
                Console.WriteLine($"🪑 Asiento {numeroAsiento}: {persona.Nombre}");
                numeroAsiento++;
            }

            Console.WriteLine("✅ Todos los asientos han sido asignados.");
        }
    }

    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            ColaAtraccion atraccion = new ColaAtraccion();

            // Registro de 35 personas para mostrar que solo se aceptan 30
            for (int i = 1; i <= 35; i++)
            {
                atraccion.RegistrarPersona($"Persona {i}");
            }

            atraccion.MostrarCola();       // Ver la lista de registrados
            atraccion.AsignarAsientos();   // Asignar asientos por orden de llegada

            Console.ReadKey();
        }
    }
}
