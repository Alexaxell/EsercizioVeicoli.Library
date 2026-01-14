using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioVeicoli.Library
{
    public class AutoCarro : Veicolo
    {
        public double CapacitaCaricoTonnelate { get; set; }

        public AutoCarro() {}

        public AutoCarro(string targa, string marca, double kmPercorsi, double carbunteConsumato, double capacitaCaricoTonnellate) :
            base(targa, marca, kmPercorsi, carbunteConsumato)
        {
            CapacitaCaricoTonnelate = capacitaCaricoTonnellate;
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
