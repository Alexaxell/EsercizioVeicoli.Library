using EsercizioVeicoli.Library;

namespace EsercizioVeicolo.Library.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listAutoveicoli = new List<AutoVeicolo>();
            var listaAutocarri = new List<AutoCarro>();

            string scelta;

            while (true)
            {
                System.Console.WriteLine("1. Inserisci un autoveicolo.");
                System.Console.WriteLine("2. Inserisci un autocarro.");
                System.Console.WriteLine("3. Stampa un autoveicolo a scelta.");
                System.Console.WriteLine("3. stampa un autocarro a scelta.");
                System.Console.WriteLine("3. Esci.");
                scelta = System.Console.ReadLine();

                string marca;
                string targa;
                int numeroPosti;
                double kmPercorsi;
                double litriCarburanteConsumato;

                switch (scelta)
                {
                    case "1":
                        System.Console.WriteLine("Inserisci il numero di targa: ");
                        targa = System.Console.ReadLine();
                        System.Console.WriteLine("Inserisci la marca del veicolo: ");
                        marca = System.Console.ReadLine();
                        System.Console.WriteLine("Inserisci il numero di chilometri percorsi: ");
                        kmPercorsi = double.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("Inserisci il numero di litri di carburante consumati: ");
                        litriCarburanteConsumato = double.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("Inserisci il numero di posti dell'autoveicolo: ");
                        numeroPosti = int.Parse(System.Console.ReadLine());

                        listAutoveicoli.Add(new AutoVeicolo
                        {
                            Targa = targa,
                            Marca = marca,
                            KmPercorsi = kmPercorsi,
                            LitriCarburanteConsumato = litriCarburanteConsumato,
                            NumeroPosti = numeroPosti
                        });

                        break;

                    case "2":
                        System.Console.WriteLine("Inserisci il numero di targa: ");
                        targa = System.Console.ReadLine();
                        System.Console.WriteLine("Inserisci la marca del veicolo: ");
                        marca = System.Console.ReadLine();
                        System.Console.WriteLine("Inserisci il numero di chilometri percorsi: ");
                        kmPercorsi = double.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("Inserisci il numero di litri di carburante consumati: ");
                        litriCarburanteConsumato = double.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("Inserisci la capacità del carico di tonnellate dell'autocarro: ");
                        double capacitaCaricoTonnellate = double.Parse(System.Console.ReadLine());

                        listaAutocarri.Add(new AutoCarro
                        {
                            Targa = targa,
                            Marca = marca,
                            KmPercorsi = kmPercorsi,
                            LitriCarburanteConsumato = litriCarburanteConsumato,
                            CapacitaCaricoTonnelate = capacitaCaricoTonnellate
                        });

                        break;

                    case "3":
                        return;
                }
            }
        }
    }
}

