//exemplos de inserções nas classes de Banda//
Banda queen = new("Queen");
Genero rock = new("Rock");
Album albumQueen = new("A night at the opera");

Musica musica1 = new(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
    Genero = rock
};

Musica musica2 = new(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
    Genero = rock
};

albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumQueen.ExibirAlbum();
queen.ExibirDiscograia();

//exemplos de inserções nas classes de Podcast//
Episodio ep1 = new(1, "Banana é gostoso", 35);
ep1.AdicionarCondidados("Sandrinho");
ep1.AdicionarCondidados("Clebinho Mercenário");
ep1.AdicionarCondidados("Carla");

Episodio ep2 = new(2, "Mamão também é gostoso", 32);
ep2.AdicionarCondidados("Clóvis Salgado");
ep2.AdicionarCondidados("Alfredo Alves");

Episodio ep3 = new(3, "Manga é mais gostoso", 30);
ep3.AdicionarCondidados("Luiza");
ep3.AdicionarCondidados("João");
ep3.AdicionarCondidados("Toninho");

Podcast podcast = new("Podcast de Feira", "Mauro Amorinho");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.ExibirDetalhes();