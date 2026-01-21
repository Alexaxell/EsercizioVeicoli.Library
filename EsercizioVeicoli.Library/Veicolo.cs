namespace EsercizioVeicoli.Library
{
    public abstract class Veicolo : IComparable<Veicolo>
    {
        public string Targa { get; set; }
        public string Marca { get; set; }
        public double KmPercorsi { get; set; }
        public double LitriCarburanteConsumato { get; set; }
        public int Cavalli { get; set; }

        public Veicolo() { }

        public Veicolo(string targa, string marca, double kmPercorsi, double litriCarburanteConsumato, int cavalli)
        {
            Targa = targa;
            Marca = marca;
            KmPercorsi = kmPercorsi;
            LitriCarburanteConsumato = litriCarburanteConsumato;
            Cavalli = cavalli;
        }

        public abstract double GetKmPercorsi();

        public abstract double GetLitriCarburanteConsumato();

        public int CompareTo(Veicolo other)
        {
            if (other  == null) 
                return 1;

            if (Cavalli < other.Cavalli) 
                return -1;
            else if (Cavalli > other.Cavalli) 
                return 1;
            else 
                return 0;
        }
    }
}
