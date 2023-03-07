using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
            
        }
        Musteri Musteri = new Musteri();
        Musteri GondericiMusteri;
        public Musteri AliciMusteri;

        private void btnHesapEkle_Click(object sender, EventArgs e)
        {
            Hesap EklenecekHesap = new Hesap();
            bool kontrol = true;
            foreach (Hesap h in Musteri.Hesaplar)
            {
                if (h.HesapNumarasi == EklenecekHesap.HesapNumarasi)
                {
                    kontrol = false;
                }
            }
            if (kontrol == true)
            {
                Musteri.HesapActirma(EklenecekHesap);
                lstHesaplar.Items.Clear();
                lst2Hesaplar.Items.Clear();
                foreach (Hesap h in Musteri.Hesaplar)
                {
                    lstHesaplar.Items.Add(h);
                    lst2Hesaplar.Items.Add(h);
                }
            }
        }
        private void frmMusteri_Load(object sender, EventArgs e)
        {
            foreach (Musteri m in frmYetkili.banka.Musteriler)
            {
                if (frmLogin.GirisYapan.Ad == m.Ad && frmLogin.GirisYapan.Soyad == m.Soyad && frmLogin.GirisYapan.Sifre == m.Sifre)
                {
                    Musteri = m;
                    this.GondericiMusteri = m;
                    foreach (Hesap h in Musteri.Hesaplar)
                    {
                        lstHesaplar.Items.Add(h);
                        lst2Hesaplar.Items.Add(h);
                    }
                }
            }
            foreach (Musteri m in frmYetkili.banka.Musteriler)
            {
                lstMusteriler.Items.Add(m);
            }
        }
        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            Hesap KapanacakHesap = (Hesap)lstHesaplar.SelectedItem;
            if (KapanacakHesap.Bakiye == 0)
            {
                Musteri.HesapKapama(KapanacakHesap);
                lstHesaplar.Items.Clear();
                lst2Hesaplar.Items.Clear();
                lstHesaplar.Items.Remove(lstHesaplar.SelectedItems);
                lst2Hesaplar.Items.Remove(lstHesaplar.SelectedItems);
                foreach (Hesap h in Musteri.Hesaplar)
                {
                    lstHesaplar.Items.Add(h);
                    lst2Hesaplar.Items.Add(h);
                }
            }
            else
            { MessageBox.Show("Hesap kapatmak için bakiyeniz 0 TL olmalı !");}
        }

        private void btnHavaleYap_Click(object sender, EventArgs e)
        {
            Hesap h1 = (Hesap)lst2Hesaplar.SelectedItem;
            Hesap h2 = (Hesap)lstMusteriHesaplari.SelectedItem;
            
            decimal tutar = 0;
            tutar = Convert.ToDecimal(txtHavaleMiktari.Text);
            Musteri.HesabaHavale(h1, h2, this.GondericiMusteri, this.AliciMusteri, tutar);
            txtGonderenBakiye.Text = h1.Bakiye.ToString() + " TL";
            txtAliciBakiye.Text = h2.Bakiye.ToString() + " TL";
            txtHavaleMiktari.Text = "";
            lstHesaplar.Items.Clear();
            lst2Hesaplar.Items.Clear();
            foreach (Hesap hesap in Musteri.Hesaplar)
            {
                lstHesaplar.Items.Add(hesap);
                lst2Hesaplar.Items.Add(hesap);
            }

            Musteri m1 = (Musteri)lstMusteriler.SelectedItem;
            
            this.AliciMusteri = m1;
            lstMusteriHesaplari.Items.Clear();
            
            foreach (Musteri ms in frmYetkili.banka.Musteriler)
            {
                if (m1.MusteriNumarasi == m1.MusteriNumarasi)
                {
                    foreach (Hesap h in ms.Hesaplar)
                    {
                        lstMusteriHesaplari.Items.Add(h);
                    }
                }
            }
        }

        private void btnMusteriHesaplariGoruntule_Click(object sender, EventArgs e)
        {
            Musteri m2 = (Musteri)lstMusteriler.SelectedItem;
            this.AliciMusteri = m2;
            lstMusteriHesaplari.Items.Clear();
            
            foreach (Musteri ms in frmYetkili.banka.Musteriler)
            {
                if (m2.MusteriNumarasi == m2.MusteriNumarasi)
                {
                    foreach (Hesap h in ms.Hesaplar)
                    {
                        lstMusteriHesaplari.Items.Add(h);
                    }
                }
            }
        }
        public Hesap secilenHesap { get; set; } = new Hesap();
        private void btnHesapOzeti_Click(object sender, EventArgs e)
        {
            if (secilenHesap != null)
            {
                frmHesapOzeti HesapOzeti = new frmHesapOzeti(this.secilenHesap);
                this.Hide();
                HesapOzeti.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("secilenHesap null");
            }
        }

        private void btnParaCekme_Click(object sender, EventArgs e)
        {
            Hesap h = (Hesap)lstHesaplar.SelectedItem;
            decimal tutar = 0;
            tutar = Convert.ToInt64(txtTutar.Text);
            
            Musteri.ParaCekme(h, tutar);
            
            txtBakiyepc.Text = Convert.ToString(h.Bakiye);
            txtEkBakiyepc.Text = Convert.ToString(h.EkBakiye);
            lstHesaplar.Items.Clear();
            lst2Hesaplar.Items.Clear();
            foreach (Hesap hsp in Musteri.Hesaplar)
            {
                lstHesaplar.Items.Add(hsp);
                lst2Hesaplar.Items.Add(hsp);
            }
        }

        private void btnParaYatirma_Click(object sender, EventArgs e)
        {
            Hesap h = (Hesap)lstHesaplar.SelectedItem;
            decimal tutar = 0;
            tutar = Convert.ToInt64(txtTutar.Text);
           
            Musteri.ParaYatirma(h, tutar);
            
            txtBakiyepy.Text = Convert.ToString(h.Bakiye);
            txtEkBakiyepy.Text = Convert.ToString(h.EkBakiye);
            lstHesaplar.Items.Clear();
            lst2Hesaplar.Items.Clear();
            foreach (Hesap hsp in Musteri.Hesaplar)
            {
                lstHesaplar.Items.Add(hsp);
                lst2Hesaplar.Items.Add(hsp);
            }
        }
    }
}
