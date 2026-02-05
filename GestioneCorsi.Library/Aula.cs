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
        public List<Risorsa> Risorse { get; set; } = new List<Risorsa>();

        public Aula(int capienza, string nome)
        {
            Capienza = capienza;
            Nome = nome;
        }

        public void AggiungiRisorsa(Risorsa risorsa)
        {
            Risorse.Add(risorsa);
        }
        public override string ToString()
        {
            return $"Il nome dell'aula e' {Nome} e ha una capienza di {Capienza} persone";
        }
    }
}
