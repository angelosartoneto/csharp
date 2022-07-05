using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCurso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Programa Calcula Idade");
            FichaInscricao f = new FichaInscricao();
            Console.Write("Nome da pessoa: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Ano de Nascimento: ");
            f.DataNascimento = Convert.ToInt32(Console.ReadLine());
            f.ExibirIdade();

        }
    }
}