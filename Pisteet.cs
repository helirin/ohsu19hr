using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*kilpailijan pisteitä käsitellään */
namespace Tietokilpailu3
{
    public class Pisteet : IUtelu
    {
        private string[] pistelista;
        private List<string> lista = new List<string>(); 
        //kyselyn pistemäärä ilmoitetaan ja muodostetaan tallennettava merkkijono
        //tämä metodi on käytössä yleiskysymyksissä, joita ei vielä ole
        public virtual string IlmoitaTulos(string user, int pisteet)
        {
            if (pisteet >= 8) 
            {
                Console.WriteLine("\n Mahtavaa, " + user + ", sait " + pisteet + " pistettä!");
            }
            else
               Console.WriteLine("\n Sait " + pisteet + " pistettä, " + user);

            DateTime dt = DateTime.Now;
            string pvm = dt.ToString("d");                   //d lyhyt muoto 26-10-2019, f pitempi muoto
            string tulos = pvm + "; " + user + "; " + pisteet;  //kirjattava tulos
            return tulos;
        }
        //tulos talletaan tiedostoon
        public void KirjaaTulos(string tulos)
        {
            lista.Add(tulos);
            File.AppendAllLines("tulos.txt", lista);
        }
        //Pistetilanne haetaan
        public void Pistetilanne()
        {
            pistelista = File.ReadAllLines("tulos.txt");
            for (int i = 0; i < pistelista.Length; i++)
            {
                Console.WriteLine(pistelista[i]);
            }
        }
    }
}
