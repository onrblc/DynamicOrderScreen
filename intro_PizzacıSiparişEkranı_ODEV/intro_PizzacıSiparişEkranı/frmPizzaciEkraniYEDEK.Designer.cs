namespace intro_PizzacıSiparişEkranı
{
    partial class frmPizzaciEkraniYEDEK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzaciEkraniYEDEK));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblEbat = new System.Windows.Forms.Label();
            this.lblCesit = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblSiparisDetay = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSiparisSil = new System.Windows.Forms.Button();
            this.lblDegistir = new System.Windows.Forms.Button();
            this.lstCesit = new System.Windows.Forms.ListBox();
            this.cmbEbat = new System.Windows.Forms.ComboBox();
            this.lstSiparisDetayı = new System.Windows.Forms.ListBox();
            this.lblSiparisToplam = new System.Windows.Forms.Label();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.rdoInceKenar = new System.Windows.Forms.RadioButton();
            this.rdoKalinKenar = new System.Windows.Forms.RadioButton();
            this.cbxSalam = new System.Windows.Forms.CheckBox();
            this.cbxSosis = new System.Windows.Forms.CheckBox();
            this.cbxSucuk = new System.Windows.Forms.CheckBox();
            this.cbxJalepeno = new System.Windows.Forms.CheckBox();
            this.cbxAncuez = new System.Windows.Forms.CheckBox();
            this.cbxZeytin = new System.Windows.Forms.CheckBox();
            this.lblAraToplam = new System.Windows.Forms.Label();
            this.lblTL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEkstralar = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEbat
            // 
            this.lblEbat.AutoSize = true;
            this.lblEbat.Location = new System.Drawing.Point(9, 78);
            this.lblEbat.Name = "lblEbat";
            this.lblEbat.Size = new System.Drawing.Size(32, 13);
            this.lblEbat.TabIndex = 0;
            this.lblEbat.Text = "Ebat:";
            // 
            // lblCesit
            // 
            this.lblCesit.AutoSize = true;
            this.lblCesit.Location = new System.Drawing.Point(9, 122);
            this.lblCesit.Name = "lblCesit";
            this.lblCesit.Size = new System.Drawing.Size(36, 13);
            this.lblCesit.TabIndex = 1;
            this.lblCesit.Text = "Çeşit: ";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(298, 204);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(64, 13);
            this.lblToplamTutar.TabIndex = 2;
            this.lblToplamTutar.Text = "Ara Toplam:";
            // 
            // lblSiparisDetay
            // 
            this.lblSiparisDetay.AutoSize = true;
            this.lblSiparisDetay.Location = new System.Drawing.Point(9, 386);
            this.lblSiparisDetay.Name = "lblSiparisDetay";
            this.lblSiparisDetay.Size = new System.Drawing.Size(74, 13);
            this.lblSiparisDetay.TabIndex = 3;
            this.lblSiparisDetay.Text = "Sipariş Detayı:";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(317, 94);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(32, 13);
            this.lblAdet.TabIndex = 4;
            this.lblAdet.Text = "Adet:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 322);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(171, 61);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "SEÇİLEN ÖZELLİKTEKİ SİPARİŞİ EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSiparisSil
            // 
            this.btnSiparisSil.Location = new System.Drawing.Point(212, 306);
            this.btnSiparisSil.Name = "btnSiparisSil";
            this.btnSiparisSil.Size = new System.Drawing.Size(86, 28);
            this.btnSiparisSil.TabIndex = 8;
            this.btnSiparisSil.Text = "Sipariş Sil";
            this.btnSiparisSil.UseVisualStyleBackColor = true;
            this.btnSiparisSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblDegistir
            // 
            this.lblDegistir.Location = new System.Drawing.Point(212, 353);
            this.lblDegistir.Name = "lblDegistir";
            this.lblDegistir.Size = new System.Drawing.Size(86, 30);
            this.lblDegistir.TabIndex = 9;
            this.lblDegistir.Text = "Sipariş Değiştir";
            this.lblDegistir.UseVisualStyleBackColor = true;
            this.lblDegistir.Click += new System.EventHandler(this.lblDegistir_Click);
            // 
            // lstCesit
            // 
            this.lstCesit.FormattingEnabled = true;
            this.lstCesit.Items.AddRange(new object[] {
            "Classic",
            "Turkish",
            "Ekstra Kavanoz",
            "Kumrucuk",
            "Biberli",
            "Mexicanli",
            "KizilSkin"});
            this.lstCesit.Location = new System.Drawing.Point(64, 122);
            this.lstCesit.Name = "lstCesit";
            this.lstCesit.Size = new System.Drawing.Size(119, 147);
            this.lstCesit.TabIndex = 11;
            this.lstCesit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstCesit_MouseClick);
            // 
            // cmbEbat
            // 
            this.cmbEbat.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbEbat.FormattingEnabled = true;
            this.cmbEbat.Items.AddRange(new object[] {
            "Küçük",
            "Orta",
            "Büyük"});
            this.cmbEbat.Location = new System.Drawing.Point(64, 75);
            this.cmbEbat.Name = "cmbEbat";
            this.cmbEbat.Size = new System.Drawing.Size(119, 21);
            this.cmbEbat.TabIndex = 12;
            this.cmbEbat.SelectedIndexChanged += new System.EventHandler(this.cmbEbat_SelectedIndexChanged);
            // 
            // lstSiparisDetayı
            // 
            this.lstSiparisDetayı.FormattingEnabled = true;
            this.lstSiparisDetayı.HorizontalScrollbar = true;
            this.lstSiparisDetayı.Location = new System.Drawing.Point(7, 410);
            this.lstSiparisDetayı.Name = "lstSiparisDetayı";
            this.lstSiparisDetayı.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstSiparisDetayı.ScrollAlwaysVisible = true;
            this.lstSiparisDetayı.Size = new System.Drawing.Size(448, 173);
            this.lstSiparisDetayı.TabIndex = 13;
            // 
            // lblSiparisToplam
            // 
            this.lblSiparisToplam.AutoSize = true;
            this.lblSiparisToplam.Location = new System.Drawing.Point(326, 353);
            this.lblSiparisToplam.Name = "lblSiparisToplam";
            this.lblSiparisToplam.Size = new System.Drawing.Size(81, 13);
            this.lblSiparisToplam.TabIndex = 14;
            this.lblSiparisToplam.Text = "Sipariş Toplamı:";
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(320, 116);
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(120, 20);
            this.nmrAdet.TabIndex = 15;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.ValueChanged += new System.EventHandler(this.nmrAdet_ValueChanged);
            // 
            // rdoInceKenar
            // 
            this.rdoInceKenar.AutoSize = true;
            this.rdoInceKenar.Location = new System.Drawing.Point(7, 286);
            this.rdoInceKenar.Name = "rdoInceKenar";
            this.rdoInceKenar.Size = new System.Drawing.Size(77, 17);
            this.rdoInceKenar.TabIndex = 16;
            this.rdoInceKenar.Text = "İnce Kenar";
            this.rdoInceKenar.UseVisualStyleBackColor = true;
            this.rdoInceKenar.CheckedChanged += new System.EventHandler(this.rdoInceKenar_CheckedChanged);
            // 
            // rdoKalinKenar
            // 
            this.rdoKalinKenar.AutoSize = true;
            this.rdoKalinKenar.Checked = true;
            this.rdoKalinKenar.Location = new System.Drawing.Point(98, 286);
            this.rdoKalinKenar.Name = "rdoKalinKenar";
            this.rdoKalinKenar.Size = new System.Drawing.Size(79, 17);
            this.rdoKalinKenar.TabIndex = 17;
            this.rdoKalinKenar.TabStop = true;
            this.rdoKalinKenar.Text = "Kalın Kenar";
            this.rdoKalinKenar.UseVisualStyleBackColor = true;
            this.rdoKalinKenar.CheckedChanged += new System.EventHandler(this.rdoKalinKenar_CheckedChanged);
            // 
            // cbxSalam
            // 
            this.cbxSalam.AutoSize = true;
            this.cbxSalam.Location = new System.Drawing.Point(212, 99);
            this.cbxSalam.Name = "cbxSalam";
            this.cbxSalam.Size = new System.Drawing.Size(55, 17);
            this.cbxSalam.TabIndex = 18;
            this.cbxSalam.Text = "Salam";
            this.cbxSalam.UseVisualStyleBackColor = true;
            this.cbxSalam.CheckedChanged += new System.EventHandler(this.cbxSalam_CheckedChanged);
            // 
            // cbxSosis
            // 
            this.cbxSosis.AutoSize = true;
            this.cbxSosis.Location = new System.Drawing.Point(212, 127);
            this.cbxSosis.Name = "cbxSosis";
            this.cbxSosis.Size = new System.Drawing.Size(51, 17);
            this.cbxSosis.TabIndex = 19;
            this.cbxSosis.Text = "Sosis";
            this.cbxSosis.UseVisualStyleBackColor = true;
            this.cbxSosis.CheckedChanged += new System.EventHandler(this.cbxSosis_CheckedChanged);
            // 
            // cbxSucuk
            // 
            this.cbxSucuk.AutoSize = true;
            this.cbxSucuk.Location = new System.Drawing.Point(212, 161);
            this.cbxSucuk.Name = "cbxSucuk";
            this.cbxSucuk.Size = new System.Drawing.Size(57, 17);
            this.cbxSucuk.TabIndex = 20;
            this.cbxSucuk.Text = "Sucuk";
            this.cbxSucuk.UseVisualStyleBackColor = true;
            this.cbxSucuk.CheckedChanged += new System.EventHandler(this.cbxSucuk_CheckedChanged);
            // 
            // cbxJalepeno
            // 
            this.cbxJalepeno.AutoSize = true;
            this.cbxJalepeno.Location = new System.Drawing.Point(212, 194);
            this.cbxJalepeno.Name = "cbxJalepeno";
            this.cbxJalepeno.Size = new System.Drawing.Size(69, 17);
            this.cbxJalepeno.TabIndex = 21;
            this.cbxJalepeno.Text = "Jalepeno";
            this.cbxJalepeno.UseVisualStyleBackColor = true;
            this.cbxJalepeno.CheckedChanged += new System.EventHandler(this.cbxJalepeno_CheckedChanged);
            // 
            // cbxAncuez
            // 
            this.cbxAncuez.AutoSize = true;
            this.cbxAncuez.Location = new System.Drawing.Point(212, 225);
            this.cbxAncuez.Name = "cbxAncuez";
            this.cbxAncuez.Size = new System.Drawing.Size(62, 17);
            this.cbxAncuez.TabIndex = 22;
            this.cbxAncuez.Text = "Ancuez";
            this.cbxAncuez.UseVisualStyleBackColor = true;
            this.cbxAncuez.CheckedChanged += new System.EventHandler(this.cbxAncuez_CheckedChanged);
            // 
            // cbxZeytin
            // 
            this.cbxZeytin.AutoSize = true;
            this.cbxZeytin.Location = new System.Drawing.Point(212, 257);
            this.cbxZeytin.Name = "cbxZeytin";
            this.cbxZeytin.Size = new System.Drawing.Size(55, 17);
            this.cbxZeytin.TabIndex = 23;
            this.cbxZeytin.Text = "Zeytin";
            this.cbxZeytin.UseVisualStyleBackColor = true;
            this.cbxZeytin.CheckedChanged += new System.EventHandler(this.cbxZeytin_CheckedChanged);
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.AutoSize = true;
            this.lblAraToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAraToplam.ForeColor = System.Drawing.Color.Red;
            this.lblAraToplam.Location = new System.Drawing.Point(297, 235);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Size = new System.Drawing.Size(113, 20);
            this.lblAraToplam.TabIndex = 24;
            this.lblAraToplam.Text = "lblAraToplam";
            this.lblAraToplam.Visible = false;
            // 
            // lblTL
            // 
            this.lblTL.AutoSize = true;
            this.lblTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTL.ForeColor = System.Drawing.Color.Red;
            this.lblTL.Location = new System.Drawing.Point(415, 234);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(40, 20);
            this.lblTL.TabIndex = 26;
            this.lblTL.Text = "-TL.";
            this.lblTL.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 67);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblEkstralar
            // 
            this.lblEkstralar.AutoSize = true;
            this.lblEkstralar.Location = new System.Drawing.Point(209, 75);
            this.lblEkstralar.Name = "lblEkstralar";
            this.lblEkstralar.Size = new System.Drawing.Size(54, 13);
            this.lblEkstralar.TabIndex = 28;
            this.lblEkstralar.Text = "Ekstralar: ";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplam.Location = new System.Drawing.Point(316, 375);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(102, 24);
            this.lblToplam.TabIndex = 29;
            this.lblToplam.Text = "lblToplam";
            this.lblToplam.Visible = false;
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.Location = new System.Drawing.Point(320, 286);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(98, 44);
            this.btnHepsiniSil.TabIndex = 30;
            this.btnHepsiniSil.Text = "Tüm Siparişleri Sil";
            this.btnHepsiniSil.UseVisualStyleBackColor = true;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // frmPizzaciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 592);
            this.Controls.Add(this.btnHepsiniSil);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblEkstralar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxSalam);
            this.Controls.Add(this.lblTL);
            this.Controls.Add(this.lblAraToplam);
            this.Controls.Add(this.cbxZeytin);
            this.Controls.Add(this.cbxAncuez);
            this.Controls.Add(this.cbxJalepeno);
            this.Controls.Add(this.cbxSucuk);
            this.Controls.Add(this.cbxSosis);
            this.Controls.Add(this.rdoKalinKenar);
            this.Controls.Add(this.rdoInceKenar);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.lblSiparisToplam);
            this.Controls.Add(this.lstSiparisDetayı);
            this.Controls.Add(this.cmbEbat);
            this.Controls.Add(this.lstCesit);
            this.Controls.Add(this.lblDegistir);
            this.Controls.Add(this.btnSiparisSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblSiparisDetay);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblCesit);
            this.Controls.Add(this.lblEbat);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPizzaciEkrani";
            this.Text = "Pizzacı Sipariş Ekranı";
            this.Load += new System.EventHandler(this.frmPizzaciEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblEbat;
        private System.Windows.Forms.Label lblCesit;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblSiparisDetay;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSiparisSil;
        private System.Windows.Forms.Button lblDegistir;
        private System.Windows.Forms.ListBox lstCesit;
        private System.Windows.Forms.ComboBox cmbEbat;
        private System.Windows.Forms.ListBox lstSiparisDetayı;
        private System.Windows.Forms.Label lblSiparisToplam;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.RadioButton rdoInceKenar;
        private System.Windows.Forms.RadioButton rdoKalinKenar;
        private System.Windows.Forms.CheckBox cbxSalam;
        private System.Windows.Forms.CheckBox cbxSosis;
        private System.Windows.Forms.CheckBox cbxSucuk;
        private System.Windows.Forms.CheckBox cbxJalepeno;
        private System.Windows.Forms.CheckBox cbxAncuez;
        private System.Windows.Forms.CheckBox cbxZeytin;
        private System.Windows.Forms.Label lblAraToplam;
        private System.Windows.Forms.Label lblTL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEkstralar;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnHepsiniSil;
    }
}

