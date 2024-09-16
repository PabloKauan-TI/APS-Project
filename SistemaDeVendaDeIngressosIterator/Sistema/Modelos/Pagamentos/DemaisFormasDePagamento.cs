namespace Sistema.Modelos.Pagamentos;
public class DemaisFormasDePagamento : Pagamento
{
    public int Tipo { get; set; }
    public DemaisFormasDePagamento(double valorCompra, int tipo) : base(valorCompra)
    {
        ValorCompra = valorCompra;
        Tipo = tipo;
    }
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento efetuado com sucesso");
    }
}
