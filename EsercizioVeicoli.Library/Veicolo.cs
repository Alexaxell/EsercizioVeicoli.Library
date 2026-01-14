namespace EsercizioVeicoli.Library
{
    public abstract class Veicolo
    {
        public string Targa { get; set; }
        public string Marca { get; set; }
        public double KmPercorsi { get; set; }
        public double LitriCarburanteConsumato { get; set; }

        public Veicolo() { }

        public Veicolo(string targa, string marca, double kmPercorsi, double litriCarburanteConsumato)
        {
            Targa = targa;
            Marca = marca;
            KmPercorsi = kmPercorsi;
            LitriCarburanteConsumato = litriCarburanteConsumato;
        }

        public abstract double GetKmPercorsi();

        public abstract double GetLitriCarburanteConsumato();
    }
}
