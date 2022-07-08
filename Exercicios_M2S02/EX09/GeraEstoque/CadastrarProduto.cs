
public class CadastrarProduto
{

    public String nome;
    public int quantidade, valorCompra, valorVenda;

    public void CadastrarProdutos()
    {

        Console.WriteLine("********* CADASTRANDO PRODUTOS ********* ");
        Guid g = Guid.NewGuid();
        Console.WriteLine("Digite o nome do produto: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite a quantidade do produto: ");
        quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de compra do produto: ");
        valorCompra = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de venda do produto: ");
        valorVenda = int.Parse(Console.ReadLine());
        Console.WriteLine("******** CADASTRO CONCLUÍDO ********");

        //Console.WriteLine(Guid.NewGuid());

        string[] cadastro = { g.ToString(), nome, quantidade.ToString(), valorCompra.ToString(), valorVenda.ToString() };
        cadastro.ToList().ForEach(i => Console.WriteLine(i));

       //System.IO.File.WriteAllLines(@"DIRETORIO....produtos.txt", cadastro); - FAZ A IMPRESSÃO EM ARQUIVO.TXT

    }
}