namespace Sistema.Modelos.Usuarios;
public abstract class User
{
    protected string Nome { get; set; }
    protected DateTime DataDeNascimento { get; set; }
    protected string Cpf { get; set; }
    protected string Email { get; set; }
    protected string Senha { get; set; }
    protected User(string nome, DateTime dataDeNascimento, string cpf, string email, string senha)
    {
        Nome = nome;
        DataDeNascimento = dataDeNascimento;
        Cpf = cpf;
        Email = email;
        Senha = senha;
    }
    public abstract void RegistrarNovoUser();
}
