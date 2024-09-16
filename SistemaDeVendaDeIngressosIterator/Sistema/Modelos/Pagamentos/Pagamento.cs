namespace Sistema.Modelos.Pagamentos;
public abstract class Pagamento
{
    public double ValorCompra { get; set; }
    public DateTime HorarioPagamento { get; set; }
    protected Pagamento(double valorCompra)
    {
        ValorCompra = valorCompra;
        HorarioPagamento = DateTime.Now;
    }
    public abstract void ProcessarPagamento();
}
