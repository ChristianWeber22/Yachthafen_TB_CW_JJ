using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yachthafen_TB_CW_JJ
{
    class Kunde
    {
        int id;
        string name;
        string telefonnummer;
        string yachtname;
        double yachtlaenge;
        double yachtbreite;
        double yachttiefe;

        public Kunde()
        {
        }

        public Kunde(int id, string name, string telefonnummer, string yachtname, double yachtlaenge, double yachtbreite, double yachttiefe)
        {
            this.Id = id;
            this.Name = name;
            this.Telefonnummer = telefonnummer;
            this.Yachtname = yachtname;
            this.Yachtlaenge = yachtlaenge;
            this.Yachtbreite = yachtbreite;
            this.Yachttiefe = yachttiefe;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Telefonnummer { get => telefonnummer; set => telefonnummer = value; }
        public string Yachtname { get => yachtname; set => yachtname = value; }
        public double Yachtlaenge { get => yachtlaenge; set => yachtlaenge = value; }
        public double Yachtbreite { get => yachtbreite; set => yachtbreite = value; }
        public double Yachttiefe { get => yachttiefe; set => yachttiefe = value; }
    }
}
