using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MinMaxArena.Karakter;

namespace MinMaxArena
{

    public partial class Form1 : Form
    {
        Karakter savasci1;
        Karakter savasci2;
        bool savasci1Sirasimi = true;
        bool baslangicmi = true;
        int oynayanlarIndex = 0;
        public string[] oyuncuListesi = { "Asım", "Mert", "Selcuk", "Murat", "Yusuf", "Ahmet" };
        public string[] oynayanlar;
        int round = 1;
        bool timerCalisiyormu = false;
        public Form1()
        {
            InitializeComponent();
            oynayanlar = new string[oyuncuListesi.Length];
        }

        public Karakter RastgeleKarakterYarat()
        {
            Random random = new Random();
            Karakter yeniKarakter = new Karakter();

            if (oynayanlarIndex <= oyuncuListesi.Length - 1)
            {
                do
                {
                    var rastgeleKarakterTipi = (KarakterTipi)random.Next(0, 3);
                    var rastgeleKarakteroyuncuListesi = oyuncuListesi[random.Next(0, oyuncuListesi.Length)];
                    yeniKarakter = new Karakter(rastgeleKarakteroyuncuListesi, rastgeleKarakterTipi);
                } while (Array.IndexOf(oynayanlar, yeniKarakter.Ad) != -1);
                oynayanlar[oynayanlarIndex] = yeniKarakter.Ad;
                oynayanlarIndex++;
            }
            return yeniKarakter;
        }

        public void OyunLogla(string mesaj)
        {
            listLog.Items.Add($"{DateTime.Now:HH:mm:ss} {mesaj}");
        }

        public void DovusuKontrolEtSonlandir()
        {

            if (savasci1 == null || savasci2 == null) return;
            if (savasci1.Saglik > 0 && savasci2.Saglik > 0) return;

            Karakter kazanan, kaybeden;
            if (savasci2.Saglik == 0)
            {
                kazanan = savasci1;
                kaybeden = savasci2;
                picBoxSavasci1.Image = savasci1.saldiri;
                picBoxSavasci2.Image = savasci2.bitis;
            }
            else
            {
                kazanan = savasci2;
                kaybeden = savasci1;
                picBoxSavasci1.Image = savasci1.bitis;
                picBoxSavasci2.Image = savasci2.saldiri;
            }

            MessageBox.Show($"{kazanan.Ad} Dövüşü Kazandı, {kaybeden.Ad} Elendi");
            OyunLogla($"{kazanan.Ad} Dövüşü Kazandı, {kaybeden.Ad} Elendi");
            kazanan.Xp += 120 + kaybeden.Xp;

            if (kazanan.Xp > kazanan.SonrakiSeviyeXpDegeri)
            {
                kazanan.Seviye++;
                //kazanan.MaxSaglik;
                //kazanan.MaxAtak++;
                //kazanan.MinAtak++;

                kazanan.Saglik = kazanan.MaxSaglik;
                OyunLogla($"Kazanan {kazanan.Ad} 120 XP Kazandı. Yeni Seviyesi {kazanan.Seviye}");
            }

            EkraniGuncelle();
            if (round == oyuncuListesi.Length - 1)
            {
                timer1.Stop();
                MessageBox.Show($"Turnuva Tamamlandı Turnuvanın Kazananı {(savasci1.Saglik == 0 ? savasci2 : savasci1).Ad}");
                return;
            }

            if (savasci1.Saglik == 0)
            {
                savasci1 = RastgeleKarakterYarat();
                savasci1.Seviye = savasci2.Seviye;
                EkraniGuncelle();
                picBoxSavasci1.Image = savasci1.saldiri;
                picBoxSavasci2.Image = savasci2.saldiri;
                MessageBox.Show($"Kazanan {savasci2.Ad}'ın Yeni Rakibi {savasci1.Ad}");
                OyunLogla($"Kazanan {savasci2.Ad}'ın Yeni Rakibi {savasci1.Ad}");
            }
            else
            {
                savasci2 = RastgeleKarakterYarat();
                savasci2.Seviye = savasci1.Seviye;
                EkraniGuncelle();
                picBoxSavasci1.Image = savasci1.saldiri;
                picBoxSavasci2.Image = savasci2.saldiri;
                MessageBox.Show($"Kazanan {savasci1.Ad}'ın Yeni Rakibi {savasci2.Ad}");
                OyunLogla($"Kazanan {savasci1.Ad}'ın Yeni Rakibi {savasci2.Ad}");
            }
            round++;
            picBoxSavasci1.Image = savasci1.saldiri;
            picBoxSavasci2.Image = savasci2.saldiri;
            EkraniGuncelle();


        }

