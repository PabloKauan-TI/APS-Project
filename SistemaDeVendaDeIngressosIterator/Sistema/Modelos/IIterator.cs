using Sistema.Modelos.Usuarios;

namespace Sistema.Modelos;
public interface IIterator
{
    bool hasNext();
    User next();
}
