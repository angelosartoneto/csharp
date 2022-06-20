namespace Aula7
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagCartaoMaster = new Pagamento();
            pagCartaoMaster.Bandeira = "MasterCard";
            
            var pagCartaoVisa = new Pagamento();
            pagCartaoVisa.Bandeira = "Visa";

            System.Console.WriteLine(pagCartaoMaster.Bandeira);
            System.Console.WriteLine(pagCartaoVisa.Bandeira);
        }

        class Pagamento
        {
          public string Bandeira;
        }
    }
}