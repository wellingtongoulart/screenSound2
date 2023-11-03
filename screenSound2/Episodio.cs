class Episodio
{
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    private List<string> convidados = new();
    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"{Ordem}. {Titulo}\nDuração: ({Duracao}) min.\nConvidados: {string.Join("\n  ", convidados)}.";

    public void AdicionarCondidados(string convidado)
    {
        convidados.Add(convidado);
    }
}