using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Perii pisteet-luokan. Antaa käyttäjälle palautteen ja muodostaa tallennettavan merkkijonon */
namespace Tietokilpailu3
{
    class Luontopisteet : Pisteet
    {
        private string aihealue = "luonto";
       //ylikirjoitetaan ylemmän luokan metodi
        public override string IlmoitaTulos(string user, int pisteet)
        {
            if (pisteet >= 8)
            {
                Console.WriteLine("\n Olet selvästi luontoihminen , " + user + ", sait " + pisteet + " pistettä!");
            }
            else
                Console.WriteLine("\n Lähde luontoon, sait " + pisteet + " pistettä, " + user);

            DateTime dt = DateTime.Now;
            string pvm = dt.ToString("d");                   
            string tulos = pvm + "; " + aihealue + "; " + user + "; " + pisteet;  //kirjattava tulos
            return tulos;
            
        }
    }
}
