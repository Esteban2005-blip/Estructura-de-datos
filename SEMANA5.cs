﻿using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        Console.WriteLine("Asignaturas del curso:");
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }
}



