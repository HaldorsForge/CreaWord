using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaWordv4
{
    class myListClass
    {
        //Thema = ID, BEZ
        //Kategorie = ID, BEZ, Thema
        //Wort = ID, BEZ, Kategorie
        //Wortauswahl = ID, Wort
        //Favorit = ID, Wortauswahl
        //Liste = ID, Titel, Wortauswahl, Favorit

        public String Name { get; set; }
        //public String Titel { get; set; }
        public long ID { get; set; }
    }
}
