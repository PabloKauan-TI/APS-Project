using Sistema.Modelos.Pagamentos;

namespace Sistema.Modelos;
public interface IIteratorP
{
    bool hasNext();
    Pagamento next();
}
