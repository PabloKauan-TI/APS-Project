namespace Sistema.Modelos;
public class Cadeira
{
    public int Id { get; set; }
    public int Fila { get; set; }
    public int Numero { get; set; }
    public int Sessao { get; set; }
    public bool Estado { get; set; }
    public Cadeira(int fila, int numero, int sessao, bool estado)
    {
        Fila = fila;
        Numero = numero;
        Sessao = sessao;
        Estado = estado;
    }
    public bool checarEstado()
    {
        return Estado;
    }
    public void alterarEstado(bool estado)
    {
        Estado = estado;
    }
}
