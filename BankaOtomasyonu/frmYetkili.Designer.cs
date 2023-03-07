namespace BankaOtomasyonu
{
    partial class frmYetkili
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpMusteriListesi = new System.Windows.Forms.GroupBox();
            this.lstMusteriler = new System.Windows.Forms.ListBox();
            this.grpMusteri = new System.Windows.Forms.GroupBox();
            this.txtMusteriSifre = new System.Windows.Forms.TextBox();
            this.lblMusteriSifre = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.lblMusteriTipi = new System.Windows.Forms.Label();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.lblMusteriSoyadi = new System.Windows.Forms.Label();
            this.txtMusteriSoyadi = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgrdRapor = new System.Windows.Forms.DataGridView();
            this.btnRaporGoruntule = new System.Windows.Forms.Button();
            this.cmbMusteriTipi = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpMusteriListesi.SuspendLayout();
            this.grpMusteri.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(985, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.grpMusteriListesi);
            this.tabPage1.Controls.Add(this.grpMusteri);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(977, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri Ekleme";
            // 
            // grpMusteriListesi
            // 
            this.grpMusteriListesi.Controls.Add(this.lstMusteriler);
            this.grpMusteriListesi.Location = new System.Drawing.Point(433, 9);
            this.grpMusteriListesi.Name = "grpMusteriListesi";
            this.grpMusteriListesi.Size = new System.Drawing.Size(544, 381);
            this.grpMusteriListesi.TabIndex = 9;
            this.grpMusteriListesi.TabStop = false;
            this.grpMusteriListesi.Text = "Müşteri Listesi";
            // 
            // lstMusteriler
            // 
            this.lstMusteriler.FormattingEnabled = true;
            this.lstMusteriler.ItemHeight = 20;
            this.lstMusteriler.Location = new System.Drawing.Point(6, 35);
            this.lstMusteriler.Name = "lstMusteriler";
            this.lstMusteriler.Size = new System.Drawing.Size(532, 344);
            this.lstMusteriler.TabIndex = 0;
            // 
            // grpMusteri
            // 
            this.grpMusteri.Controls.Add(this.cmbMusteriTipi);
            this.grpMusteri.Controls.Add(this.txtMusteriSifre);
            this.grpMusteri.Controls.Add(this.lblMusteriSifre);
            this.grpMusteri.Controls.Add(this.btnGeriDon);
            this.grpMusteri.Controls.Add(this.lblMusteriTipi);
            this.grpMusteri.Controls.Add(this.btnMusteriEkle);
            this.grpMusteri.Controls.Add(this.lblMusteriAdi);
            this.grpMusteri.Controls.Add(this.txtTarih);
            this.grpMusteri.Controls.Add(this.lblMusteriSoyadi);
            this.grpMusteri.Controls.Add(this.txtMusteriSoyadi);
            this.grpMusteri.Controls.Add(this.lblTarih);
            this.grpMusteri.Controls.Add(this.txtMusteriAdi);
            this.grpMusteri.Location = new System.Drawing.Point(6, 6);
            this.grpMusteri.Name = "grpMusteri";
            this.grpMusteri.Size = new System.Drawing.Size(394, 381);
            this.grpMusteri.TabIndex = 8;
            this.grpMusteri.TabStop = false;
            this.grpMusteri.Text = "Müşteri Bilgileri";
            // 
            // txtMusteriSifre
            // 
            this.txtMusteriSifre.Location = new System.Drawing.Point(199, 147);
            this.txtMusteriSifre.Name = "txtMusteriSifre";
            this.txtMusteriSifre.Size = new System.Drawing.Size(143, 27);
            this.txtMusteriSifre.TabIndex = 12;
            // 
            // lblMusteriSifre
            // 
            this.lblMusteriSifre.AutoSize = true;
            this.lblMusteriSifre.Location = new System.Drawing.Point(30, 147);
            this.lblMusteriSifre.Name = "lblMusteriSifre";
            this.lblMusteriSifre.Size = new System.Drawing.Size(92, 20);
            this.lblMusteriSifre.TabIndex = 11;
            this.lblMusteriSifre.Text = "Müşteri Şifre";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(6, 316);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(133, 45);
            this.btnGeriDon.TabIndex = 10;
            this.btnGeriDon.Text = "Login Ekranı";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // lblMusteriTipi
            // 
            this.lblMusteriTipi.AutoSize = true;
            this.lblMusteriTipi.Location = new System.Drawing.Point(30, 35);
            this.lblMusteriTipi.Name = "lblMusteriTipi";
            this.lblMusteriTipi.Size = new System.Drawing.Size(87, 20);
            this.lblMusteriTipi.TabIndex = 0;
            this.lblMusteriTipi.Text = "Müşteri Tipi";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(108, 239);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(140, 60);
            this.btnMusteriEkle.TabIndex = 7;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(30, 75);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(85, 20);
            this.lblMusteriAdi.TabIndex = 1;
            this.lblMusteriAdi.Text = "Müşteri Adı";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(199, 181);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(143, 27);
            this.txtTarih.TabIndex = 6;
            // 
            // lblMusteriSoyadi
            // 
            this.lblMusteriSoyadi.AutoSize = true;
            this.lblMusteriSoyadi.Location = new System.Drawing.Point(30, 110);
            this.lblMusteriSoyadi.Name = "lblMusteriSoyadi";
            this.lblMusteriSoyadi.Size = new System.Drawing.Size(107, 20);
            this.lblMusteriSoyadi.TabIndex = 2;
            this.lblMusteriSoyadi.Text = "Müşteri Soyadı";
            // 
            // txtMusteriSoyadi
            // 
            this.txtMusteriSoyadi.Location = new System.Drawing.Point(199, 110);
            this.txtMusteriSoyadi.Name = "txtMusteriSoyadi";
            this.txtMusteriSoyadi.Size = new System.Drawing.Size(143, 27);
            this.txtMusteriSoyadi.TabIndex = 5;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(30, 181);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(40, 20);
            this.lblTarih.TabIndex = 3;
            this.lblTarih.Text = "Tarih";
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(199, 75);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(143, 27);
            this.txtMusteriAdi.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.dtgrdRapor);
            this.tabPage2.Controls.Add(this.btnRaporGoruntule);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(977, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rapor";
            // 
            // dtgrdRapor
            // 
            this.dtgrdRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdRapor.Location = new System.Drawing.Point(6, 64);
            this.dtgrdRapor.Name = "dtgrdRapor";
            this.dtgrdRapor.RowHeadersWidth = 51;
            this.dtgrdRapor.RowTemplate.Height = 29;
            this.dtgrdRapor.Size = new System.Drawing.Size(756, 323);
            this.dtgrdRapor.TabIndex = 1;
            // 
            // btnRaporGoruntule
            // 
            this.btnRaporGoruntule.Location = new System.Drawing.Point(18, 17);
            this.btnRaporGoruntule.Name = "btnRaporGoruntule";
            this.btnRaporGoruntule.Size = new System.Drawing.Size(94, 29);
            this.btnRaporGoruntule.TabIndex = 0;
            this.btnRaporGoruntule.Text = "Görüntüle";
            this.btnRaporGoruntule.UseVisualStyleBackColor = true;
            this.btnRaporGoruntule.Click += new System.EventHandler(this.btnRaporGoruntule_Click);
            // 
            // cmbMusteriTipi
            // 
            this.cmbMusteriTipi.FormattingEnabled = true;
            this.cmbMusteriTipi.Items.AddRange(new object[] {
            "Bireysel",
            "Ticari"});
            this.cmbMusteriTipi.Location = new System.Drawing.Point(199, 35);
            this.cmbMusteriTipi.Name = "cmbMusteriTipi";
            this.cmbMusteriTipi.Size = new System.Drawing.Size(143, 28);
            this.cmbMusteriTipi.TabIndex = 13;
            // 
            // frmYetkili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmYetkili";
            this.Text = "Yetkili İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpMusteriListesi.ResumeLayout(false);
            this.grpMusteri.ResumeLayout(false);
            this.grpMusteri.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label lblTarih;
        private Label lblMusteriSoyadi;
        private Label lblMusteriAdi;
        private Label lblMusteriTipi;
        private TabPage tabPage2;
        private GroupBox grpMusteriListesi;
        private ListBox lstMusteriler;
        private GroupBox grpMusteri;
        private Button btnMusteriEkle;
        private TextBox txtTarih;
        private TextBox txtMusteriSoyadi;
        private TextBox txtMusteriAdi;
        private Button btnGeriDon;
        private Button btnRaporGoruntule;
        private DataGridView dtgrdRapor;
        private TextBox txtMusteriSifre;
        private Label lblMusteriSifre;
        private ComboBox cmbMusteriTipi;
    }
}