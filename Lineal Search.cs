using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab03_Search;
class LinealSearch
{
    static void Main1(string[] args)
    {
        // Arreglo desordenado
        Console.WriteLine("Algoritmo de busqueda lineal: ");
        int[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24, 25, 57, 13, 10, 78, 10, 65, 69 };

        // Impresion del arreglo
        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}]={A[i]}, ");
        }

        // Leer elemento a buscar por teclado
        Console.Write("\nIngrese el elemento a buscar: ");
        int elemBuscado = int.Parse(Console.ReadLine());

        var horaInicio = DateTime.Now; // Hora de inicio
        Stopwatch time = new Stopwatch(); // Reloj para el tiempo de ejecucion
        time.Start(); // Inicio de reloj 

        // Busqueda y impresion del elemento encontrado
        int posicionEncontrada = BusquedaLinealID(A, A.Length, elemBuscado);
        if (posicionEncontrada == -1)
        {
            Console.WriteLine("\nElemento no encontrado");
        }
        else
        {
            Console.WriteLine($"\nElemento encontrado en la posicion: A[{posicionEncontrada}]={A[posicionEncontrada]}");
        }

        time.Stop(); // Fin del reloj
        Console.WriteLine("Tiempo total de ejecucion: " + time.Elapsed.TotalMilliseconds + " ms");
        var horaFin = DateTime.Now; // Hora de finalizacion

        // Impresion de la hora de inicio y fin
        Console.WriteLine($"Hora de inicio: {horaInicio}");
        Console.WriteLine($"Hora de fin: {horaFin}");
    }

    static int BusquedaLinealID(int[] A, int n, int clave)
    {
        int i;
        for (i = 0; i < n; i++)
            if (A[i] == clave)
                return i;
        return -1;
    }

}
