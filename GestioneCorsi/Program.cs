using GestioneCorsi.Library;

namespace GestioneCorsi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestoreCorsi sistema = new GestoreCorsi();
            Docente docente = new Docente("Marco", "Rossi", "Letteratura");
            Aula aula = new Aula(29, "Blu");
            aula.AggiungiRisorsa("Lim");
            aula.AggiungiRisorsa("Proiettore");
            Corso corso = new Corso("Lettere", 5);
            sistema.AggiungiCorso(corso);
            Studente studente1 = new Studente("Matteo", "Girotti", 10154);
            Studente studente2 = new Studente("Marco", "Rossi", 44683);
            Studente studente3 = new Studente("Luca", "Bianchi", 10734);
            corso.AggiungiStudente(studente1);
            corso.AggiungiStudente(studente2);
            corso.AggiungiStudente(studente3);
            Lezione lezione = new Lezione("Oggi facciamo Dante", new DateTime(2026, 01, 26), new TimeSpan(9, 0, 0), new TimeSpan(1, 30, 0), docente, aula);
            corso.AggiungiLezione(lezione);
            lezione.SchedaRiassuntiva(lezione);
        }
    }
}
