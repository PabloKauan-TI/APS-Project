namespace Sistema.Modelos;
public interface IAggregate
{
    IIterator createIterator();
}
