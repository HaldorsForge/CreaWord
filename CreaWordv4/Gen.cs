using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaWordv4
{
    class Gen
    {
        public static int GenInt(/*int x, */int y)  //x=test / y=Gesamtanzahl Wörter der gewählten Kategorie
        {
            Random zufall = new Random();
            //int[] z = new int[x];   //z=array zufallszahlen (test)

            //x = x + 1;
            //for (int i = 0; i < x; i++)
            //{

                int k = zufall.Next(1, y);
               // z[i] = k;
               /* for (int a = 0; a == x; i++)
                {
                    if (z[a] == z[x])
                    {
                        z[x] = zufall.Next(1, y);
                    }
                    else
                    {
                        Console.WriteLine(z[x].ToString());
                        Console.ReadKey();
                    }
                }*/
            //}
          
            return (1);
        }

    }
}
