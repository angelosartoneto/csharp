// See https://aka.ms/new-console-template for more information

// TRATAMENTO DE ERROS 
using System;

namespace exemploTrycat
{
    class Program
    {
        static void Main(string[] args)
    {
    string texto = "10";
    int numero = Convert.ToInt32(texto);
    int resultado = 100 / numero;

    Console.WriteLine ($"O resultado é: {numero} é: {resultado}");
    
        }
    }
}