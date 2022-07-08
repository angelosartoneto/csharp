using System;

namespace calcularIdade
{
    class Program
    {
        static void Main(string[] args)
        {

           int soma = 0;
            for (int i = 1; i < 51; i++)
            {
                soma = soma + i;
            }

            Console.WriteLine(soma);
        }
    }
}