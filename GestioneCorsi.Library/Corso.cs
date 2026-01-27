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

        /*public double MediaPresentiAlCorso()
        {
            if(Lezioni.Count == 0)
            {
                throw new Exception("Non c'e' ancora stata nessuna lezione.");
            }
            int SommaPersonePresenti = 0;
            foreach(Lezione lezione in Lezioni)
            {
                SommaPersonePresenti += lezione.NumeroPresenti;
            }
            double Media = (double)SommaPersonePresenti / (double)Lezioni.Count;
            return Media;
        }*/

        public override string ToString()
        {
            return $"Il corso {Nome} e' la {NumeroEdizione} edizione";
        }
    }
}
