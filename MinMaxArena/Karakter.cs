using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxArena
{
    public class Karakter
    {
        public enum KarakterTipi
        {
            Savasci,
            Sihirbaz,
            Okcu
        }
        
        public int Seviye;
        public string Ad;
        public KarakterTipi Tipi;
        public int Saglik;
        public int MaxSaglik;
        public int MinAtak;
        public int MaxAtak;
        public int Xp;
        public int SonrakiSeviyeXpDegeri;
        public Image savunma;
        public Image bitis;
        public Image saldiri;
       

        public Karakter()
        {

        }

        public Karakter(string ad, KarakterTipi tip)
        { 
            Ad = ad;
            Seviye = 0;
            Xp = 0;
            Tipi = tip;
            SonrakiSeviyeXpDegeri = 100 + (Seviye - 1) * 50;
            switch (Tipi)
            {
                case KarakterTipi.Savasci:
                    MaxSaglik = 100;
                    MinAtak = 8;
                    MaxAtak = 18;
                    saldiri = (Image)Properties.Resources.ResourceManager.GetObject("savasci1");
                    savunma = (Image)Properties.Resources.ResourceManager.GetObject("savasci2");
                    bitis = (Image)Properties.Resources.ResourceManager.GetObject("savasci3");
                    break;
                case KarakterTipi.Sihirbaz:
                    MaxSaglik = 100;
                    MinAtak = 12;
                    MaxAtak = 20;
                    saldiri = (Image)Properties.Resources.ResourceManager.GetObject("sihirbaz1");
                    savunma = (Image)Properties.Resources.ResourceManager.GetObject("sihirbaz2");
                    bitis = (Image)Properties.Resources.ResourceManager.GetObject("sihirbaz3");
                    break;
                case KarakterTipi.Okcu:
                    MaxSaglik = 100;
                    MinAtak = 10;
                    MaxAtak = 20;
                    saldiri = (Image)Properties.Resources.ResourceManager.GetObject("okcu1");
                    savunma = (Image)Properties.Resources.ResourceManager.GetObject("okcu2");
                    bitis = (Image)Properties.Resources.ResourceManager.GetObject("okcu3");
                    break;
                default:
                    break;
            }
            Saglik = MaxSaglik;
        }
       
    }
}
