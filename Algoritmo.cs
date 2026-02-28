using System;
using System.Linq; // Necesario para Enumerable y ToArray()

public class Algoritmo
{
    public int[] GenerarNumeros(int n)
    {
        // Semilla fija (42) garantiza que todos los alumnos ordenen la misma secuencia
        Random r = new Random(42);
        return Enumerable.Range(0, n).Select(_ => r.Next(0, 50000)).ToArray();
    }

    public bool EstaOrdenado(int[] arr)
    {
        if (arr == null || arr.Length == 0) return true;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            // Si el actual es mayor al siguiente, no está ordenado
            if (arr[i] > arr[i + 1]) return false;
        }
        return true;
    }

    public void BubbleSort(int[] arr)
     {
        // Implementación de QuickSort en lugar de Bubble Sort
        if (arr == null || arr.Length <= 1) return;

        QuickSort(arr, 0, arr.Length - 1);

    }

    // Método auxiliar: QuickSort (recursivo, partición Lomuto)
    private void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int p = Partition(arr, low, high);
            QuickSort(arr, low, p - 1);
            QuickSort(arr, p + 1, high);
        }
    }

    private int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j <= high - 1; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                int temporal = arr[i];
                arr[i] = arr[j];
                arr[j] = temporal;
            }
        }
        int temp = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp;
        return i + 1;
    }
}