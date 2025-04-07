using BibliotecaAcesso.Musicas;
using System;

public class Rock : Musica
{
    public Rock(string titulo) : base(titulo) { }

    public override void Tocar()
    {
        Console.WriteLine($"Tocando rock: {Titulo}");
    }
}

public class Jazz : Musica
{
    public Jazz(string titulo) : base(titulo) { }

    public override void Tocar()
    {
        Console.WriteLine($"Tocando jazz: {Titulo}");
    }
}
