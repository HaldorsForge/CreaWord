using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaWordv4
{
    class BgImages
    {
        public string Session()
        {
            //Monatserkennung funktoniert
            //Image wird nicht angezeigt -> falsche Pfad??
            DateTime d = DateTime.Now; // frühling(3-5), sommer(6-8), herbst(9-11), winter(12-2)
            int month = d.Month;
            if (month >= 3 && month <= 5)
            {
                return ("Frühling");
            }
            else if (month >= 6 && month <= 8)
            {
                return ("Sommer");
            }
            else if (month >= 9 && month <= 11)
            {
                return ("Herbst");
            }
            else
            {
                return ("Winter");
            }
        }
    }
}
