namespace GeraEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( "Seja bem vindo(a) ao GeraEstoque 1.0");
           Console.WriteLine("----------------------------------------");
           Console.WriteLine("1. CADASTRAR PRODUTO");
           Console.WriteLine("2. CONSULTRA PRODUTO");
           Console.WriteLine("3. MODIFICAR PRODUTO");
           Console.WriteLine("4. EXCLUIR PRODUTO");
           Console.WriteLine("0. SAIR");
           Console.WriteLine("----------------------------------------");
              Console.WriteLine("Digite a opção desejada: ");
              int opcao = Convert.ToInt32 (Console.ReadLine());
              switch (opcao)
              {
                  case 1:
                        CadastrarProduto cadastrarProduto = new CadastrarProduto();
                        cadastrarProduto.CadastrarProdutos();
                      break;
                  case 2:
                      Console.WriteLine("Consulta de produto");
                      break;
                  case 3:
                      Console.WriteLine("Modificação de produto");
                      break;
                  case 4:
                      Console.WriteLine("Exclusão de produto");
                      break;
                  case 0:
                      Console.WriteLine("Saindo do sistema");
                      break;
                  default:
                      Console.WriteLine("Opção inválida");
                      break;
              }
        }
    }
}
