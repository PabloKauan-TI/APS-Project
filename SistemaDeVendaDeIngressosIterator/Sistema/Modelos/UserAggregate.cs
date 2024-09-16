using Sistema.Modelos.Usuarios;

namespace Sistema.Modelos;
public class UserAggregate : IAggregate
{
    private List<User> _users = new List<User>();
    public void addUser(User user)
    {
        _users.Add(user);
    }
    public IIterator createIterator()
    {
        return new UserIterator(_users);
    }
}
