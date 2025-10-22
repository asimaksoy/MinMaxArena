namespace MinMaxArena
{
    partial class FrmSkor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listSkor = new System.Windows.Forms.ListView();
            this.clmAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTekrar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listSkor
            // 
            this.listSkor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmAd,
            this.clmTip,
            this.clmPuan,
            this.clmTarih,
            this.clmSaat});
            this.listSkor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listSkor.HideSelection = false;
            this.listSkor.Location = new System.Drawing.Point(0, 65);
            this.listSkor.Name = "listSkor";
            this.listSkor.Size = new System.Drawing.Size(819, 395);
            this.listSkor.TabIndex = 0;
            this.listSkor.UseCompatibleStateImageBehavior = false;
            this.listSkor.View = System.Windows.Forms.View.Details;
            // 
            // clmAd
            // 
            this.clmAd.Text = "Ad";
            this.clmAd.Width = 80;
            // 
            // clmTip
            // 
            this.clmTip.Text = "Tipi";
            this.clmTip.Width = 80;
            // 
            // clmPuan
            // 
            this.clmPuan.Text = "Puanı";
            this.clmPuan.Width = 80;
            // 
            // clmTarih
            // 
            this.clmTarih.Text = "Tarih";
            this.clmTarih.Width = 100;
            // 
            // clmSaat
            // 
            this.clmSaat.Text = "Saat";
            // 
            // btnTekrar
            // 
            this.btnTekrar.Location = new System.Drawing.Point(12, 12);
            this.btnTekrar.Name = "btnTekrar";
            this.btnTekrar.Size = new System.Drawing.Size(125, 34);
            this.btnTekrar.TabIndex = 1;
            this.btnTekrar.Text = "Tekrar Oyna";
            this.btnTekrar.UseVisualStyleBackColor = true;
            this.btnTekrar.Click += new System.EventHandler(this.btnTekrar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(699, 18);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FrmSkor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 460);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTekrar);
            this.Controls.Add(this.listSkor);
            this.Name = "FrmSkor";
            this.Text = "Skor Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSkor_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listSkor;
        private System.Windows.Forms.ColumnHeader clmAd;
        private System.Windows.Forms.ColumnHeader clmTip;
        private System.Windows.Forms.ColumnHeader clmPuan;
        private System.Windows.Forms.ColumnHeader clmTarih;
        private System.Windows.Forms.ColumnHeader clmSaat;
        private System.Windows.Forms.Button btnTekrar;
        private System.Windows.Forms.Button btnCikis;
    }
}