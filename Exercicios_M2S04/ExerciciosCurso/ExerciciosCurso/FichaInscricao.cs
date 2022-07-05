using System;

namespace ExerciciosCurso
{

public class FichaInscricao
{
    public string Nome { get; set; }
    public int DataNascimento { get; set; }
    public string Curso { get; set; }
    public string Escolaridade { get; set; }

    public int Idade { get; private set; }

    public double ValorCurso { get; set; }

    public double ValorDesconto { get; set; }

    public double ValorMulta { get; set; }


    public void ExibirIdade()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Ano de nascimento: " + DataNascimento);
        int idade = this.CalcularIdade();
        Console.WriteLine("Idade: " +idade);
    }

    private int CalcularIdade()
    {
        DateTime data = DateTime.Now;
        int ano = data.Year;
        int idade = ano - DataNascimento;
        return idade;

    }

}
}

