namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
     string nome = "Angelo";
    string sobrenome = "B N";
    string nomeCompleto1 = nome + " " + sobrenome;

    // let nomeCompleto = `Meu nome é ${nome}`
    string nomeCompleto2 = $"O meu nome completo é {nome} {sobrenome}";
    string minhaIdade = $"Eu tenho {2022 - 1988} anos";
    // string alias System.String


    System.Console.WriteLine("{0} {1}", sobrenome, nome);

        string source = "The mountains are behind the clouds today.";

    var replacement = source.Replace("mountains", "peaks");
    Console.WriteLine($"The source string is <{source}>");
    Console.WriteLine($"The updated string is <{replacement}>");
        }
    }
}