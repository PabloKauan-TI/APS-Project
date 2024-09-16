using Sistema.Modelos.Pagamentos;
using Sistema.Modelos.Usuarios;

namespace Sistema.Modelos;
public class PagamentoIterator : IIteratorP
{
    private List<Pagamento> _pagamentos;
    private int _currentIndex = 0;
    public PagamentoIterator(List<Pagamento> pagamentos)
    {
        _pagamentos = pagamentos;
    }
    public bool hasNext()
    {
        return _currentIndex < _pagamentos.Count;
    }
    public Pagamento next()
    {
        if (!hasNext())
        {
            return null;
        }
        return _pagamentos[_currentIndex++];
    }
}
