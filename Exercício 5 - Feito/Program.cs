using System;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuadas do 1 ao 10");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Tabuada do " + i);
                for (var a = 1; a <= 10; a++)
                {
                    Console.WriteLine(i + " * " + a + " = " + (i*a));
                }   
            }
        }
    }
}
