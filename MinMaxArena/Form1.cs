using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MinMaxArena.Karakter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MinMaxArena
{

    public partial class FrmOyun : Form
    {
        Karakter savasci1;
        Karakter savasci2;
        bool savasci1Sirasimi = true;
        public bool baslangicmi = true;
        int oynayanlarIndex = 0;
        public string[] oyuncuListesi = { "Asım", "Mert", "Selcuk", "Murat", "Yusuf", "Ahmet" };
        public string[] oynayanlar;
        public int round = 1;
        public bool timerCalisiyormu = false;
        string filePath = "../../skortahtasi.txt";
        string[] dosyametindizi;
        int dsatirsayisi;
        string turnuvayiKazananOyuncu;
        string turnuvayiKazananOyuncuTipi;
        int turnuvayiKazananOyuncuPuan;

        public FrmOyun()
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
            try
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
                kaybeden.toplamPuan = 0;

                MessageBox.Show($"{kazanan.Ad} Dövüşü Kazandı, {kaybeden.Ad} Elendi");
                OyunLogla($"{kazanan.Ad} Dövüşü Kazandı, {kaybeden.Ad} Elendi");
                kazanan.Xp += 120 + kaybeden.Xp;

                if (kazanan.Xp > kazanan.SonrakiSeviyeXpDegeri)
                {
                    kazanan.Seviye++;
                    //kazanan.MaxSaglik;
                    kazanan.MaxAtak++;
                    kazanan.MinAtak++;

                    kazanan.Saglik = kazanan.MaxSaglik;
                    OyunLogla($"Kazanan {kazanan.Ad} 120 XP Kazandı. Yeni Seviyesi {kazanan.Seviye}");
                }

                EkraniGuncelle();
                if (round == oyuncuListesi.Length - 1)
                {
                    timer1.Stop();
                    MessageBox.Show($"Turnuva Tamamlandı Turnuvanın Kazananı {(savasci1.Saglik == 0 ? savasci2 : savasci1).Ad} " +
                        $"Toplam Panı: {(savasci1.Saglik == 0 ? savasci2 : savasci1).toplamPuan}");
                    if (savasci1.Saglik == 0)
                    {
                        picBoxSavasci1.Image = savasci1.bitis;
                        turnuvayiKazananOyuncu = savasci2.Ad;
                        turnuvayiKazananOyuncuTipi = savasci2.Tipi.ToString();
                        turnuvayiKazananOyuncuPuan = savasci2.toplamPuan;
                        picSavasci2Odul.Visible = true;
                    }
                    else
                    {
                        picBoxSavasci2.Image = savasci2.bitis;
                        turnuvayiKazananOyuncu = savasci1.Ad;
                        turnuvayiKazananOyuncuTipi = savasci1.Tipi.ToString();
                        turnuvayiKazananOyuncuPuan = savasci1.toplamPuan;
                        picSavasci1Odul.Visible = true;
                    }
                    picSaldiriYonu.Image = null;
                    lblAtakGucu.Text = null;
                    SkorKaydet();
                    return;
                }
                else
                {
                    if (savasci1.Saglik == 0)
                    {
                        savasci1 = RastgeleKarakterYarat();
                        savasci1.Seviye = savasci2.Seviye;
                        EkraniGuncelle();
                        picBoxSavasci1.Image = savasci1.saldiri;
                        picBoxSavasci2.Image = savasci2.saldiri;
                        MessageBox.Show($"Kazanan {savasci2.Ad}'ın Yeni Rakibi {savasci1.Ad}");
                        OyunLogla($"Kazanan {savasci2.Ad}'ın Yeni Rakibi {savasci1.Ad}");
                        picBoxSavasci1.Image = savasci1.saldiri;
                        picBoxSavasci2.Image = savasci2.saldiri;
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
                        picBoxSavasci1.Image = savasci1.saldiri;
                        picBoxSavasci2.Image = savasci2.saldiri;
                    }
                    round++;
                    picBoxSavasci1.Image = savasci1.saldiri;
                    picBoxSavasci2.Image = savasci2.saldiri;
                    EkraniGuncelle();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata");
            }
            
        }

        public void Saldir(Karakter saldiran, Karakter savunan)
        {
            try
            {
                Random rnd = new Random();
                int sayi = rnd.Next(1, 10);
                var rastgeleAtak = rnd.Next(saldiran.MinAtak, saldiran.MaxAtak);
                rastgeleAtak = sayi == 8 ? (int)(rastgeleAtak * 1.3) : rastgeleAtak;
                saldiran.toplamPuan += (rastgeleAtak * round);

                savunan.Saglik -= rastgeleAtak;
                savunan.Saglik = savunan.Saglik < 0 ? savunan.Saglik = 0 : savunan.Saglik;
                if (sayi == 8)
                {
                    OyunLogla($"kritik vuruş: {rastgeleAtak}");
                    lblAtakGucu.Text = $"Kritk Vuruş:{rastgeleAtak}";
                }
                else
                {
                    OyunLogla($"{saldiran.Ad},{savunan.Ad}'a, {rastgeleAtak} gücünde saldırdı ");
                    lblAtakGucu.Text = $"Vuruş:{rastgeleAtak}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
            
        }

        public void EkraniGuncelle()
        {
            try
            {
                if (savasci1.Saglik == 100 && savasci2.Saglik == 100)
                {
                    picBoxSavasci1.Image = savasci1.saldiri;
                    picBoxSavasci2.Image = savasci2.saldiri;
                    picSaldiriYonu.Image = null;
                    lblAtakGucu.Text = null;
                }
                else
                {
                    lblSavasci1Ad.Text = $"Adı : {savasci1.Ad}";
                    lblSavasci1Seviye.Text = $"Seviye : {savasci1.Seviye.ToString()}";
                    lblSavasci1Tipi.Text = $"Tipi : {savasci1.Tipi.ToString()}";
                    lblSavasci1Xp.Text = $"Xp : {savasci1.Xp.ToString()}";
                    prgSavasci1Can.Maximum = savasci1.MaxSaglik;
                    prgSavasci1Can.Value = savasci1.Saglik;
                    lblSavasci1Can.Text = savasci1.Saglik.ToString();
                    picBoxSavasci1.Image = savasci1Sirasimi ? savasci1.savunma : savasci1.saldiri;
                    picSaldiriYonu.Image = savasci1Sirasimi ? (Image)Properties.Resources.Orange_animated_right_arrow : (Image)Properties.Resources.Orange_animated_left_arrow;


                    lblSavasci2Ad.Text = $"Adı : {savasci2.Ad}";
                    lblSavasci2Seviye.Text = $"Seviye : {savasci2.Seviye.ToString()}";
                    lblSavasci2Tipi.Text = $"Tipi : {savasci2.Tipi.ToString()}";
                    lblSavasci2Xp.Text = $"Xp : {savasci2.Xp.ToString()}";
                    prgSavasci2Can.Maximum = savasci2.MaxSaglik;
                    prgSavasci2Can.Value = savasci2.Saglik;
                    lblSavasci2Can.Text = savasci2.Saglik.ToString();
                    picBoxSavasci2.Image = savasci1Sirasimi ? savasci2.saldiri : savasci2.savunma;
                    picSaldiriYonu.Image = savasci1Sirasimi ? (Image)Properties.Resources.Orange_animated_left_arrow : (Image)Properties.Resources.Orange_animated_right_arrow;

                    lblRound.Text = $"Round {round}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata");
            }
            
            
        }

        public void AtakYap()
        {
            if (savasci1Sirasimi)
            {
                Saldir(savasci1, savasci2);
                btnOyunaBasla.Text = "<<< Saldır <<<";
                
                savasci1Sirasimi = false;
            }
            else
            {
                Saldir(savasci2, savasci1);
                btnOyunaBasla.Text = ">>> Saldır >>>";
                savasci1Sirasimi = true;
            }
            EkraniGuncelle();
            DovusuKontrolEtSonlandir();
        }

        public void DosyaKaydet(string[,] kaydedilecekDizi)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    for (int i = 0; i < 10; i++) // satır sayısı
                    {
                        for (int j = 0; j < kaydedilecekDizi.GetLength(1); j++) // sütun sayısı
                        {
                            sw.Write(kaydedilecekDizi[i, j]);

                            if (j < kaydedilecekDizi.GetLength(1) - 1) // sütun aralarına boşluk koy
                                sw.Write(" ");
                        }
                        sw.WriteLine(); // satır sonu
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata");

            }

        }

        public string[,] SkorListe(string dosya)
        {
            dosyametindizi = File.ReadAllLines(dosya);
            dsatirsayisi = dosyametindizi.Length;

            string[,] sonucdizi = new string[dsatirsayisi, 5];
            for (int i = 0; i < dsatirsayisi; i++)
            {
                string[] satirDizi = dosyametindizi[i].Split(' ');
                for (int j = 0; j < satirDizi.Length; j++)
                {
                    if (satirDizi[j] != "" || satirDizi != null)
                    {
                        sonucdizi[i, j] = satirDizi[j].ToString();
                    }
                }
            }
            return sonucdizi;
        }

        public int IntegerCevir(string str)
        {
            if (int.TryParse(str, out int i))
            {
                return i;
            }
            else
            {  return 0; }
        }

        public string[,] DiziSirala(string[,] skorDizi)
        {
            int satirSayisi = skorDizi.GetLength(0); // kaç satır var
            int sutunSayisi = skorDizi.GetLength(1); // kaç sütun var

            for (int i = 0; i < satirSayisi - 1; i++)
            {
                for (int j = 0; j < satirSayisi - i - 1; j++)
                {
                    int puan1 = int.Parse(skorDizi[j, 2]);
                    int puan2 = int.Parse(skorDizi[j + 1, 2]);

                    if (puan1 < puan2) // büyükten küçüğe
                    {
                        // satırları yer değiştir
                        for (int k = 0; k < sutunSayisi; k++)
                        {
                            string temp = skorDizi[j, k];
                            skorDizi[j, k] = skorDizi[j + 1, k];
                            skorDizi[j + 1, k] = temp;
                        }
                    }
                }
            }

            return skorDizi;
        }
        public void SkorKaydet()
        {
            string[,] dosyaSkorlar = SkorListe(filePath);
            string[,] yeniSkorlar = new string[dosyaSkorlar.GetLength(0)+1, dosyaSkorlar.GetLength(1)];
            string[,] siralananSkorlar= new string[yeniSkorlar.GetLength(0), yeniSkorlar.GetLength(1)];
            for (int i = 0; i < dosyaSkorlar.GetLength(0); i++)
            {
                for (int j = 0; j < dosyaSkorlar.GetLength(1); j++)
                {
                    yeniSkorlar[i, j] = dosyaSkorlar[i, j];
                }
            }
            yeniSkorlar[yeniSkorlar.GetLength(0) - 1, 0] = turnuvayiKazananOyuncu;
            yeniSkorlar[yeniSkorlar.GetLength(0) - 1, 1] = turnuvayiKazananOyuncuTipi;
            yeniSkorlar[yeniSkorlar.GetLength(0) - 1, 2] = turnuvayiKazananOyuncuPuan.ToString();
            yeniSkorlar[yeniSkorlar.GetLength(0) - 1, 3] = DateTime.Now.ToString("dd-MM-yyyy");
            yeniSkorlar[yeniSkorlar.GetLength(0) - 1, 4] = DateTime.Now.ToString("HH:mm");

            siralananSkorlar = DiziSirala(yeniSkorlar);
            DosyaKaydet(siralananSkorlar);
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
                picSaldiriYonu.Image = null;
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
                timer1.Interval = random.Next(700, 2000);
                timer1.Start();
            }
        }
        public static string[,] skorListesi;
        private void btnSkor_Click(object sender, EventArgs e)
        {
            skorListesi = SkorListe(filePath);
            FrmSkor frmSkor = new FrmSkor();
            this.Hide();  
            frmSkor.Show();
        }
    }
}
