using Sistema.Modelos.Pagamentos.Interfaces;

namespace Sistema.Modelos.Pagamentos.Fabricas;
public class DemaisFormasDePagamentoFactory : IPagamentoFactory
{
    private double valorCompra;
    private int tipo;
    public DemaisFormasDePagamentoFactory(double valorCompra, int tipo)
    {
        this.valorCompra = valorCompra;
        this.tipo = tipo;
    }
    public Pagamento salvarPagamento()
    {
        return new DemaisFormasDePagamento(valorCompra, tipo);
    }
}
