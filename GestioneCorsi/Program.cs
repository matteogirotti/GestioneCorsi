using GestioneCorsi.Library;
using System.Reflection.Metadata;

namespace GestioneCorsi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestoreCorsi GestoreCorsi = new GestoreCorsi();
            Corso corso = new Corso("Lettere", 5);
            GestoreCorsi.AggiungiCorso(corso);
            Studente studente1 = new Studente("Matteo", "Girotti", 10154);
            Studente studente2 = new Studente("Marco", "Rossi", 44683);
            Studente studente3 = new Studente("Luca", "Bianchi", 10734);
            corso.AggiungiStudente(studente1);
            corso.AggiungiStudente(studente2);
            corso.AggiungiStudente(studente3);
            Docente docente = new Docente("Marco", "Rossi", "Letteratura");
            Aula aula = new Aula(29, "Blu");
            aula.AggiungiRisorsa(new Risorsa { Nome = "Lim"});
            Lezione lezione = new Lezione("Dante", DateTime.Now, new TimeSpan(9, 0, 0), new TimeSpan(1, 30, 0), docente, aula);
            lezione.StudentiPresenti.Add(studente1);
            lezione.StudentiPresenti.Add(studente2);
            lezione.StudentiPresenti.Add(studente3);
            corso.AggiungiLezione(lezione);
            Console.WriteLine("Studenti presenti a lezione: ");
            foreach (Studente studente in lezione.StudentiPresenti)
            {
                Console.WriteLine(studente);
            }
            Console.WriteLine("\nDettagli corso: ");
            foreach (Corso c in GestoreCorsi.Corsi)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("\nElenco studenti: ");
            foreach( Studente s in corso.Studenti)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\nElenco lezioni con desccrizione: ");
            foreach (Lezione l in corso.Lezioni)
            {
                Console.WriteLine(l);
            }
        }
    }
}
