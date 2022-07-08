public class Var
{
    public static void Main()
    {
        string aluno;
        Console.WriteLine("Digite o nome do aluno: ");
        aluno = Console.ReadLine();

        if (aluno == "")
        throw new Exception("Texto diferente de verdadeiro ou falso / Nome do aluno não pode ser vazio");
        else
        Console.WriteLine("O aluno é: " + aluno);
    }
}