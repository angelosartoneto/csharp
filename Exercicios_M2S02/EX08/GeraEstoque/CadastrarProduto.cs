
public class CadastrarProduto
{

    public String nome;
    public int quantidade, valorCompra, valorVenda;

    public void CadastrarProdutos()
    {
        Console.WriteLine("********* CADASTRANDO PRODUTOS ********* ");
        Console.WriteLine("Digite o nome do produto: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite a quantidade do produto: ");
        quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de compra do produto: ");
        valorCompra = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de venda do produto: ");
        valorVenda = int.Parse(Console.ReadLine());
        Console.WriteLine("******** CADASTRO CONCLUÍDO ********");


    }
}