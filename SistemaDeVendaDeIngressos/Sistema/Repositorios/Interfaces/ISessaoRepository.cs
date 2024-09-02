using Sistema.Modelos.Sessoes;

namespace Sistema.Repositorios.Interfaces;
public interface ISessaoRepository
{
    void adicionarSessao(Sessao sessao);
    void atualizarSessao(Sessao sessao);
    void removerSessao(int id);
    Sessao obterPorId(int id);
    IEnumerable<Sessao> obterTodos();
}
