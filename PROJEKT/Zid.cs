using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEKT
{
    public class Zid
    {
        
        public string Police(int zid, int m, int n)
        {
            //polica m je uvijek manja od n
            //inicijaliziramo izlazne varijable
            int broj_m = 0, broj_n = 0, prazno = zid;

            // p i q su broj polica dužine m i n 
            // prazan_p je prazan prostor
            int p = 0, q = 0, prazan_p;

            while (zid >= n)
            {
                //postaviti koliko god je moguće polica dužine m u preostali prostor 
                p = zid / m;
                prazan_p = zid % m;

                // azuriraj izlazne varijable ako je prazan_p <= prazno 
                if (prazan_p <= prazno)
                {
                    broj_m = p;
                    broj_n = q;
                    prazno = prazan_p;
                }

                // postavi još jednu policu dužine n 
                q += 1;
                zid = zid - n;
            }
            string rez = "Broj polica dužine " + m + ": " + broj_m + "\nBroj polica dužine " + n + ": " + broj_n + "\nPrazan prostor: " + prazno;
            return rez ;
        }
    }
}
