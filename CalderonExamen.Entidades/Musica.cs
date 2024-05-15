namespace CalderonExamen.Entidades
{
    
    public class Musica
    {
        public int MusicaId { get; set; }
        public string Titulo { get; set; }
        public TimeSpan Duracion { get; set; }
        public int ArtistaId { get; set; }

        public Artista Artista { get; set; }
    }
}
