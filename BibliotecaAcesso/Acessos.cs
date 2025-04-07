using System;

public class InfosMusicais
{
    public static string Publico = "Disponível ao público";
    private static string Privado = "Somente para colecionadores";
    protected static string Protegido = "Exclusivo para membros";
    internal static string Interno = "Uso interno de gravadora";
    protected internal static string ProtegidoInterno = "Pré-lançamento restrito";
    private protected static string PrivadoProtegido = "Arquivo confidencial";

    public static void MostrarAcessos()
    {
        Console.WriteLine(Publico);
        Console.WriteLine(Interno);
        Console.WriteLine(ProtegidoInterno);
    }
}
