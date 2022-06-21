
public class Departamento
{
    public int Id { get; set; }

    public string DescricaoDepartamento { get; set; }

    public int CentroDeCusto { get; set; }

    public Funcionario FuncionarioNoDepartamento { get; set; }

    public void InserirFuncionarioNoDepartamento()
    {
        Console.WriteLine($"Descricao do Departamento {DescricaoDepartamento}");
        Console.WriteLine($"Centro de Custo {CentroDeCusto}");
        Console.WriteLine($@"Id do Funcionario {FuncionarioNoDepartamento.Id};
        Nome do Funcionario {FuncionarioNoDepartamento.Nome};
        Data de Nascimento do Funcionario {FuncionarioNoDepartamento.DataNascimento}
        ");
    }

}