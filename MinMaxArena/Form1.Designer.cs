namespace MinMaxArena
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnOyunaBasla = new System.Windows.Forms.Button();
            this.lblSavasci1Ad = new System.Windows.Forms.Label();
            this.lblSavasci2Ad = new System.Windows.Forms.Label();
            this.prgSavasci1Can = new System.Windows.Forms.ProgressBar();
            this.prgSavasci2Can = new System.Windows.Forms.ProgressBar();
            this.lblSavasci1Tipi = new System.Windows.Forms.Label();
            this.lblSavasci1Seviye = new System.Windows.Forms.Label();
            this.lblSavasci1Xp = new System.Windows.Forms.Label();
            this.lblSavasci2Xp = new System.Windows.Forms.Label();
            this.lblSavasci2Seviye = new System.Windows.Forms.Label();
            this.lblSavasci2Tipi = new System.Windows.Forms.Label();
            this.lblSavasci1Can = new System.Windows.Forms.Label();
            this.lblSavasci2Can = new System.Windows.Forms.Label();
            this.listLog = new System.Windows.Forms.ListBox();
            this.lblRound = new System.Windows.Forms.Label();
            this.picBoxSavasci1 = new System.Windows.Forms.PictureBox();
            this.picBoxSavasci2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkOtomatik = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSavasci1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSavasci2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOyunaBasla
            // 
            this.btnOyunaBasla.Location = new System.Drawing.Point(357, 177);
            this.btnOyunaBasla.Name = "btnOyunaBasla";
            this.btnOyunaBasla.Size = new System.Drawing.Size(180, 55);
            this.btnOyunaBasla.TabIndex = 1;
            this.btnOyunaBasla.Text = "Oyunu Başlat";
            this.btnOyunaBasla.UseVisualStyleBackColor = true;
            this.btnOyunaBasla.Click += new System.EventHandler(this.btnOyunaBasla_Click);
            // 
            // lblSavasci1Ad
            // 
            this.lblSavasci1Ad.AutoSize = true;
            this.lblSavasci1Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSavasci1Ad.Location = new System.Drawing.Point(103, 414);
            this.lblSavasci1Ad.Name = "lblSavasci1Ad";
            this.lblSavasci1Ad.Size = new System.Drawing.Size(0, 20);
            this.lblSavasci1Ad.TabIndex = 2;
            // 
            // lblSavasci2Ad
            // 
            this.lblSavasci2Ad.AutoSize = true;
            this.lblSavasci2Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSavasci2Ad.Location = new System.Drawing.Point(613, 414);
            this.lblSavasci2Ad.Name = "lblSavasci2Ad";
            this.lblSavasci2Ad.Size = new System.Drawing.Size(0, 20);
            this.lblSavasci2Ad.TabIndex = 3;
            // 
            // prgSavasci1Can
            // 
            this.prgSavasci1Can.Location = new System.Drawing.Point(27, 23);
            this.prgSavasci1Can.Name = "prgSavasci1Can";
            this.prgSavasci1Can.Size = new System.Drawing.Size(388, 23);
            this.prgSavasci1Can.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgSavasci1Can.TabIndex = 4;
            // 
            // prgSavasci2Can
            // 
            this.prgSavasci2Can.Location = new System.Drawing.Point(451, 23);
            this.prgSavasci2Can.Name = "prgSavasci2Can";
            this.prgSavasci2Can.Size = new System.Drawing.Size(418, 23);
            this.prgSavasci2Can.TabIndex = 5;
            // 
            // lblSavasci1Tipi
            // 
            this.lblSavasci1Tipi.AutoSize = true;
            this.lblSavasci1Tipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSavasci1Tipi.Location = new System.Drawing.Point(103, 441);
            this.lblSavasci1Tipi.Name = "lblSavasci1Tipi";
            this.lblSavasci1Tipi.Size = new System.Drawing.Size(0, 20);
            this.lblSavasci1Tipi.TabIndex = 6;
            // 
            // lblSavasci1Seviye
            // 
            this.lblSavasci1Seviye.AutoSize = true;
            this.lblSavasci1Seviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSavasci1Seviye.Location = new System.Drawing.Point(103, 471);
            this.lblSavasci1Seviye.Name = "lblSavasci1Seviye";
            this.lblSavasci1Seviye.Size = new System.Drawing.Size(0, 20);
            this.lblSavasci1Seviye.TabIndex = 7;
            // 
            // lblSavasci1Xp
            // 
            this.lblSavasci1Xp.AutoSize = true;
            this.lblSavasci1Xp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSavasci1Xp.Location = new System.Drawing.Point(103, 501);
            this.lblSavasci1Xp.Name = "lblSavasci1Xp";
            this.lblSavasci1Xp.Size = new System.Drawing.Size(0, 20);
            this.lblSavasci1Xp.TabIndex = 8;
            // 
            // lblSavasci2Xp
            // 
            this.lblSavasci2Xp.AutoSize = true;
            this.lblSavasci2Xp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSavasci2Xp.Location = new System.Drawing.Point(613, 502);
            this.lblSavasci2Xp.Name = "lblSavasci2Xp";
            this.lblSavasci2Xp.Size = new System.Drawing.Size(0, 20);
            this.lblSavasci2Xp.TabIndex = 11;
            // 
            // lblSavasci2Seviye
            // 
            this.lblSavasci2Seviye.AutoSize = true;
            this.lblSavasci2Seviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSavasci2Seviye.Location = new System.Drawing.Point(613, 472);
            this.lblSavasci2Seviye.Name = "lblSavasci2Seviye";
            this.lblSavasci2Seviye.Size = new System.Drawing.Size(0, 20);
            this.lblSavasci2Seviye.TabIndex = 10;
            // 
            // lblSavasci2Tipi
            // 
            this.lblSavasci2Tipi.AutoSize = true;
            this.lblSavasci2Tipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSavasci2Tipi.Location = new System.Drawing.Point(613, 442);
            this.lblSavasci2Tipi.Name = "lblSavasci2Tipi";
            this.lblSavasci2Tipi.Size = new System.Drawing.Size(0, 20);
            this.lblSavasci2Tipi.TabIndex = 9;
            // 
            // lblSavasci1Can
            // 
            this.lblSavasci1Can.AutoSize = true;
            this.lblSavasci1Can.BackColor = System.Drawing.Color.Transparent;
            this.lblSavasci1Can.Location = new System.Drawing.Point(205, 27);
            this.lblSavasci1Can.Name = "lblSavasci1Can";
            this.lblSavasci1Can.Size = new System.Drawing.Size(14, 16);
            this.lblSavasci1Can.TabIndex = 12;
            this.lblSavasci1Can.Text = "0";
            // 
            // lblSavasci2Can
            // 
            this.lblSavasci2Can.AutoSize = true;
            this.lblSavasci2Can.BackColor = System.Drawing.Color.Transparent;
            this.lblSavasci2Can.Location = new System.Drawing.Point(651, 27);
            this.lblSavasci2Can.Name = "lblSavasci2Can";
            this.lblSavasci2Can.Size = new System.Drawing.Size(14, 16);
            this.lblSavasci2Can.TabIndex = 13;
            this.lblSavasci2Can.Text = "0";
            // 
            // listLog
            // 
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 16;
            this.listLog.Location = new System.Drawing.Point(914, 23);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(357, 580);
            this.listLog.TabIndex = 14;
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRound.Location = new System.Drawing.Point(401, 258);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(0, 20);
            this.lblRound.TabIndex = 15;
            // 
            // picBoxSavasci1
            // 
            this.picBoxSavasci1.Location = new System.Drawing.Point(77, 72);
            this.picBoxSavasci1.Name = "picBoxSavasci1";
            this.picBoxSavasci1.Size = new System.Drawing.Size(250, 329);
            this.picBoxSavasci1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSavasci1.TabIndex = 16;
            this.picBoxSavasci1.TabStop = false;
            // 
            // picBoxSavasci2
            // 
            this.picBoxSavasci2.Location = new System.Drawing.Point(567, 72);
            this.picBoxSavasci2.Name = "picBoxSavasci2";
            this.picBoxSavasci2.Size = new System.Drawing.Size(250, 329);
            this.picBoxSavasci2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSavasci2.TabIndex = 17;
            this.picBoxSavasci2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkOtomatik
            // 
            this.checkOtomatik.AutoSize = true;
            this.checkOtomatik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkOtomatik.Location = new System.Drawing.Point(387, 135);
            this.checkOtomatik.Name = "checkOtomatik";
            this.checkOtomatik.Size = new System.Drawing.Size(90, 20);
            this.checkOtomatik.TabIndex = 18;
            this.checkOtomatik.Text = "Otomatik";
            this.checkOtomatik.UseVisualStyleBackColor = true;
            this.checkOtomatik.CheckedChanged += new System.EventHandler(this.checkOtomatik_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1295, 622);
            this.Controls.Add(this.checkOtomatik);
            this.Controls.Add(this.picBoxSavasci2);
            this.Controls.Add(this.picBoxSavasci1);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.lblSavasci2Can);
            this.Controls.Add(this.lblSavasci1Can);
            this.Controls.Add(this.lblSavasci2Xp);
            this.Controls.Add(this.lblSavasci2Seviye);
            this.Controls.Add(this.lblSavasci2Tipi);
            this.Controls.Add(this.lblSavasci1Xp);
            this.Controls.Add(this.lblSavasci1Seviye);
            this.Controls.Add(this.lblSavasci1Tipi);
            this.Controls.Add(this.prgSavasci2Can);
            this.Controls.Add(this.prgSavasci1Can);
            this.Controls.Add(this.lblSavasci2Ad);
            this.Controls.Add(this.lblSavasci1Ad);
            this.Controls.Add(this.btnOyunaBasla);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSavasci1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSavasci2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOyunaBasla;
        private System.Windows.Forms.Label lblSavasci1Ad;
        private System.Windows.Forms.Label lblSavasci2Ad;
        private System.Windows.Forms.ProgressBar prgSavasci1Can;
        private System.Windows.Forms.ProgressBar prgSavasci2Can;
        private System.Windows.Forms.Label lblSavasci1Tipi;
        private System.Windows.Forms.Label lblSavasci1Seviye;
        private System.Windows.Forms.Label lblSavasci1Xp;
        private System.Windows.Forms.Label lblSavasci2Xp;
        private System.Windows.Forms.Label lblSavasci2Seviye;
        private System.Windows.Forms.Label lblSavasci2Tipi;
        private System.Windows.Forms.Label lblSavasci1Can;
        private System.Windows.Forms.Label lblSavasci2Can;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.PictureBox picBoxSavasci1;
        private System.Windows.Forms.PictureBox picBoxSavasci2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkOtomatik;
    }
}

