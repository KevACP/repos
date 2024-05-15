namespace CalderonExamen.Entidades
{
    public class Artista
    {
        public int ArtistaId { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string PaisOrigen { get; set; }

        public ICollection<Musica> Musicas { get; set; }
    }
}
