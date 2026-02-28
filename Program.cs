using System;

const int CANTIDAD_ELEMENTOS = 10000;
Algoritmo ordenador = new Algoritmo();

// 1. Generar datos (Semilla 42 para que todos tengan el mismo desorden)
int[] datos = ordenador.GenerarNumeros(CANTIDAD_ELEMENTOS);

Console.WriteLine($"--- Auditoría de Algoritmos .NET 10 ---");
Console.WriteLine($"Procesando: {CANTIDAD_ELEMENTOS:N0} números.");

// 2. El alumno implementa esto en la clase Algoritmo
ordenador.BubbleSort(datos);
{
        int n = arreglo.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                // Si el elemento actual es mayor al siguiente, se intercambian
                if (arreglo[j] > arreglo[j + 1])
                {
                    // Intercambio (Swap)
                    int temporal = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = temporal;
                }
            }
        }
    }


// 3. Validación de integridad
if (ordenador.EstaOrdenado(datos))
{
    Console.WriteLine("VALIDATION: SUCCESS");
}
else
{
    Console.WriteLine("VALIDATION: FAILED");
    Environment.Exit(1); // Crucial para el Autograding de GitHub
}
