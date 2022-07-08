class Conta
{
    public int numero { get; set; }

    public string nomeTitularConta { get; set; }

    public double saldoConta { get; set; }

public Conta (int numero, string nomeTitularConta, double saldoConta)
{
    this.numero = numero;
    this.nomeTitularConta = nomeTitularConta;
    this.saldoConta = saldoConta;
}

public void Saque(double valor)
{
    saldoConta -= valor;
}
    public void Deposito(double valor)
    {
        saldoConta += valor;
    }

}