using System;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool achou = false;

            string[] Pessoas = null;
            Pessoas = new string [10];
            Console.WriteLine("Salve aqui os 10 nomes mais badalados dos momentos");

            int c = 0;
            foreach (var item in Pessoas)
            {
                Pessoas[c] = Console.ReadLine();
                c++;
            }

            Console.WriteLine("Pesquise o nome para que possamos saber se ele está salvo");
            string nome = Console.ReadLine();
            c = 0;
            foreach (var item in Pessoas)
            {
                if (nome == Pessoas[c])
                {
                    achou = true;
                }
            }

            if (achou == true)
            {
                Console.WriteLine("Está salvo aqui! Minha memória é boa");
            }
            else
            {
                Console.WriteLine("Vish! Não achei, minha memória está meio ruim");
            }
        }
    }
}
