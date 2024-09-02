using Sistema.Modelos.Pagamentos;
using Sistema.Modelos.Pagamentos.Fabricas;
using Sistema.Modelos.Pagamentos.Interfaces;
using Sistema.Modelos.Sessoes;
using Sistema.Modelos.Usuarios;
using Sistema.Modelos.Usuarios.Fabricas;
using Sistema.Modelos.Usuarios.Interfaces;
using Sistema.Repositorios;

namespace SistemaDeVendaDeIngressos;
public class Sistema
{
    public static void Main(string[] args)
    {
        User usuario = null;
        Pagamento pagamento = null;

        SessaoRepository _sessaoRepository = new SessaoRepository();

        List<User> usuarios = new List<User>();
        List<Pagamento> pagamentos = new List<Pagamento>();

        int opcao, tipoPagamento, tipoUsuario, id, cadeiras;
        double valorCompra;
        DateTime dataDeNascimento, data;
        string nome, cpf, email, senha, numeroCartao, nomeTitular, validade, cvv, filme, horario;

        do
        {
            Console.WriteLine("Qual a operação que deseja realizar no sistema?");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    nome = Console.ReadLine();
                    dataDeNascimento = DateTime.Parse(Console.ReadLine());
                    cpf = Console.ReadLine();
                    email = Console.ReadLine();
                    senha = Console.ReadLine();

                    Console.WriteLine("Qual o tipo de usuário a ser cadastrado?");
                    tipoUsuario = int.Parse(Console.ReadLine());

                    if (tipoUsuario == 1)
                    {
                        int matricula = int.Parse(Console.ReadLine());
                        IUserFactory userFactoryColaborador = new ColaboradorFactory(nome, dataDeNascimento, cpf, email, senha, matricula);

                        usuario = userFactoryColaborador.criarUser();
                    }
                    else if (tipoUsuario == 2)
                    {
                        IUserFactory userFactoryCliente = new ClienteFactory(nome, dataDeNascimento, cpf, email, senha);

                        usuario = userFactoryCliente.criarUser();
                    }
                    else
                    {
                        Console.WriteLine("Usuário inválido");
                    }
                    usuarios.Add(usuario);
                    break;
                case 2:
                    Console.WriteLine("Realizar pagamento");
                    Console.WriteLine("Qual será a forma de pagamento?");
                    tipoPagamento = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o valor da compra?");
                    valorCompra = double.Parse(Console.ReadLine());

                    if (tipoPagamento == 1)
                    {
                        Console.WriteLine("Insira o número do cartão:");
                        numeroCartao = Console.ReadLine();
                        Console.WriteLine("Insira o nome completo do titular do cartão:");
                        nomeTitular = Console.ReadLine();
                        Console.WriteLine("Validade:");
                        validade = Console.ReadLine();
                        Console.WriteLine("Cvv:");
                        cvv = Console.ReadLine();

                        IPagamentoFactory pagamentoFactoryCartao = new CartaoFactory(valorCompra, numeroCartao, nomeTitular, validade, cvv);

                        pagamento = pagamentoFactoryCartao.salvarPagamento();
                    }
                    else if (tipoPagamento == 2)
                    {
                        tipoPagamento = int.Parse(Console.ReadLine());

                        IPagamentoFactory pagamentoFactoryDemaisFormasDePagamento = new DemaisFormasDePagamentoFactory(valorCompra, tipoPagamento);

                        pagamento = pagamentoFactoryDemaisFormasDePagamento.salvarPagamento();
                    }
                    else
                    {
                        Console.WriteLine("Pagamento não reconhecido");
                    }
                    pagamentos.Add(pagamento);
                    break;
                case 3:
                    Console.WriteLine("CRUD sessões");
                    Console.WriteLine("Qual o operação deseja realizar?\n1- Cadastrar sessão\n2- Atualizar sessão\n3- Exibir sessão por id\n4- Exibir todas as sessões\n5- Remover sessões");
                    int tipoSessao = int.Parse(Console.ReadLine());

                    if(tipoSessao == 1)
                    {
                        filme = Console.ReadLine();
                        horario = Console.ReadLine();
                        data = DateTime.Parse(Console.ReadLine());
                        cadeiras = int.Parse(Console.ReadLine());

                        var sessao = new Sessao { Id = 1, Filme = filme, Horario = horario, Data = data, Cadeiras = cadeiras};

                        _sessaoRepository.adicionarSessao(sessao);
                    }
                    else if (tipoSessao == 2)
                    {
                        Console.Write("Informe o ID da sessão que deseja atualizar: ");
                        id = int.Parse(Console.ReadLine());

                        Sessao sessao = _sessaoRepository.obterPorId(id);
                        if (sessao == null)
                        {
                            Console.WriteLine("Sessão não encontrada.");
                            return;
                        }

                        Console.Write("Informe o novo nome do filme (ou deixe em branco para manter o atual):");
                        string novoFilme = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(novoFilme))
                        {
                            sessao.Filme = novoFilme;
                        }

                        Console.Write("Informe a nova data da sessão (ou deixe em branco para manter a atual):");
                        string novaData = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(novaData))
                        {
                            sessao.Data = DateTime.Parse(novaData);
                        }

                        Console.Write("Informe a nova data da sessão (ou deixe em branco para manter a atual):");
                        string novoHorario = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(novoHorario))
                        {
                            sessao.Horario = novoHorario;
                        }

                        Console.Write("Informe a nova quantidade de cadeiras (ou deixe em branco para manter a atual):");
                        string novasCadeiras = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(novasCadeiras))
                        {
                            sessao.Cadeiras = int.Parse(novasCadeiras);
                        }

                        _sessaoRepository.atualizarSessao(sessao);

                        Console.WriteLine("Sessão atualizada com sucesso!");
                    }
                    else if(tipoSessao == 3)
                    {
                        Console.Write("Informe o ID da sessão que deseja visualizar: ");
                        id = int.Parse(Console.ReadLine());

                        Sessao sessao = _sessaoRepository.obterPorId(id);
                        if (sessao == null)
                        {
                            Console.WriteLine("Sessão não encontrada.");
                            return;
                        }

                        Console.WriteLine(sessao);
                    } 
                    else if(tipoSessao == 4)
                    {
                        var sessoes = _sessaoRepository.obterTodos();

                        foreach (var sessao in sessoes)
                        {
                            Console.WriteLine(sessao);
                        }
                    }
                    else if(tipoSessao == 5)
                    {
                        Console.WriteLine("Digite o id da sessão que você deseja remover:");
                        id = int.Parse(Console.ReadLine());

                        Sessao sessao = _sessaoRepository.obterPorId(id);
                      
                        _sessaoRepository.removerSessao(id);
                    } 
                    else
                    {
                        Console.WriteLine("Opção não existente!");
                    }
                    break;
                default:

                    break;
            }



        } while (opcao != 0);
    }
}