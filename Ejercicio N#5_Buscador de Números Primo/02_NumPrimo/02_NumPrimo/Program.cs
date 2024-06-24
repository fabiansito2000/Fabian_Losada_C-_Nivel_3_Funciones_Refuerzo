using System;
using System.Collections.Generic;

class Program
{
    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;

        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Escribe el inicio del rango: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("Escribe el fin del rango: ");
        int fin = int.Parse(Console.ReadLine());

        List<int> primosEncontrados = new List<int>();

        for (int num = inicio; num <= fin; num++)
        {
            if (EsPrimo(num))
                primosEncontrados.Add(num);
        }
        Console.WriteLine("numeros primos hayados en el rango:");
        foreach (var primo in primosEncontrados)
        {
            Console.Write(primo + " ");
        }
    }
}
