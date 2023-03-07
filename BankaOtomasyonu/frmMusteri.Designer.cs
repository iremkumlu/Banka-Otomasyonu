namespace BankaOtomasyonu
{
    partial class frmMusteri
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
            this.grpHesaplar = new System.Windows.Forms.GroupBox();
            this.lstHesaplar = new System.Windows.Forms.ListBox();
            this.grpParaCekme = new System.Windows.Forms.GroupBox();
            this.txtEkBakiyepc = new System.Windows.Forms.TextBox();
            this.lblEkBakiye = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.txtBakiyepc = new System.Windows.Forms.TextBox();
            this.btnParaCekme = new System.Windows.Forms.Button();
            this.grpMusteri = new System.Windows.Forms.GroupBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.btnHesapOzeti = new System.Windows.Forms.Button();
            this.grpParaYatirma = new System.Windows.Forms.GroupBox();
            this.txtEkBakiyepy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBakiyepy = new System.Windows.Forms.TextBox();
            this.btnParaYatirma = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnHesapSil = new System.Windows.Forms.Button();
            this.lblMusteriNumarasi = new System.Windows.Forms.Label();
            this.lblEkBakiyeMiktari = new System.Windows.Forms.Label();
            this.btnHesapEkle = new System.Windows.Forms.Button();
            this.txtMusteriNumarasi = new System.Windows.Forms.TextBox();
            this.txtEkBakiye = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpMusteriHesaplari = new System.Windows.Forms.GroupBox();
            this.lstMusteriHesaplari = new System.Windows.Forms.ListBox();
            this.grpMusteriListesi = new System.Windows.Forms.GroupBox();
            this.lstMusteriler = new System.Windows.Forms.ListBox();
            this.grpHesaplariniz = new System.Windows.Forms.GroupBox();
            this.lst2Hesaplar = new System.Windows.Forms.ListBox();
            this.grpHavale = new System.Windows.Forms.GroupBox();
            this.btnHavaleYap = new System.Windows.Forms.Button();
            this.txtHavaleMiktari = new System.Windows.Forms.TextBox();
            this.lblHavaleMiktari = new System.Windows.Forms.Label();
            this.txtAliciBakiye = new System.Windows.Forms.TextBox();
            this.txtGonderenBakiye = new System.Windows.Forms.TextBox();
            this.lblAliciBakiye = new System.Windows.Forms.Label();
            this.lblGonderenBakiye = new System.Windows.Forms.Label();
            this.btnMusteriHesaplariGoruntule = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpHesaplar.SuspendLayout();
            this.grpParaCekme.SuspendLayout();
            this.grpMusteri.SuspendLayout();
            this.grpParaYatirma.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpMusteriHesaplari.SuspendLayout();
            this.grpMusteriListesi.SuspendLayout();
            this.grpHesaplariniz.SuspendLayout();
            this.grpHavale.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 630);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.grpHesaplar);
            this.tabPage1.Controls.Add(this.grpParaCekme);
            this.tabPage1.Controls.Add(this.grpMusteri);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(915, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hesap İşlemleri";
            // 
            // grpHesaplar
            // 
            this.grpHesaplar.Controls.Add(this.lstHesaplar);
            this.grpHesaplar.Location = new System.Drawing.Point(490, 22);
            this.grpHesaplar.Name = "grpHesaplar";
            this.grpHesaplar.Size = new System.Drawing.Size(394, 284);
            this.grpHesaplar.TabIndex = 7;
            this.grpHesaplar.TabStop = false;
            this.grpHesaplar.Text = "Hesap Listesi";
            // 
            // lstHesaplar
            // 
            this.lstHesaplar.FormattingEnabled = true;
            this.lstHesaplar.ItemHeight = 20;
            this.lstHesaplar.Location = new System.Drawing.Point(16, 26);
            this.lstHesaplar.Name = "lstHesaplar";
            this.lstHesaplar.Size = new System.Drawing.Size(372, 244);
            this.lstHesaplar.TabIndex = 5;
            // 
            // grpParaCekme
            // 
            this.grpParaCekme.Controls.Add(this.txtEkBakiyepc);
            this.grpParaCekme.Controls.Add(this.lblEkBakiye);
            this.grpParaCekme.Controls.Add(this.lblBakiye);
            this.grpParaCekme.Controls.Add(this.txtBakiyepc);
            this.grpParaCekme.Controls.Add(this.btnParaCekme);
            this.grpParaCekme.Location = new System.Drawing.Point(24, 435);
            this.grpParaCekme.Name = "grpParaCekme";
            this.grpParaCekme.Size = new System.Drawing.Size(412, 130);
            this.grpParaCekme.TabIndex = 7;
            this.grpParaCekme.TabStop = false;
            this.grpParaCekme.Text = "Para Çekme";
            // 
            // txtEkBakiyepc
            // 
            this.txtEkBakiyepc.Location = new System.Drawing.Point(245, 89);
            this.txtEkBakiyepc.Name = "txtEkBakiyepc";
            this.txtEkBakiyepc.Size = new System.Drawing.Size(125, 27);
            this.txtEkBakiyepc.TabIndex = 9;
            // 
            // lblEkBakiye
            // 
            this.lblEkBakiye.AutoSize = true;
            this.lblEkBakiye.Location = new System.Drawing.Point(165, 96);
            this.lblEkBakiye.Name = "lblEkBakiye";
            this.lblEkBakiye.Size = new System.Drawing.Size(71, 20);
            this.lblEkBakiye.TabIndex = 8;
            this.lblEkBakiye.Text = "Ek Bakiye";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(165, 39);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(52, 20);
            this.lblBakiye.TabIndex = 7;
            this.lblBakiye.Text = "Bakiye";
            // 
            // txtBakiyepc
            // 
            this.txtBakiyepc.Location = new System.Drawing.Point(245, 36);
            this.txtBakiyepc.Name = "txtBakiyepc";
            this.txtBakiyepc.Size = new System.Drawing.Size(125, 27);
            this.txtBakiyepc.TabIndex = 2;
            // 
            // btnParaCekme
            // 
            this.btnParaCekme.Location = new System.Drawing.Point(15, 35);
            this.btnParaCekme.Name = "btnParaCekme";
            this.btnParaCekme.Size = new System.Drawing.Size(94, 33);
            this.btnParaCekme.TabIndex = 1;
            this.btnParaCekme.Text = "Para Çekme";
            this.btnParaCekme.UseVisualStyleBackColor = true;
            this.btnParaCekme.Click += new System.EventHandler(this.btnParaCekme_Click);
            // 
            // grpMusteri
            // 
            this.grpMusteri.Controls.Add(this.lblTutar);
            this.grpMusteri.Controls.Add(this.txtTutar);
            this.grpMusteri.Controls.Add(this.btnHesapOzeti);
            this.grpMusteri.Controls.Add(this.grpParaYatirma);
            this.grpMusteri.Controls.Add(this.btnGeriDon);
            this.grpMusteri.Controls.Add(this.btnHesapSil);
            this.grpMusteri.Controls.Add(this.lblMusteriNumarasi);
            this.grpMusteri.Controls.Add(this.lblEkBakiyeMiktari);
            this.grpMusteri.Controls.Add(this.btnHesapEkle);
            this.grpMusteri.Controls.Add(this.txtMusteriNumarasi);
            this.grpMusteri.Controls.Add(this.txtEkBakiye);
            this.grpMusteri.Location = new System.Drawing.Point(24, 22);
            this.grpMusteri.Name = "grpMusteri";
            this.grpMusteri.Size = new System.Drawing.Size(885, 549);
            this.grpMusteri.TabIndex = 6;
            this.grpMusteri.TabStop = false;
            this.grpMusteri.Text = "Müşteri Hesap";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(316, 358);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(43, 20);
            this.lblTutar.TabIndex = 10;
            this.lblTutar.Text = "Tutar";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(365, 355);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(125, 27);
            this.txtTutar.TabIndex = 12;
            // 
            // btnHesapOzeti
            // 
            this.btnHesapOzeti.Location = new System.Drawing.Point(284, 164);
            this.btnHesapOzeti.Name = "btnHesapOzeti";
            this.btnHesapOzeti.Size = new System.Drawing.Size(106, 29);
            this.btnHesapOzeti.TabIndex = 11;
            this.btnHesapOzeti.Text = "Hesap Özeti";
            this.btnHesapOzeti.UseVisualStyleBackColor = true;
            this.btnHesapOzeti.Click += new System.EventHandler(this.btnHesapOzeti_Click);
            // 
            // grpParaYatirma
            // 
            this.grpParaYatirma.Controls.Add(this.txtEkBakiyepy);
            this.grpParaYatirma.Controls.Add(this.label1);
            this.grpParaYatirma.Controls.Add(this.label2);
            this.grpParaYatirma.Controls.Add(this.txtBakiyepy);
            this.grpParaYatirma.Controls.Add(this.btnParaYatirma);
            this.grpParaYatirma.Location = new System.Drawing.Point(425, 413);
            this.grpParaYatirma.Name = "grpParaYatirma";
            this.grpParaYatirma.Size = new System.Drawing.Size(420, 130);
            this.grpParaYatirma.TabIndex = 10;
            this.grpParaYatirma.TabStop = false;
            this.grpParaYatirma.Text = "Para Yatırma";
            // 
            // txtEkBakiyepy
            // 
            this.txtEkBakiyepy.Location = new System.Drawing.Point(285, 88);
            this.txtEkBakiyepy.Name = "txtEkBakiyepy";
            this.txtEkBakiyepy.Size = new System.Drawing.Size(125, 27);
            this.txtEkBakiyepy.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ek Bakiye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bakiye";
            // 
            // txtBakiyepy
            // 
            this.txtBakiyepy.Location = new System.Drawing.Point(285, 35);
            this.txtBakiyepy.Name = "txtBakiyepy";
            this.txtBakiyepy.Size = new System.Drawing.Size(125, 27);
            this.txtBakiyepy.TabIndex = 2;
            // 
            // btnParaYatirma
            // 
            this.btnParaYatirma.Location = new System.Drawing.Point(6, 38);
            this.btnParaYatirma.Name = "btnParaYatirma";
            this.btnParaYatirma.Size = new System.Drawing.Size(119, 33);
            this.btnParaYatirma.TabIndex = 1;
            this.btnParaYatirma.Text = "Para Yatırma";
            this.btnParaYatirma.UseVisualStyleBackColor = true;
            this.btnParaYatirma.Click += new System.EventHandler(this.btnParaYatirma_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(165, 229);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(106, 29);
            this.btnGeriDon.TabIndex = 6;
            this.btnGeriDon.Text = "Login Ekranı";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            // 
            // btnHesapSil
            // 
            this.btnHesapSil.Location = new System.Drawing.Point(165, 164);
            this.btnHesapSil.Name = "btnHesapSil";
            this.btnHesapSil.Size = new System.Drawing.Size(106, 29);
            this.btnHesapSil.TabIndex = 5;
            this.btnHesapSil.Text = "Hesap Sil";
            this.btnHesapSil.UseVisualStyleBackColor = true;
            this.btnHesapSil.Click += new System.EventHandler(this.btnHesapSil_Click);
            // 
            // lblMusteriNumarasi
            // 
            this.lblMusteriNumarasi.AutoSize = true;
            this.lblMusteriNumarasi.Location = new System.Drawing.Point(0, 40);
            this.lblMusteriNumarasi.Name = "lblMusteriNumarasi";
            this.lblMusteriNumarasi.Size = new System.Drawing.Size(125, 20);
            this.lblMusteriNumarasi.TabIndex = 0;
            this.lblMusteriNumarasi.Text = "Müşteri Numarası";
            // 
            // lblEkBakiyeMiktari
            // 
            this.lblEkBakiyeMiktari.AutoSize = true;
            this.lblEkBakiyeMiktari.Location = new System.Drawing.Point(0, 90);
            this.lblEkBakiyeMiktari.Name = "lblEkBakiyeMiktari";
            this.lblEkBakiyeMiktari.Size = new System.Drawing.Size(121, 20);
            this.lblEkBakiyeMiktari.TabIndex = 1;
            this.lblEkBakiyeMiktari.Text = "Ek Bakiye Miktarı";
            // 
            // btnHesapEkle
            // 
            this.btnHesapEkle.Location = new System.Drawing.Point(41, 164);
            this.btnHesapEkle.Name = "btnHesapEkle";
            this.btnHesapEkle.Size = new System.Drawing.Size(106, 29);
            this.btnHesapEkle.TabIndex = 4;
            this.btnHesapEkle.Text = "Hesap Ekle";
            this.btnHesapEkle.UseVisualStyleBackColor = true;
            this.btnHesapEkle.Click += new System.EventHandler(this.btnHesapEkle_Click);
            // 
            // txtMusteriNumarasi
            // 
            this.txtMusteriNumarasi.Location = new System.Drawing.Point(190, 42);
            this.txtMusteriNumarasi.Name = "txtMusteriNumarasi";
            this.txtMusteriNumarasi.Size = new System.Drawing.Size(125, 27);
            this.txtMusteriNumarasi.TabIndex = 2;
            // 
            // txtEkBakiye
            // 
            this.txtEkBakiye.Location = new System.Drawing.Point(190, 90);
            this.txtEkBakiye.Name = "txtEkBakiye";
            this.txtEkBakiye.Size = new System.Drawing.Size(125, 27);
            this.txtEkBakiye.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.grpMusteriHesaplari);
            this.tabPage3.Controls.Add(this.grpMusteriListesi);
            this.tabPage3.Controls.Add(this.grpHesaplariniz);
            this.tabPage3.Controls.Add(this.grpHavale);
            this.tabPage3.Controls.Add(this.btnMusteriHesaplariGoruntule);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(915, 597);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hesaba Havale";
            // 
            // grpMusteriHesaplari
            // 
            this.grpMusteriHesaplari.Controls.Add(this.lstMusteriHesaplari);
            this.grpMusteriHesaplari.Location = new System.Drawing.Point(618, 17);
            this.grpMusteriHesaplari.Name = "grpMusteriHesaplari";
            this.grpMusteriHesaplari.Size = new System.Drawing.Size(285, 284);
            this.grpMusteriHesaplari.TabIndex = 13;
            this.grpMusteriHesaplari.TabStop = false;
            this.grpMusteriHesaplari.Text = "Gönderilecek Müşterinin Hesapları";
            // 
            // lstMusteriHesaplari
            // 
            this.lstMusteriHesaplari.FormattingEnabled = true;
            this.lstMusteriHesaplari.ItemHeight = 20;
            this.lstMusteriHesaplari.Location = new System.Drawing.Point(20, 26);
            this.lstMusteriHesaplari.Name = "lstMusteriHesaplari";
            this.lstMusteriHesaplari.Size = new System.Drawing.Size(250, 244);
            this.lstMusteriHesaplari.TabIndex = 8;
            // 
            // grpMusteriListesi
            // 
            this.grpMusteriListesi.Controls.Add(this.lstMusteriler);
            this.grpMusteriListesi.Location = new System.Drawing.Point(323, 17);
            this.grpMusteriListesi.Name = "grpMusteriListesi";
            this.grpMusteriListesi.Size = new System.Drawing.Size(289, 284);
            this.grpMusteriListesi.TabIndex = 12;
            this.grpMusteriListesi.TabStop = false;
            this.grpMusteriListesi.Text = "Gönderebileceğiniz Müşteriler";
            // 
            // lstMusteriler
            // 
            this.lstMusteriler.FormattingEnabled = true;
            this.lstMusteriler.ItemHeight = 20;
            this.lstMusteriler.Location = new System.Drawing.Point(23, 26);
            this.lstMusteriler.Name = "lstMusteriler";
            this.lstMusteriler.Size = new System.Drawing.Size(250, 244);
            this.lstMusteriler.TabIndex = 7;
            // 
            // grpHesaplariniz
            // 
            this.grpHesaplariniz.Controls.Add(this.lst2Hesaplar);
            this.grpHesaplariniz.Location = new System.Drawing.Point(12, 17);
            this.grpHesaplariniz.Name = "grpHesaplariniz";
            this.grpHesaplariniz.Size = new System.Drawing.Size(281, 284);
            this.grpHesaplariniz.TabIndex = 11;
            this.grpHesaplariniz.TabStop = false;
            this.grpHesaplariniz.Text = "Size ait Hesaplar";
            // 
            // lst2Hesaplar
            // 
            this.lst2Hesaplar.FormattingEnabled = true;
            this.lst2Hesaplar.ItemHeight = 20;
            this.lst2Hesaplar.Location = new System.Drawing.Point(16, 26);
            this.lst2Hesaplar.Name = "lst2Hesaplar";
            this.lst2Hesaplar.Size = new System.Drawing.Size(250, 244);
            this.lst2Hesaplar.TabIndex = 6;
            // 
            // grpHavale
            // 
            this.grpHavale.Controls.Add(this.btnHavaleYap);
            this.grpHavale.Controls.Add(this.txtHavaleMiktari);
            this.grpHavale.Controls.Add(this.lblHavaleMiktari);
            this.grpHavale.Controls.Add(this.txtAliciBakiye);
            this.grpHavale.Controls.Add(this.txtGonderenBakiye);
            this.grpHavale.Controls.Add(this.lblAliciBakiye);
            this.grpHavale.Controls.Add(this.lblGonderenBakiye);
            this.grpHavale.Location = new System.Drawing.Point(12, 342);
            this.grpHavale.Name = "grpHavale";
            this.grpHavale.Size = new System.Drawing.Size(876, 236);
            this.grpHavale.TabIndex = 10;
            this.grpHavale.TabStop = false;
            this.grpHavale.Text = "Havale İşlemi";
            // 
            // btnHavaleYap
            // 
            this.btnHavaleYap.Location = new System.Drawing.Point(671, 59);
            this.btnHavaleYap.Name = "btnHavaleYap";
            this.btnHavaleYap.Size = new System.Drawing.Size(94, 29);
            this.btnHavaleYap.TabIndex = 14;
            this.btnHavaleYap.Text = "Havale Yap";
            this.btnHavaleYap.UseVisualStyleBackColor = true;
            this.btnHavaleYap.Click += new System.EventHandler(this.btnHavaleYap_Click);
            // 
            // txtHavaleMiktari
            // 
            this.txtHavaleMiktari.Location = new System.Drawing.Point(516, 59);
            this.txtHavaleMiktari.Name = "txtHavaleMiktari";
            this.txtHavaleMiktari.Size = new System.Drawing.Size(125, 27);
            this.txtHavaleMiktari.TabIndex = 5;
            // 
            // lblHavaleMiktari
            // 
            this.lblHavaleMiktari.AutoSize = true;
            this.lblHavaleMiktari.Location = new System.Drawing.Point(370, 59);
            this.lblHavaleMiktari.Name = "lblHavaleMiktari";
            this.lblHavaleMiktari.Size = new System.Drawing.Size(105, 20);
            this.lblHavaleMiktari.TabIndex = 4;
            this.lblHavaleMiktari.Text = "Havale Miktarı";
            // 
            // txtAliciBakiye
            // 
            this.txtAliciBakiye.Location = new System.Drawing.Point(174, 108);
            this.txtAliciBakiye.Name = "txtAliciBakiye";
            this.txtAliciBakiye.Size = new System.Drawing.Size(125, 27);
            this.txtAliciBakiye.TabIndex = 3;
            // 
            // txtGonderenBakiye
            // 
            this.txtGonderenBakiye.Location = new System.Drawing.Point(174, 52);
            this.txtGonderenBakiye.Name = "txtGonderenBakiye";
            this.txtGonderenBakiye.Size = new System.Drawing.Size(125, 27);
            this.txtGonderenBakiye.TabIndex = 2;
            // 
            // lblAliciBakiye
            // 
            this.lblAliciBakiye.AutoSize = true;
            this.lblAliciBakiye.Location = new System.Drawing.Point(16, 108);
            this.lblAliciBakiye.Name = "lblAliciBakiye";
            this.lblAliciBakiye.Size = new System.Drawing.Size(85, 20);
            this.lblAliciBakiye.TabIndex = 1;
            this.lblAliciBakiye.Text = "Alıcı Bakiye";
            // 
            // lblGonderenBakiye
            // 
            this.lblGonderenBakiye.AutoSize = true;
            this.lblGonderenBakiye.Location = new System.Drawing.Point(6, 47);
            this.lblGonderenBakiye.Name = "lblGonderenBakiye";
            this.lblGonderenBakiye.Size = new System.Drawing.Size(121, 20);
            this.lblGonderenBakiye.TabIndex = 0;
            this.lblGonderenBakiye.Text = "Gönderen Bakiye";
            // 
            // btnMusteriHesaplariGoruntule
            // 
            this.btnMusteriHesaplariGoruntule.Location = new System.Drawing.Point(638, 307);
            this.btnMusteriHesaplariGoruntule.Name = "btnMusteriHesaplariGoruntule";
            this.btnMusteriHesaplariGoruntule.Size = new System.Drawing.Size(250, 29);
            this.btnMusteriHesaplariGoruntule.TabIndex = 9;
            this.btnMusteriHesaplariGoruntule.Text = "Hesapları Görüntüle";
            this.btnMusteriHesaplariGoruntule.UseVisualStyleBackColor = true;
            this.btnMusteriHesaplariGoruntule.Click += new System.EventHandler(this.btnMusteriHesaplariGoruntule_Click);
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 654);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMusteri";
            this.Text = "Müşteri İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMusteri_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpHesaplar.ResumeLayout(false);
            this.grpParaCekme.ResumeLayout(false);
            this.grpParaCekme.PerformLayout();
            this.grpMusteri.ResumeLayout(false);
            this.grpMusteri.PerformLayout();
            this.grpParaYatirma.ResumeLayout(false);
            this.grpParaYatirma.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.grpMusteriHesaplari.ResumeLayout(false);
            this.grpMusteriListesi.ResumeLayout(false);
            this.grpHesaplariniz.ResumeLayout(false);
            this.grpHavale.ResumeLayout(false);
            this.grpHavale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnHesapEkle;
        private TextBox txtEkBakiye;
        private TextBox txtMusteriNumarasi;
        private Label lblEkBakiyeMiktari;
        private Label lblMusteriNumarasi;
        private TabPage tabPage3;
        private GroupBox grpHesaplar;
        private ListBox lstHesaplar;
        private GroupBox grpMusteri;
        private ListBox lst2Hesaplar;
        private Button btnGeriDon;
        private Button btnHesapSil;
        private GroupBox grpParaCekme;
        private TextBox txtEkBakiyepc;
        private Label lblEkBakiye;
        private Label lblBakiye;
        private TextBox txtBakiyepc;
        private Button btnParaCekme;
        private GroupBox grpParaYatirma;
        private TextBox txtEkBakiyepy;
        private Label label1;
        private Label label2;
        private TextBox txtBakiyepy;
        private Button btnParaYatirma;
        private GroupBox grpMusteriHesaplari;
        private ListBox lstMusteriHesaplari;
        private GroupBox grpMusteriListesi;
        private ListBox lstMusteriler;
        private GroupBox grpHesaplariniz;
        private GroupBox grpHavale;
        private Button btnHavaleYap;
        private TextBox txtHavaleMiktari;
        private Label lblHavaleMiktari;
        private TextBox txtAliciBakiye;
        private TextBox txtGonderenBakiye;
        private Label lblAliciBakiye;
        private Label lblGonderenBakiye;
        private Button btnMusteriHesaplariGoruntule;
        private Button btnHesapOzeti;
        private Label lblTutar;
        private TextBox txtTutar;
    }
}