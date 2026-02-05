using GestioneCorsi.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi
{
    public class Corso
    {
        public string Nome { get; set; }
        public int NumeroEdizione { get; set; }
        public List<Lezione> Lezioni { get; set; } = new List<Lezione>();
        public List<Studente> Studenti { get; set; } = new List<Studente>();

        public Corso(string nome, int numeroEdizione)
        {
            Nome = nome;
            NumeroEdizione = numeroEdizione;
        }

        public void AggiungiLezione(Lezione lezione)
        {
            Lezioni.Add(lezione);
        }

        public void AggiungiStudente(Studente studente)
        {
            Studenti.Add(studente);
        }

        public double MediaPresentiALezione()
        {
            int TotalePresenti = 0;
            foreach (Lezione lezione in Lezioni)
            {
                TotalePresenti += Lezioni.Count;
            }
            if (Lezioni.Count < 1)
            {
                return 0;
            }
            return TotalePresenti / Lezioni.Count;
        }

        public override string ToString()
        {
            return $"Il noome del corso e' {Nome} e questa e' la {NumeroEdizione} edizione";
        }
    }
}
