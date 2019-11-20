using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Käyttöliittymä, joka sisältää alkutekstit, tiedostonimet ja toiminnalliset valinnat */
namespace Tietokilpailu3
{
    public class Aloitus
    {
        private string alkuteksti = "TIETOKILPAILU \n**************\nVoit valita vastattavaksi yhden aihealueen kerrallaan\n" +
            "10 kysymystä sisältävä kilpailu päättyy väärään vastaukseen tai Q-kirjaimella\n" 
            + "Voit tarkastella myös pelkästään pistetilannetta"; 

        private string valintatext = "Valitse:\n1 Luonto\n2 Tekniikka\n3 Pistetilanne\n4 Lopetus";
        private readonly string aihe1 = "luonto.txt";
        private readonly string aihe2 = "tekniikka.txt";
        private string nimi ="";
      
        private readonly Kysymys kysymys = new Kysymys();  //luodaan Kysymys-tyyppinen olio kysymys
        private readonly Pisteet pisteet = new Pisteet();   //luodaan Pisteet-tyyppinen olio pisteet
        private readonly Luontopisteet luontopisteet = new Luontopisteet();
        private readonly Tekniikkapisteet tekniikkapisteet = new Tekniikkapisteet();
        private int pistemaara = 0;

        //public Aloitus() { }             //konstrukstori

        //tulostetaan aloitusteksti
        public void Tulosta()
        {
            Console.WriteLine(alkuteksti);
        }
        //kysytään käyttäjän nimi
        public string AnnaNimi()
        {
            Console.WriteLine("Anna nimesi");
            nimi = Console.ReadLine();
            return nimi;
        }
        //Valikko
        public void Valitse()
        {
            Console.WriteLine(valintatext);
            
            try
            {
                int valinta1 = int.Parse(Console.ReadLine());
                switch (valinta1)
                {
                    case 1:
                        //luonto-aiheiset kysymykset 
                        Kysy(aihe1);
                        //tallennetaan pisteet
                        string tulos = luontopisteet.IlmoitaTulos(nimi, pistemaara);
                        Pisteyta(tulos);
                        break;
                    case 2:
                        //tekniikka-aiheiset kysymykset
                        Kysy(aihe2);
                        string tulos2 = tekniikkapisteet.IlmoitaTulos(nimi, pistemaara);
                        Pisteyta(tulos2);
                        break;
                    case 3:
                        //kilpailijoiden pisteiden tarkastelu
                        pisteet.Pistetilanne();
                        break;
                    case 4:
                        Console.WriteLine("Päätit lopettaa");
                        break;
                    default:
                        Console.WriteLine("En saanut selvää valinnasta");
                        break;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Virhetilanne!");
            }
            
        }
        //Kysellään sekoitetut kysymykset kysymys-oliota käyttäen
        public int Kysy(string aihe)
        {
            
            String[] rivit = kysymys.LueJaSekoita(aihe);
            pistemaara = kysymys.Kysele(rivit);
            return pistemaara;
        }
        //Tallennetaan tulos pisteet-olion avulla
        public void Pisteyta(string tulos)
        {
            
            //string tulos = pisteet.IlmoitaTulos(nimi, pistemaara);
            pisteet.KirjaaTulos(tulos);
            
        }
    }
    
}
