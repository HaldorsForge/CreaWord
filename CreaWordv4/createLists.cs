using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaWordv4
{
    class listThema
    {
        //Thema = ID, BEZ
        public int ID { get; set; }
        public String BEZ { get; set; }
    }
    class listKategorie
    {
        //Kategorie = ID, BEZ, Thema
        public int ID { get; set; }
        public String BEZ { get; set; }
    }
    class listWort
    {
        //Wort = ID, BEZ, Kategorie
        public int ID { get; set; }
        public String BEZ { get; set; }
    }
    class listFavorit
    {
        //Favorit = ID, Wortauswahl
        public int ID { get; set; }
        public String Auswahl { get; set; }
    }
    class listListe
    {
        //Liste = ID, Titel, Wortauswahl, Favorit
        public int ID { get; set; }
        public String Titel { get; set; }
        public String Auswahl { get; set; }
    }
}
