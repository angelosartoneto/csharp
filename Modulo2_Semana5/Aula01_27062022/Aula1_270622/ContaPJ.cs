class ContaPJ : Conta
{
    public double limitePreco { get; set; }

    // base (parametros) reaproveita o construtor da classe herdada.

    public ContaPJ (int numero, string nomeTitularConta, double saldoConta, double limitePreco) : base(numero, nomeTitularConta, saldoConta)
    {
        this.limitePreco = limitePreco;
    }

    public void Emprestimo(double valorEmprestimo)
    {
        if (valorEmprestimo <= limitePreco)
        {
            saldoConta += valorEmprestimo;
        }
    }

}