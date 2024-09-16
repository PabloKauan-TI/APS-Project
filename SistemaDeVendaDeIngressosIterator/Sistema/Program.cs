using SistemaDeVendaDeIngressos;

namespace Sistema;
class Program
{
    static void Main(string[] args)
    {
        SistemaPrograma sistema = new SistemaPrograma();

        sistema.criarUsuarios();
        sistema.exibirUsuarios();
    }
}
