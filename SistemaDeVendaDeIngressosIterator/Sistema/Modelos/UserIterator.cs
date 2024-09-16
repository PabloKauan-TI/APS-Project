using Sistema.Modelos.Usuarios;

namespace Sistema.Modelos;
public class UserIterator : IIterator
{
    private List<User> _users;
    private int _currentIndex = 0;
    public UserIterator(List<User> users)
    {
        _users = users;
    }
    public bool hasNext()
    {
        return _currentIndex < _users.Count;
    }
    public User next()
    {
        if (!hasNext())
        {
            return null;
        }
        return _users[_currentIndex++];
    }
}
