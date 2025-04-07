namespace BibliotecaAcesso.Musicas
{
    public abstract class Musica
    {
        public string Titulo { get; set; }
        protected string Compositor { get; set; }
        internal int DuracaoSegundos { get; set; }
        protected internal string Estilo { get; set; }
        private protected int AnoLancamento { get; set; }

        public Musica(string titulo)
        {
            Titulo = titulo;
        }

        public abstract void Tocar();
    }
}
