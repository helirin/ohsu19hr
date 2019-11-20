using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*Kysymykset vaihtoehtoineen ja vastauksineen haetaan tiedostosta, sekoitetaan, pilkotaan ja kysytään.
 Luokkaa paremmin kuvaava nimi voisi olla kysymyssetti tai kysymyskierros*/
namespace Tietokilpailu3
{
    class Kysymys
    {

        public string[] rivit;

        public string[] LueJaSekoita(string aihe)                   
        {
            rivit = File.ReadAllLines(aihe);         //luetaan tiedostosta rivit taulukkoon
            Random random = new Random();                      //luodaan satunnaismuuttuja
            for (int t = 0; t < rivit.Length; t++)
            {
                string tmp = rivit[t];                 //apumuuttujaan sijoitetaan arvo, joka on ideksissä t
                int r = random.Next(t, rivit.Length);  //otetaan satunnaisluku väliltä t, taulukon koko
                rivit[t] = rivit[r];                    //sijoitetaan indeksiin t saadussa indeksissä oleva arvo
                rivit[r] = tmp;                         //sijoitetaan apimuuttujan arvo indeksiin r
            }
            return rivit;                               //palauttaa taulukon, jonka jokaisessa solussa tiedostosta haettu rivi
        }
        public int Kysele(string[] rivit)
        {
            string vastaus;                                    //vastaus otetaan stringinä, jotta ohjelma ei niin helposti kaadu
            int pisteet = 0;
            for (int i = 0; i < rivit.Length; i++)
            {
                string[] kentat = rivit[i].Split(';');         //pilkotaan kysymysrivi taulukkoon
                Console.WriteLine("\n" + kentat[1]);           //tulostetaan kysymys solusta 1
                Console.WriteLine(kentat[2] + "\n");            //tulostetaan vaihtoehdot solusta 2
                char oikea = char.Parse(kentat[3]);             //otetaan oikea vastaus talteen solusta 3
                vastaus = Console.ReadLine();                   //luetaan vastaajan vastaus
                char merkki = vastaus[0];                       //poimitaan vastauksesta ensimmäinen merkki
                
                if (char.ToUpper(merkki) == oikea)
                {
                    Console.WriteLine("Vastaus " + oikea + " oli oikein");
                    pisteet = pisteet + 1;
                }
                else if (char.ToUpper(merkki) == 'Q')
                {
                    Console.WriteLine(" Päätit lopettaa ");
                    break;
                }
                else
                {
                    Console.WriteLine(" Vastaus oli väärin ja kilpailu päättyi");
                    break;
                }

            }
            
            return pisteet;
        }
    }
}   
