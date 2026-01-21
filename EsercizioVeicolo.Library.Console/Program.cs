using EsercizioVeicoli.Library;

namespace EsercizioVeicolo.Library.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var autoveicoloCollection = new Dictionary<string, AutoVeicolo>();
            var autocarroCollection = new Dictionary<string, AutoCarro>();

            string scelta;

            while (true)
            {
                System.Console.WriteLine("1. Inserisci un autoveicolo.");
                System.Console.WriteLine("2. Inserisci un autocarro.");
                System.Console.WriteLine("3. Stampa un autoveicolo a scelta.");
                System.Console.WriteLine("4. stampa un autocarro a scelta.");
                System.Console.WriteLine("5. Chilometri percorsi da un autoveicolo.");
                System.Console.WriteLine("6. Chilometri percorsi da un autocarro.");
                System.Console.WriteLine("7. Litri di carburante consumati da un autoveicolo.");
                System.Console.WriteLine("8. Litri di carburante consumati da un autoveicolo.");
                System.Console.WriteLine("9. Stampa la lista degli autoveicoli.");
                System.Console.WriteLine("10. Stampa la lista degli autocarri.");
                System.Console.WriteLine("11. Rimuovi un autoveicolo.");
                System.Console.WriteLine("12. Rimuovi un autocarro.");
                System.Console.WriteLine("13. Ordina la lista degli autoveicoli per cavalli.");
                System.Console.WriteLine("14. Ordina la lista degli autocarri per cavalli.");
                System.Console.WriteLine("15. Esci.");
                System.Console.WriteLine();
                scelta = System.Console.ReadLine();

                string marca;
                string targa;
                int numeroPosti;
                double kmPercorsi;
                double litriCarburanteConsumato;
                int cavalli;

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
                        System.Console.WriteLine("Inserisci il numero di cavalli: ");
                        cavalli = int.Parse(System.Console.ReadLine());

                        autoveicoloCollection.Add(targa, new AutoVeicolo
                        {
                            Targa = targa,
                            Marca = marca,
                            KmPercorsi = kmPercorsi,
                            LitriCarburanteConsumato = litriCarburanteConsumato,
                            NumeroPosti = numeroPosti,
                            Cavalli = cavalli
                        });

                        System.Console.WriteLine();

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
                        System.Console.WriteLine("Inserisci il numero di cavalli: ");
                        cavalli = int.Parse(System.Console.ReadLine());

                        autocarroCollection.Add(targa, new AutoCarro
                        {
                            Targa = targa,
                            Marca = marca,
                            KmPercorsi = kmPercorsi,
                            LitriCarburanteConsumato = litriCarburanteConsumato,
                            CapacitaCaricoTonnelate = capacitaCaricoTonnellate,
                            Cavalli = cavalli
                        });

                        System.Console.WriteLine();

                        break;

                    case "3":
                        System.Console.WriteLine("Inserisci la targa del veicolo che vuoi ricercare: ");
                        targa = System.Console.ReadLine();

                        if (autoveicoloCollection.ContainsKey(targa))
                        {
                            AutoVeicolo autoveicoloTrovato = autoveicoloCollection[targa];
                            System.Console.WriteLine(autoveicoloTrovato.ToString());
                        }
                        else
                            System.Console.WriteLine("Non è stata trovata nessuna corrispondenza con un autoveicolo.");

                        System.Console.WriteLine();

                        break;

                    case "4":
                        System.Console.WriteLine("Inserisci la targa del veicolo che vuoi ricercare: ");
                        targa = System.Console.ReadLine();

                        if (autocarroCollection.ContainsKey(targa))
                        {
                            AutoCarro autoveicoloTrovato = autocarroCollection[targa];
                            System.Console.WriteLine(autocarroCollection.ToString());
                        }
                        else
                            System.Console.WriteLine("Non è stata trovata nessuna corrispondenza con un autocarro.");

                        System.Console.WriteLine();

                        break;

                    case "5":
                        System.Console.WriteLine("Inserisci la targa del veicolo che vuoi ricercare: ");
                        targa = System.Console.ReadLine();

                        if (autoveicoloCollection.ContainsKey(targa))
                        {
                            AutoVeicolo autoveicoloTrovato = autoveicoloCollection[targa];
                            System.Console.WriteLine($"Chilometri: {autoveicoloTrovato.GetKmPercorsi().ToString()}");
                        }
                        else
                            System.Console.WriteLine("Non è stata trovata nessuna corrispondenza con un autocarro.");

                        System.Console.WriteLine();

                        break;

                    case "6":
                        System.Console.WriteLine("Inserisci la targa del veicolo che vuoi ricercare: ");
                        targa = System.Console.ReadLine();

                        if (autocarroCollection.ContainsKey(targa))
                        {
                            AutoCarro autoveicoloTrovato = autocarroCollection[targa];
                            System.Console.WriteLine($"Chilomerti: {autoveicoloTrovato.GetKmPercorsi().ToString()}");
                        }
                        else
                            System.Console.WriteLine("Non è stata trovata nessuna corrispondenza con un autocarro.");

                        System.Console.WriteLine();

                        break;

                    case "7":
                        System.Console.WriteLine("Inserisci la targa del veicolo che vuoi ricercare: ");
                        targa = System.Console.ReadLine();

                        if (autoveicoloCollection.ContainsKey(targa))
                        {
                            AutoVeicolo autoveicoloTrovato = autoveicoloCollection[targa];
                            System.Console.WriteLine($"Litri: {autoveicoloTrovato.GetLitriCarburanteConsumato().ToString()}");
                        }
                        else
                            System.Console.WriteLine("Non è stata trovata nessuna corrispondenza con un autocarro.");

                        System.Console.WriteLine();

                        break;

                    case "8":
                        System.Console.WriteLine("Inserisci la targa del veicolo che vuoi ricercare: ");
                        targa = System.Console.ReadLine();

                        if (autocarroCollection.ContainsKey(targa))
                        {
                            AutoCarro autoveicoloTrovato = autocarroCollection[targa];
                            System.Console.WriteLine($"Litri: {autoveicoloTrovato.GetLitriCarburanteConsumato().ToString()}");
                        }
                        else
                            System.Console.WriteLine("Non è stata trovata nessuna corrispondenza con un autocarro.");

                        System.Console.WriteLine();

                        break;

                    case "9":
                        foreach (var autoveicolo in autoveicoloCollection)
                        {
                            System.Console.WriteLine(autoveicolo.Value);
                            System.Console.WriteLine();
                        }

                        System.Console.WriteLine();

                        break;

                    case "10":
                        foreach (var autocarro in autocarroCollection)
                        {
                            System.Console.WriteLine(autocarro.Value);
                            System.Console.WriteLine();
                        }

                        System.Console.WriteLine();

                        break;

                    case "11":
                        System.Console.WriteLine("Inserisci il numero di targa dell'autoveicolo che vuoi eliminare:");
                        targa = System.Console.ReadLine();

                        if (autoveicoloCollection.ContainsKey(targa))
                        {
                            AutoVeicolo autoveicoloTrovato = autoveicoloCollection[targa];
                            autoveicoloCollection.Remove(autoveicoloTrovato.ToString());
                        }
                        else
                            System.Console.WriteLine("Non è stata trovata nessuna corrispondenza con un autocarro.");

                        System.Console.WriteLine();

                        break;

                    case "12":
                        System.Console.WriteLine("Inserisci il numero di targa dell'autocarro che vuoi eliminare:");
                        targa = System.Console.ReadLine();

                        if (autocarroCollection.ContainsKey(targa))
                        {
                            AutoCarro autocarroTrovato = autocarroCollection[targa];
                            System.Console.WriteLine($"Litri: {autocarroTrovato.GetLitriCarburanteConsumato().ToString()}");
                        }
                        else
                            System.Console.WriteLine("Non è stata trovata nessuna corrispondenza con un autocarro.");

                        System.Console.WriteLine();

                        break;

                    case "13":
                        if (autoveicoloCollection.Count == 0)
                        {
                            System.Console.WriteLine("La collezione di autoveicoli è vuota");
                            return;
                        }

                        var listaAutoveicoli = new List<AutoVeicolo>(autoveicoloCollection.Values);

                        listaAutoveicoli.Sort();

                        foreach (var autoveicolo in listaAutoveicoli)
                        {
                            System.Console.WriteLine(autoveicolo);
                        }

                        break;

                    case "15":
                        return;

                    default:
                        System.Console.WriteLine("Scelta non valida.");
                        System.Console.WriteLine();

                        break;
                }
            }
        }
    }
}

