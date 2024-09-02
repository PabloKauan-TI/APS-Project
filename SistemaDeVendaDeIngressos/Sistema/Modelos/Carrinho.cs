namespace SistemaDeVendaDeIngressos.Models;
public class Carrinho
{
    public List<string> Itens { get; private set; }
    public Carrinho()
    {
        Itens = new List<string>();
    }
    public void AdicionarItem(string item)
    {
        Itens.Add(item);
    }
    public void RemoverItem(string item)
    {
        Itens.Remove(item);
    }
    public void LimparCarrinho()
    {
        Itens.Clear();
    }
}
