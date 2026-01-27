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

        public void AggiungiCorso(Corso corso)
        {
            Corsi.Add(corso);
        }

    }
}
