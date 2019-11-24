using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*Dynaaminen oliokokoelma, jolle ei toistaiseksi ole käyttöä. Testi*/
namespace Tietokilpailu3
{
    class Kysymyskokoelma
    {
        private List<Kysymys> Kysymykset { get; set; } //property

        private Kysymys jokuKysymys = new Kysymys();
        private Kysymys jokuKysymys2 = new Kysymys();

        public void Lisaa()
        {
            Kysymykset.Add(jokuKysymys);
            Kysymykset.Add(jokuKysymys2);


        }
    }
}
