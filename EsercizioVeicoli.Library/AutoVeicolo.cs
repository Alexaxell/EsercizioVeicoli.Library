using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioVeicoli.Library
{
    internal class AutoVeicolo : Veicolo
    {
        public int NumeroPosti { get; set; }

        public AutoVeicolo() { }

        public AutoVeicolo(string targa, string marca, double kmPercorsi, double carburanteConsumatoConsumato, int numeroPosti) :
                    base(targa, marca, kmPercorsi, carburanteConsumatoConsumato)
        {
            NumeroPosti = numeroPosti;
        }

        public override double GetKmPercorsi()
        {
            return KmPercorsi;
        }

        public override double GetLitriCarburanteConsumato()
        {
            return LitriCarburanteConsumato;
        }
    }
}
