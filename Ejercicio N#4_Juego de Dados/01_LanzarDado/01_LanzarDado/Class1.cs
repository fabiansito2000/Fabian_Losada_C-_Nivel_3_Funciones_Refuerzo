using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LanzarDado
{
    class Program
    {
        static void Main(string[] args)
        {
           //colocamos las variables de tipo int "res" para respuesta y "s" para afirmar con si
            int res;
            int s;
            do
            {
             //Este metodo "Random" nos permite manipular los numeros aleatorios y los limites
            //dependiendo de la cantidad que se quiera repetir
                Random rnd = new Random();
                int dado1 = rnd.Next(1,6);
                int dado2 = rnd.Next(1,6);
                Console.WriteLine();
                Console.WriteLine("Dado 1: "+dado1);
                Console.WriteLine("Dado 2: "+dado2);
                res = dado1 + dado2;
                Console.WriteLine();
                Console.WriteLine("El resultado de los dados essss:"+ res);
                Console.WriteLine();
                Console.WriteLine("Quieres volver a lanzar? Si: 1 o No: Ingresa cualquier numero");

            //aqui colocamos la respuesta con una variable entera "1"
           //al afirmar si con el "1" se repite todo el proceso que se escribio en la consola para jugar otra vez
          //o manda otro numero para terminar el juego

                s = Convert.ToInt32(Console.ReadLine());
            } while(s==1);
        }
        
    }
}
