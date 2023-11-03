class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao) / 60;

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    
    public void ExibirAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
            Console.WriteLine($"Duração: {musica.Duracao}");
            Console.WriteLine($"Genero: {musica.Genero.Nome}");
        }
        Console.WriteLine($"O álbum tem duração de {DuracaoTotal} minutos");
    }
}