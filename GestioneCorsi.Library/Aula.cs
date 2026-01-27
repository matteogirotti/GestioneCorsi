using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class Aula
    {
        public int Capienza { get; set; }
        public string Nome { get; set; }
        public List<string> Risorse { get; set; } = new List<string>();

        public Aula(int capienza, string nome)
        {
            Capienza = capienza;
            Nome = nome;
        }

        public void AggiungiRisorsa(string risorsa)
        {
            if (!Risorse.Contains(risorsa))
            {
                Risorse.Add(risorsa);
            }
        }

        public override string ToString()
        {
            return $"L'aula {Nome} ha una capienza di {Capienza} persone e ha {Risorse}";
        }
    }
}
