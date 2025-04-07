using BibliotecaAcesso.Musicas;


class Program
{
    static void Main()
    {
        Musica m1 = new Rock("Bohemian Rhapsody");
        Musica m2 = new Jazz("Take Five");

        m1.Tocar();
        m2.Tocar();

        InfosMusicais.MostrarAcessos();
    }
}
