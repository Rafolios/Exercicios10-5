using System;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeironumero = 0;
            int ultimonumero = 999;

            Console.WriteLine("Escreva 10 números de até 3 algarismos e te digo o maior e o menor!");
            Console.WriteLine("Insira 10 números");
            for (var i = 1; i <= 10; i++)
            {
                int numerovez = int.Parse(Console.ReadLine());

                if (numerovez > primeironumero)
                {
                    primeironumero = numerovez;
                }
                if (numerovez < ultimonumero)
                {
                    ultimonumero = numerovez;
                }
            }

            Console.WriteLine($"O numero maior é {primeironumero} e o menor foi {ultimonumero}");
        }
    }
}
