using Sistema.Modelos;
using Sistema.Modelos.Usuarios;
using Sistema.Modelos.Usuarios.Fabricas;
using Sistema.Modelos.Usuarios.Interfaces;

namespace SistemaDeVendaDeIngressos;
public class SistemaPrograma
{
    private UserAggregate _userAggregate = new UserAggregate();
    private string nome, cpf, email, senha;
    private DateTime dataDeNascimento;
    private int tipo;
    public void criarUsuarios()
    {
        IUserFactory clienteFactory = new ClienteFactory();
        IUserFactory colaboradorFactory = new ColaboradorFactory();

        tipo = int.Parse(Console.ReadLine());
        nome = Console.ReadLine();
        dataDeNascimento = DateTime.Parse(Console.ReadLine());
        cpf = Console.ReadLine();
        email = Console.ReadLine();
        senha = Console.ReadLine();

        if (tipo == 1)
        {
            User cliente = clienteFactory.criarUser(nome, dataDeNascimento, cpf, email, senha);
            _userAggregate.addUser(cliente);
        }
        else
        {
            User colaborador = colaboradorFactory.criarUser(nome, dataDeNascimento, cpf, email, senha);
            _userAggregate.addUser(colaborador);
        }
    }
    public void exibirUsuarios()
    {
        IIterator iterator = _userAggregate.createIterator();

        while (iterator.hasNext())
        {
            User user = iterator.next();
            Console.WriteLine(user);
        }
    }
    public void realizarPagamneto()
    {
    }
    public void gerenciarSessoes()
    {
    }
}