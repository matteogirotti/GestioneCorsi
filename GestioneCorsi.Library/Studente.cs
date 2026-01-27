using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Matricola { get; set; }

        public Studente(string nome, string cognome, int matricola)
        {
            Nome = nome;
            Cognome = cognome;
            Matricola = matricola;
        }

        public override string ToString()
        {
            return $"Lo studente si chiama {Nome} {Cognome} e la sua matricola e' {Matricola}";
        }
    }
}
