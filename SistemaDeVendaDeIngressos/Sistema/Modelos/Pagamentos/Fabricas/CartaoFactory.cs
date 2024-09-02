using Sistema.Modelos.Pagamentos.Interfaces;

namespace Sistema.Modelos.Pagamentos.Fabricas;
internal class CartaoFactory : IPagamentoFactory
{
    private double valorCompra;
    private string numeroCartao;
    private string nomeTitular;
    private string validade;
    private string cvv;
    public CartaoFactory(double valorCompra, string numeroCartao, string nomeTitular, string validade, string cvv)
    {
        this.valorCompra = valorCompra;
        this.numeroCartao = numeroCartao;
        this.nomeTitular = nomeTitular;
        this.validade = validade;
        this.cvv = cvv;
    }
    public Pagamento salvarPagamento()
    {
        return new Cartao(valorCompra, numeroCartao, nomeTitular, validade, cvv);
    }
}
