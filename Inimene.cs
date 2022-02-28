using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasside_loomine
{
    class Inimene
    {
        string perenimi;
        string staatus;
        int vanus;
        int palk;
        public int Pikkus;
        public int Kaal;
        public Inimene() { }
        public Inimene(string Perenimi)
        {
            perenimi = Perenimi;
        }
        public string Perenimi
        {
            set { if (perenimi == null) perenimi = value; }
            get { return perenimi; }
        }
        public int Palk
        {
            set
            {
                Console.WriteLine("Mis on teie brutopalk?");
                int vastama = int.Parse(Console.ReadLine());
                if (vastama==0)
                {
                    Console.WriteLine("Okey. Sul pole palka.");
                }
                else if (vastama<500)
                {
                    Console.WriteLine("Teil on miinimumpalk.");
                }
                else
                {

                }
            }
            get { return palk; }
        }
        public int Vanus
        {
            set 
            {
                vanus = value;
                if (vanus<7)
                {
                    staatus = "laps";
                }
                else if (vanus<17)
                {
                    staatus = "koolilaps";
                }
                else if (vanus<24)
                {
                    staatus = "ülikoolilaps";
                }
                else
                {
                    staatus = "tööline";
                }
            }
            get { return vanus; }
        }
        public string Staatus
        {
            get { return staatus; }
        }
        public void Tervitamine()
        {
            Console.WriteLine("Tere! Minu perenimi on "+ perenimi);
            Console.WriteLine("Ma olen {0} aastat vana, olen {1}", vanus, staatus);
        }
    }
}
