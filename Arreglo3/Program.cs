using System;

namespace Arreglo3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Hello World Cod-ex!");
            int contador = 0;
            int sumatoria = 0;
            
            int[] numeros = new int[10] { 1,2,3,4,5,6,7,8,9,10};
            for (int i = 0; i < numeros.Length; i++)
            {
                contador = contador + 1;
                Console.WriteLine("Posición: " + i + " = " + numeros[i]);
                sumatoria = sumatoria + numeros[i];

            }
            Console.WriteLine("Hay " + contador + " Valores");
            Console.WriteLine("La suma de los " + contador + " digitos es " + sumatoria);
        }
    }
}
