using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yachthafen_TB_CW_JJ
{
     class BuchungData
    {
        int id;
        int idKunde;
        int idLiegeplatz;
        DateTime startdatum;
        DateTime enddatum;
        double preis;

        public BuchungData(int id, int idKunde, int idLiegeplatz, DateTime startdatum, DateTime enddatum, double preis)
        {
            this.Id = id;
            this.IdKunde = idKunde;
            this.IdLiegeplatz = idLiegeplatz;
            this.Startdatum = startdatum;
            this.Enddatum = enddatum;
            this.Preis = preis;
        }

        public int Id { get => id; set => id = value; }
        public int IdKunde { get => idKunde; set => idKunde = value; }
        public int IdLiegeplatz { get => idLiegeplatz; set => idLiegeplatz = value; }
        public DateTime Startdatum { get => startdatum; set => startdatum = value; }
        public DateTime Enddatum { get => enddatum; set => enddatum = value; }
        public double Preis { get => preis; set => preis = value; }
    }
}
