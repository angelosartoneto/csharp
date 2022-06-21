namespace Aula9
{
    class Program
    {
        static void Main(string[] args)
        {
           Funcionario funcionario = new Funcionario();
           funcionario.Nome = "Angelo";
           funcionario.SalvarNomeFuncionario();

           Departamento departamento = new Departamento();
           departamento.Id = 100;
           departamento.DescricaoDepartamento = "Desenvolvimento DevInHouse";
           departamento.CentroDeCusto = new Random(50).Next(5000);
           departamento.FuncionarioNoDepartamento = funcionario;

           departamento.InserirFuncionarioNoDepartamento();
        }
    }
}