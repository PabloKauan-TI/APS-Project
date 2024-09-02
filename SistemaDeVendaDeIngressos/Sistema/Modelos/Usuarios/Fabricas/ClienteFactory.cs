using Sistema.Modelos.Usuarios.Interfaces;

namespace Sistema.Modelos.Usuarios.Fabricas;
public class ClienteFactory : IUserFactory
{
    private string nome;
    private DateTime dataDeNascimento;
    private string cpf; 
    private string email;
    private string senha;

    public ClienteFactory(string nome, DateTime dataDeNascimento, string cpf, string email, string senha)
    {
        this.nome = nome;
        this.dataDeNascimento = dataDeNascimento;
        this.cpf = cpf;
        this.email = email;
        this.senha = senha;
    }
    public User criarUser()
    {
        return new Cliente(nome, dataDeNascimento, cpf, email, senha);
    }
}
