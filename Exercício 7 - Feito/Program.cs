using System;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequencia = null;
            sequencia = new int [15];
            Console.WriteLine("Vou colocar na ordem inversa os 15 números que você colocar");

            int c = 0;
            foreach (var item in sequencia)
            {
                sequencia[c] = int.Parse(Console.ReadLine());
                c++;
            }

            Console.WriteLine("Invertendo!");

            c = 14;
            foreach (var item in sequencia)
            {
                Console.WriteLine(sequencia[c]);
                c++;
            }
        }
    }
}
