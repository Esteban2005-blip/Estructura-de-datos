using System;
using System.Collections.Generic;

class TorreDeHanoi
{
    static Stack<int> origen = new Stack<int>();
    static Stack<int> auxiliar = new Stack<int>();
    static Stack<int> destino = new Stack<int>();

    static void MoverDiscos(int n, Stack<int> desde, Stack<int> hacia, Stack<int> usando, string nombreDesde, string nombreHacia, string nombreUsando)
    {
        if (n == 1)
        {
            int disco = desde.Pop();
            hacia.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nombreDesde} a {nombreHacia}");
        }
        else
        {
            MoverDiscos(n - 1, desde, usando, hacia, nombreDesde, nombreUsando, nombreHacia);
            MoverDiscos(1, desde, hacia, usando, nombreDesde, nombreHacia, nombreUsando);
            MoverDiscos(n - 1, usando, hacia, desde, nombreUsando, nombreHacia, nombreDesde);
        }
    }

    static void Main()
    {
        Console.Write("Ingrese el número de discos: ");
        int numeroDeDiscos = int.Parse(Console.ReadLine());

        // Inicializar la torre origen
        for (int i = numeroDeDiscos; i >= 1; i--)
        {
            origen.Push(i);
        }

        Console.WriteLine("\nPasos para resolver las Torres de Hanoi:\n");
        MoverDiscos(numeroDeDiscos, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
    }
}





