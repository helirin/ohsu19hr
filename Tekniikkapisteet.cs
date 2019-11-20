using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Perii pisteet-luokan. Antaa palautteen ja muodostaa tallennettavan merkkijonon *///
namespace Tietokilpailu3
{
    class Tekniikkapisteet : Pisteet
    {
        private string aihealue = "Tekniikka";
        
        //ylikirjoitetaan pisteet-luokan metodi: eri viesti ja aihealue lisätty
        public override string IlmoitaTulos(string user, int pisteet)
        {
            if (pisteet >= 8)
            {
                Console.WriteLine("\n Olet oikea tekniikkatietäjä, " + user + ", sait " + pisteet + " pistettä!");
            }
            else
                Console.WriteLine("\n Tiedät jotain tekniikasta, sait " + pisteet + " pistettä, " + user);

            DateTime dt = DateTime.Now;
            string pvm = dt.ToString("d");
            string tulos = pvm + "; " + aihealue + "; " + user + "; " + pisteet;  //kirjattava tulos
            return tulos;

        }
    }
}
