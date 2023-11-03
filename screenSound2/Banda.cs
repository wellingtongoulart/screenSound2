class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    private List<Album> albums = new List<Album>();

    public void AdicionarAlbum(Album album) 
    {
        albums.Add(album);
    }

    public void ExibirDiscograia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (var album in albums)
        {
            Console.WriteLine($"{album.Nome}, duração: {album.DuracaoTotal} minutos");
        }
    }
}