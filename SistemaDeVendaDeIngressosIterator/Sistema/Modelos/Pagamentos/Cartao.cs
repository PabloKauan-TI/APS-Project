namespace Sistema.Modelos.Pagamentos;
public class Cartao : Pagamento
{
    public string NumeroCartao { get; set; }
    public string NomeTitular { get; set; }
    public string Validade { get; set; }
    public string Cvv { get; set; }
    public Cartao(double valorCompra, string numeroCartao, string nomeTitular, string validade, string cvv) : base(valorCompra)
    {
        ValorCompra = valorCompra;
        NumeroCartao = numeroCartao;
        NomeTitular = nomeTitular;
        Validade = validade;
        Cvv = cvv;
    }
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento efetuado com sucesso");
    }
}
