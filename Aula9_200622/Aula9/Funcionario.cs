
public class Funcionario
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public DateTime DataNascimento { get; set; }

    public void SalvarNomeFuncionario()
    {
        Console.WriteLine($"Salvando nome do funcionario: {Nome}");
        Console.WriteLine("Salvando nome do funcionário..." + Nome);
    }

}