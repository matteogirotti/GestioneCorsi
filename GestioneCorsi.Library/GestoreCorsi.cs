using GestioneCorsi.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi
{
    public class GestoreCorsi
    {
        public List<Corso> Corsi { get; set; } = new List<Corso>();


        public float MediaPresentiAlCorso()
        {
            int TotalePresenti = 0;
            foreach (Corso corso in Corsi)
            {
                TotalePresenti += corso.Studenti.Count;
            }
            if (Corsi.Count < 1)
            {
                return 0;
            }
            return TotalePresenti / Corsi.Count;
        }

        public void AggiungiCorso(Corso corso)
        {
            Corsi.Add(corso);
        }
    }
}
