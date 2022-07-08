// See https://aka.ms/new-console-template for more information

//ESTE COM ERROS NA COMPILACAO

using System;
namespace Aula1_270622
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
class HelloWorld
{
    static void Main()
    {
        ContaPJ contaPessoaJuridica = new ContaPJ (8010, "Angelo", 100.0, 500,0);

        Console.WriteLine(contaPessoaJuridica.saldoConta);
    }
}