using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yachthafen_TB_CW_JJ
{
     class LiegeplatzData
    {

        int id;
        string bezeichnung;
        double laenge;
        double breite;
        double tiefe;
        double tagespreis;

        public LiegeplatzData(int id, string bezeichnung, double laenge, double breite, double tiefe, double tagespreis)
        {
            this.Id = id;
            this.Bezeichnung = bezeichnung;
            this.Laenge = laenge;
            this.Breite = breite;
            this.Tiefe = tiefe;
            this.Tagespreis = tagespreis;
        }

        public int Id { get => id; set => id = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public double Laenge { get => laenge; set => laenge = value; }
        public double Breite { get => breite; set => breite = value; }
        public double Tiefe { get => tiefe; set => tiefe = value; }
        public double Tagespreis { get => tagespreis; set => tagespreis = value; }
    }
}
