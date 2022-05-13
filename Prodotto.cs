using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        public int Codice { get; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }

        private double iva;
        public double Iva 
        {
            get { return iva; }
            set { iva = value; } 
        }

        private Random myRandom = new Random();


        public Prodotto(string nome, string descrizione, double prezzo, double iva)
        {
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Iva = iva;
            Codice = myRandom.Next();
        }

        public double GetPrezzoNonIvato()
        {
            return Prezzo;
        }
        public double GetPrezzoIvato()
        {
            return Prezzo * (1.0 + Iva);
        }
        public string GetNomeProdotto()
        {
            return String.Format("Nome esteso: {0}_{1}", Codice, Nome);
        }
    }
}
