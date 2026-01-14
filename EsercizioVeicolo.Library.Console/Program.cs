using EsercizioVeicoli.Library;

namespace EsercizioVeicolo.Library.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Inserisci il tipo di veicolo desiderato: ");
            string TipoVeicolo = System.Console.ReadLine();

            if (TipoVeicolo.Equals("Autoveicolo", StringComparison.CurrentCultureIgnoreCase))
            {
                System.Console.WriteLine("Inserisci il numero di targa: ");
                string targa = System.Console.ReadLine();
                System.Console.WriteLine("Inserisci la marca del veicolo: ");
                string marca = System.Console.ReadLine();
                System.Console.WriteLine("Inserisci il numero di chilometri percorsi: ");
                double kmPercorsi = double.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Inserisci il numero di litri di carburante consumati: ");
                double litriCarburanteConsumato = double.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Inserisci il numero di posti dell'autoveicolo: ");
                int numeroPosti = int.Parse(System.Console.ReadLine());

                var autoveicolo = new AutoVeicolo()
                {
                    Targa = targa,
                    Marca = marca,
                    KmPercorsi = kmPercorsi,
                    LitriCarburanteConsumato = litriCarburanteConsumato,
                    NumeroPosti = numeroPosti
                };
            }
            else if (TipoVeicolo.Equals("Autocarro", StringComparison.CurrentCultureIgnoreCase))
            {
                System.Console.WriteLine("Inserisci il numero di targa: ");
                string targa = System.Console.ReadLine();
                System.Console.WriteLine("Inserisci la marca del veicolo: ");
                string marca = System.Console.ReadLine();
                System.Console.WriteLine("Inserisci il numero di chilometri percorsi: ");
                double kmPercorsi = double.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Inserisci il numero di litri di carburante consumati: ");
                double litriCarburanteConsumato = double.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Inserisci la capacità del carico di tonnellate dell'autocarro: ");
                double capacitaCaricoTonnellate = double.Parse(System.Console.ReadLine());

                var autocarro = new AutoCarro()
                {
                    Targa = targa,
                    Marca = marca,
                    KmPercorsi = kmPercorsi,
                    LitriCarburanteConsumato = litriCarburanteConsumato,
                    CapacitaCaricoTonnelate = capacitaCaricoTonnellate
                };
            }
        }
    }
}
