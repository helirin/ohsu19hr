using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*Ohjelma tulostaa käyttäjälle ohjeet, kysyy käyttäjän nimeä ja lukee sen. Sitten ohjelma tulostaa valintavaihtoehdot. 
 Vaihtoehdot ovat: 1 luonto, 2 tekniikka, 3 pisteet ja 4 lopetus. Jos käyttäjä valitsee 1 tai 2, häneltä kysytään 
 max. 10 kysymystä. Sen jälkeen pisteet tallenetaan tiedostoon. Tallennetut pisteet pystyy katsomaan, valitsemalla 3
 Kysymykset on tallennettu etukäteen tiedostoon, jonka yksi rivi sisältää kysymyksen, vaihtoehdot ja oikean vastauksen.*///
namespace Tietokilpailu3
{
    class Program
    {
        //private static Kysymyskokoelma kysymyskokoelma = new Kysymyskokoelma();
        static void Main(string[] args)
        {
            //käyttöliittymä ja alkutekstit
            Aloitus aloitus1 = new Aloitus();
            aloitus1.Tulosta();
            //luetaan käyttäjän nimi
            aloitus1.AnnaNimi();
            //valinta
            aloitus1.Valitse();
         
            //tietokilpalu toimii aloitusvalikon kautta
     
            Console.ReadLine();
        }
    }
}
