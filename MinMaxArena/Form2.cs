using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinMaxArena
{
    public partial class FrmSkor : Form
    {
        public FrmSkor()
        {
            InitializeComponent();
            for (int i = 0;i<FrmOyun.skorListesi.GetLength(0);i++)
            {

                ListViewItem item = new ListViewItem(FrmOyun.skorListesi[i, 0]);
                item.SubItems.Add(FrmOyun.skorListesi[i,1]);
                item.SubItems.Add(FrmOyun.skorListesi[i, 2]);
                item.SubItems.Add(FrmOyun.skorListesi[i, 3]);
                item.SubItems.Add(FrmOyun.skorListesi[i, 4]);
                listSkor.Items.Add(item);
            }
        }

        private void FrmSkor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnTekrar_Click(object sender, EventArgs e)
        {
            FrmOyun FrmOyun = new FrmOyun();
            this.Hide();
            FrmOyun.Show();
            FrmOyun.baslangicmi = true;
            FrmOyun.timerCalisiyormu = false;
            FrmOyun.round = 1;

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
