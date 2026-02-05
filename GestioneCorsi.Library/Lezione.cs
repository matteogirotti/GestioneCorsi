using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestioneCorsi.Library
{
    public class Lezione
    {
        public string Descrizione { get; set; }
        public DateTime DataLezione { get; set; }
        public TimeSpan OraInizioLezione { get; set; }
        public TimeSpan DurataLezione { get; set; }
        public Docente Docente { get; set; }
        public Aula AulaAssegnata { get; set; }
        public List<Studente> StudentiPresenti { get; set; } = new List<Studente>();

        public Lezione(string descrizione, DateTime dataLezione, TimeSpan oraInizioLezione, TimeSpan durataLezione, Docente docente, Aula aulaAssegnata)
        {
            Descrizione = descrizione;
            DataLezione = dataLezione;
            OraInizioLezione = oraInizioLezione;
            DurataLezione = durataLezione;
            Docente = docente;
            AulaAssegnata = aulaAssegnata;
        }

        public void SegnaPresenza(Studente studente)
        {
            bool StudenteTrovato = false;
            foreach (Studente s in StudentiPresenti)
            {
                if (s.Matricola == studente.Matricola)
                {
                    StudenteTrovato = true;
                    break;
                }
            }

            if (!StudenteTrovato)
            {
                StudentiPresenti.Add(studente);
            }
        }

        public void SegnaAssenza(Studente studente)
        {
            for(int i = 0; i < StudentiPresenti.Count; i++)
            {
                if(StudentiPresenti[i].Matricola == studente.Matricola)
                {
                    StudentiPresenti.RemoveAt(i);
                    break;
                }
            }
        }

        public override string ToString()
        {
            return $"Descrizione lezione: {Descrizione} " +
                $"\nData lezione: {DataLezione} " +
                $"\nOra di inizio della lezione: {OraInizioLezione} " +
                $"\nDurata lezione: {DurataLezione} " +
                $"\nDocente: {Docente} " +
                $"\nAula: {AulaAssegnata}";
        }
    }
}
