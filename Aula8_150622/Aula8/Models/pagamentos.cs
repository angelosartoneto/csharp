namespace Aula8.Models
{
    public class Pagamentos
    {
  public Guid ID { get; set; }
  public DateTime DataPagamento { get; set; }
  public DateTime DataVencimento { get; set; }
  public decimal Valor { get; set; }
  public string Metodo { get; set; }
  public string Descricao { get; set; }

    }

}