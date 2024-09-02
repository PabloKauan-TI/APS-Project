using SistemaDeVendaDeIngressos.Models;

namespace Sistema.Modelos.Usuarios;
public class Cliente : User
{
    public Carrinho carrinho { get; set; }
    public Cliente(string nome, DateTime dataDeNascimento, string cpf, string email, string senha) : base(nome, dataDeNascimento, cpf, email, senha)
    {
        carrinho = new Carrinho();
    }
    public override void RegistrarNovoUser()
    {
        Console.WriteLine("Cliente cadastrado com sucesso");
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
