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

        public string SchedaRiassuntiva(Lezione lezione)
        {
            return $"Lezione: {Descrizione}\n" +
            $"Data: {DataLezione} Ore: {OraInizioLezione}\n" +
            $"Durata: {DurataLezione}\n" +
            $"Docente: {Docente.Nome} {Docente.Cognome}\n" +
            $"Aula: {AulaAssegnata.Nome} (Capienza: {AulaAssegnata.Capienza})\n"; //+
           // $"Presenti: {NumeroPresenti}";
        }

        public override string ToString()
        {
            return $"La lezione di {Descrizione} era il {DataLezione} alle {OraInizioLezione} e' durata {DurataLezione}, ed e' stata tenuta dal {Docente} nell'aula {AulaAssegnata}";
        }
    }
}
