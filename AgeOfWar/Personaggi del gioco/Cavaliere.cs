using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfWar.Personaggi_del_gioco
{
    public class Cavaliere:Personaggio
    {
        public string Squadra { get; set; }
        public Cavaliere(int PForza)
        {
            PuntiSalute = 1000; // E' enorme, colossale
            PuntiForza =100 + PForza;  // Non è fortissimo
            Velocita = 3; // La sua armatura pesa parecchio
            Difesa = 50; // Ha una grossa armatura
            Razza = "Umano"; // E' un umano
            

        }

    }
}
