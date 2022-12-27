using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab03_Search;
class FinalExercise
{
    static void Main(string[] args)
    {
        // Arreglo desordenado
        Console.WriteLine("Algoritmo ejercicio final: ");
        int[] A = new int[100];
        Random random = new Random();
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = random.Next(1, 201);
        }

        // Impresion del arreglo
        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}]={A[i]}, ");
        }

        var horaInicio = DateTime.Now; // Hora de inicio
        Stopwatch time = new Stopwatch(); // Reloj para el tiempo de ejecucion
        time.Start(); // Inicio de reloj

        // Busqueda de los elementos
        int numBuscado, busquedasExitosas = 0, busquedasFallidas = 0, posicionEncontrada;
        String StringNumBuscados = "\nNumeros a buscar: ";
        for(int i = 0; i < 50; i++)
        {
            numBuscado = random.Next(1, 201); // Elemento a buscar random
            StringNumBuscados += numBuscado + "  ";
            posicionEncontrada = BusquedaLinealID(A, A.Length, numBuscado);
            if (posicionEncontrada == -1)
            {
                busquedasFallidas++;
            }
            else
            {
                busquedasExitosas++;
            }
        }

        // Porcentajes de exito
        double porcentajeExito = (busquedasExitosas*100)/50;
        double porcentajeFallido = (busquedasFallidas*100)/50;

        // Ordenar Array
        Array.Sort(A);

        // Impresion de Resultados
        Console.WriteLine("\n\n" + StringNumBuscados); // Numeros aleatorios
        Console.WriteLine("Busquedas existosas: " + busquedasExitosas);
        Console.WriteLine("Busquedas fallidas: " + busquedasFallidas);
        Console.WriteLine("Busquedas Totales: " + (busquedasExitosas + busquedasFallidas));
        Console.WriteLine("Porcentaje de exito en las busquedas: " + porcentajeExito + "%");
        Console.WriteLine("Porcentaje de fallas en las busquedas: " + porcentajeFallido + "%");

        Console.WriteLine("Arreglo ordenado: "); // Arreglo ordenado
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}]={A[i]}, ");
        }

        time.Stop(); // Fin del reloj
        Console.WriteLine("\n\nTiempo total de ejecucion: " + time.Elapsed.TotalMilliseconds + " ms");
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
