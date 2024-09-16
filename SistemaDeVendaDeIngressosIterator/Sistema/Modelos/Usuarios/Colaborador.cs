using System.ComponentModel.DataAnnotations;

namespace Sistema.Modelos.Usuarios;
public class Colaborador : User
{
    [Key]
    public int Matricula { get; set; }
    public string Departamento { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }
    public Colaborador(string nome, DateTime dataDeNascimento, string cpf, string email, string senha, int matricula) :
        base(nome, dataDeNascimento, cpf, email, senha)
    {
        Nome = nome;
        DataDeNascimento = dataDeNascimento;
        Cpf = cpf;
        Email = email;
        Senha = senha;
        Matricula = matricula;
    }
    public override void RegistrarNovoUser()
    {
        Console.WriteLine("Funcionário cadastrado com sucesso");
    }
}
