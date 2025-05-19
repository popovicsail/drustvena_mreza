namespace drustvena_mreza.Models
{
    public class Grupa
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public DateTime DatumOsnivanja { get; set; }
        public List<Korisnik> Korisnik { get; set; } = new List<Korisnik>();

        public Grupa(int id, string ime, DateTime datumOsnivanja)
        {
            Id = id;
            Ime = ime;
            DatumOsnivanja = datumOsnivanja;
        }
        public string FormatZaSave()
        {
            return $"{Id},{Ime},{Ime},{DatumOsnivanja}";
        }

    }
}
