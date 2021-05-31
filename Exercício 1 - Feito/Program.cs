using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo(a) Consulta para voto eleitoral! Qual o seu ano de nascimento?");

            int anonasc = int.Parse(Console.ReadLine());
            int anoatual = DateTime.Now.Year;
            int idade = anoatual - anonasc;
            int anofaltante = 16 - idade;

            if (idade >= 16 && idade <18)
            {
                Console.WriteLine("Você tem " + idade + " anos, você já tem direito ao voto opcional eleitoral! Odirlei 2022!");
            } else if (idade >= 18)
            {
                Console.WriteLine("Você tem " + idade + " anos, você já tem direito ao voto obrigatório eleitoral! Odirlei 2022!");
            }
            else
            {
                Console.WriteLine("Você tem " + idade + " anos, mas não se preocupe, daqui " + anofaltante + " ano(s) você poderá voltar pelo Odrilei!!");
            }
        }
    }
}
