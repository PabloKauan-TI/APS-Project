using Sistema.Modelos.Sessoes;
using Sistema.Repositorios.Interfaces;

namespace Sistema.Repositorios;
internal class SessaoRepository : ISessaoRepository
{
    private List<Sessao> sessoes = new List<Sessao>();
    public void adicionarSessao(Sessao sessao)
    {
        sessoes.Add(sessao);
    }
    public void atualizarSessao(Sessao sessao)
    {
        var existente = sessoes.FirstOrDefault(s => s.Id == sessao.Id);
        if (existente != null)
        {
            existente.Filme = sessao.Filme;
            existente.Data = sessao.Data;
            existente.Horario = sessao.Horario;
            existente.Cadeiras = sessao.Cadeiras;
        }
    }
    public void removerSessao(int id)
    {
        var sessao = sessoes.FirstOrDefault(s => s.Id == id);
        if (sessao != null)
        {
            sessoes.Remove(sessao);
        }
    }
    public Sessao obterPorId(int id)
    {
        return sessoes.FirstOrDefault(s => s.Id == id);
    }
    public IEnumerable<Sessao> obterTodos()
    {
        return sessoes;
    }
}