        public void Saldir(Karakter saldiran, Karakter savunan)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 10);
            var rastgeleAtak = rnd.Next(saldiran.MinAtak, saldiran.MaxAtak);
            rastgeleAtak = sayi == 8 ? (int)(rastgeleAtak * 1.3) : rastgeleAtak;

            savunan.Saglik -= rastgeleAtak;
            savunan.Saglik = savunan.Saglik < 0 ? savunan.Saglik = 0 : savunan.Saglik;
            if (sayi == 8)
            { OyunLogla("kritik vuruş"); }
            OyunLogla($"{saldiran.Ad},{savunan.Ad}'a, {rastgeleAtak} gücünde saldırdı ");
        }

        public void EkraniGuncelle()
        {
            lblSavasci1Ad.Text = $"Adı : {savasci1.Ad}";
            lblSavasci1Seviye.Text = $"Seviye : {savasci1.Seviye.ToString()}";
            lblSavasci1Tipi.Text = $"Tipi : {savasci1.Tipi.ToString()}";
            lblSavasci1Xp.Text = $"Xp : {savasci1.Xp.ToString()}";
            prgSavasci1Can.Maximum = savasci1.MaxSaglik;
            prgSavasci1Can.Value = savasci1.Saglik;
            lblSavasci1Can.Text = savasci1.Saglik.ToString();
            picBoxSavasci1.Image = savasci1Sirasimi ? savasci1.saldiri : savasci1.savunma;


            lblSavasci2Ad.Text = $"Adı : {savasci2.Ad}";
            lblSavasci2Seviye.Text = $"Seviye : {savasci2.Seviye.ToString()}";
            lblSavasci2Tipi.Text = $"Tipi : {savasci2.Tipi.ToString()}";
            lblSavasci2Xp.Text = $"Xp : {savasci2.Xp.ToString()}";
            prgSavasci2Can.Maximum = savasci2.MaxSaglik;
            prgSavasci2Can.Value = savasci2.Saglik;
            lblSavasci2Can.Text = savasci2.Saglik.ToString();
            picBoxSavasci2.Image = savasci1Sirasimi ? savasci2.savunma : savasci2.saldiri;

            lblRound.Text = $"Round {round}";
        }

        public void AtakYap()
        {
            if (savasci1Sirasimi)
            {
                picBoxSavasci1.Image = savasci1.saldiri;
                picBoxSavasci2.Image = savasci2.savunma;
                Saldir(savasci1, savasci2);
                btnOyunaBasla.Text = "<<< Saldır <<<";
                savasci1Sirasimi = false;
            }
            else
            {
                picBoxSavasci1.Image = savasci1.savunma;
                picBoxSavasci2.Image = savasci2.saldiri;
                Saldir(savasci2, savasci1);
                btnOyunaBasla.Text = ">>> Saldır >>>";
                savasci1Sirasimi = true;
            }
            EkraniGuncelle();
            DovusuKontrolEtSonlandir();
        }



        private void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            if (baslangicmi)
            {
                savasci1 = RastgeleKarakterYarat();
                savasci2 = RastgeleKarakterYarat();
                savasci1.Seviye = 1;
                savasci2.Seviye = 1;
                EkraniGuncelle();
                picBoxSavasci1.Image = savasci1.saldiri;
                picBoxSavasci2.Image = savasci2.saldiri;

                baslangicmi = false;
                btnOyunaBasla.Text = "Dövüş";

            }
            else
            {
                AtakYap();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerCalisiyormu) return;
            timerCalisiyormu = true;
            try
            {
                AtakYap();
            }
            finally
            {
                timerCalisiyormu = false;
            }

        }

        private void checkOtomatik_CheckedChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            if (checkOtomatik.Checked)
            {
                timer1.Interval = random.Next(500, 2000);
                timer1.Start();
            }
        }
    }
}
