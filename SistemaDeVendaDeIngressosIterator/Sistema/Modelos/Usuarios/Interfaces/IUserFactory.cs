namespace Sistema.Modelos.Usuarios.Interfaces;
public interface IUserFactory
{
    public User criarUser(string nome, DateTime dataDeNascimento, string cpf, string email, string senha);
}
