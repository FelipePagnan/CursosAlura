using System;
using System.Collections.Generic;

class Program
{
    private static void Main(string[] args)
    {
        Episodio ep1 = new Episodio(1, "Tecnicas de facilidade", 45);
        ep1.AdicionarConvidados("Pagnan");
        ep1.AdicionarConvidados("Felipe");
        Console.WriteLine(ep1.Resumo);

        Episodio ep2 = new Episodio(2, "Tecnicas de aprendizado", 67);
        ep2.AdicionarConvidados("Pagnan");
        ep2.AdicionarConvidados("Thomas");
        Console.WriteLine(ep2.Resumo);

        Podcast podcast = new Podcast("PagnanCast especial", "Pagnan");
        podcast.AdicionarEpisodio(ep1);
        podcast.AdicionarEpisodio(ep2);
        podcast.ExibirDetalhes();

        Console.ReadLine();
    }
}