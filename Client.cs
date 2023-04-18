using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES3
{
    class Client
    {
        //
        public string nom;
        public string prenom;
        public string courriel;
        public string carteCredit;
        public int numeroChambre;

        public Client(string nom, string prenom, string courriel, string carteCredit, int numeroChambre)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.courriel = courriel;
            this.carteCredit = carteCredit;
            this.numeroChambre = numeroChambre;
        }
    }
}
