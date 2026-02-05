using GestioneCorsi.Library;

namespace GestioneCorsi.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestAggiungiRisorsa()
        {
            Aula aula = new Aula(30, "Aula 1");
            Risorsa risorsa = new Risorsa { Nome = "Lavagna" };
            aula.AggiungiRisorsa(risorsa);
            Assert.AreEqual("Lavagna", aula.Risorse[0].Nome);
        }

        [TestMethod]
        public void TestAggiungiStudente()
        {
            Corso corso = new Corso("Matematica", 1);
            Studente studente = new Studente("Mario", "Rossi", 12345);
            corso.AggiungiStudente(studente);
            Assert.AreEqual("Mario", corso.Studenti[0].Nome);
        }

        [TestMethod]
        public void TestAggiungiLezione()
        {
            var corso = new Corso("Fisica", 1);
            var docente = new Docente("Marco", "Bianchi", "Matematica");
            var aula = new Aula(25, "Aula 2");
            var lezione = new Lezione("Funzioni", DateTime.Now, TimeSpan.FromHours(2), new TimeSpan(10, 0, 0), docente, aula);
            corso.AggiungiLezione(lezione);
            Assert.AreEqual("Funzioni", corso.Lezioni[0].Descrizione);
        }

        [TestMethod]
        public void TestSegnaPresente()
        {
            var docente = new Docente("Lorenzo", "Grossi", "Filosofia");
            var aula = new Aula(20, "Aula Azzurra");
            var lezione = new Lezione("Socrate", DateTime.Now, TimeSpan.FromHours(2), new TimeSpan(11, 0, 0), docente, aula);
            var studente = new Studente("Gianluca", "Verdi", 654321);
            lezione.SegnaPresenza(studente);
            Assert.AreEqual("Gianluca", lezione.StudentiPresenti[0].Nome);
        }

        [TestMethod]
        public void TestSegnaAssente()
        {
            var docente = new Docente("Martina", "Loi", "Astrologia");
            var aula = new Aula(15, "Aula Rossa");
            var lezione = new Lezione("Il sole", DateTime.Now, TimeSpan.FromHours(2), new TimeSpan(12, 0, 0), docente, aula);
            var studente = new Studente("Anna", "Bianchi", 191819);
            lezione.SegnaPresenza(studente);
            lezione.SegnaAssenza(studente);
            Assert.AreEqual(0, lezione.StudentiPresenti.Count);
        }
    }
}

        
