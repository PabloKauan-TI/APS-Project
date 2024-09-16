using Sistema.Modelos.Usuarios.Interfaces;

namespace Sistema.Modelos.Usuarios.Fabricas;
public class ColaboradorFactory : IUserFactory
{
    private string nome;
    private DateTime dataDeNascimento;
    private string cpf;
    private string email;
    private string senha;
    private int matricula;
    public ColaboradorFactory()
    {
        
    }
    public ColaboradorFactory(string nome, DateTime dataDeNascimento, string cpf, string email, string senha, int matricula)
    {
        this.matricula = matricula;
        this.nome = nome;
        this.dataDeNascimento = dataDeNascimento;
        this.cpf = cpf;
        this.email = email;
        this.senha = senha;
    }
    public User criarUser(string nome, DateTime dataDeNascimento, string cpf, string email, string senha)
    {
        return new Colaborador(nome, dataDeNascimento, cpf, email, senha, matricula);
    }
}
