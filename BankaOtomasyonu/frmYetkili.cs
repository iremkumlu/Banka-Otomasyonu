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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BankaOtomasyonu
{
    public partial class frmYetkili : Form
    {
        public Banka BankaUyg;
        public frmYetkili()
        {
            InitializeComponent();
            dtgrdRapor.Columns.Add("Gelen Tutar", "Gelen Para");
            dtgrdRapor.Columns.Add("Giden Tutar", "Giden Para");
            dtgrdRapor.Columns.Add("Toplam", "Bankadaki Para");
        }
        public static Banka banka = new Banka();
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            //Müşteri Kaydı
            Musteri musteri = new Musteri();
            musteri.Ad = txtMusteriAdi.Text.ToUpper();
            musteri.Soyad = txtMusteriSoyadi.Text.ToUpper();
            musteri.Sifre = Convert.ToInt32(txtMusteriSifre.Text);
            musteri.MusteriTipi = cmbMusteriTipi.Text;
            DateTime tarih = Convert.ToDateTime(txtTarih.Text);

            frmYetkili.banka.MusteriEkle(musteri);
            lstMusteriler.Items.Add(musteri);
            foreach (Musteri m in frmYetkili.banka.Musteriler)
            {
                lstMusteriler.Items.Add(m);
                txtMusteriAdi.Text = "";
                txtMusteriSoyadi.Text = "";
                txtMusteriSifre.Text = "";
            }
            /*
            if (checkBox1.Checked == true)
            {
                BireyselMusteri bireyselMusteri = new BireyselMusteri();
                bireyselMusteri.Ad = txtMusteriAdi.Text.ToUpper();
                bireyselMusteri.Soyad = txtMusteriSoyadi.Text.ToUpper();
                bireyselMusteri.Sifre = Convert.ToInt32(txtMusteriSifre.Text);
                bireyselMusteri.MusteriTipi = "Bireysel";
                DateTime tarih = Convert.ToDateTime(txtTarih.Text);
                
                banka.MusteriEkle(bireyselMusteri);
                lstMusteriler.Items.Add(bireyselMusteri);
            }

            //Ticari Müşteri Kaydı
            else if (checkBox2.Checked == true)
            {
                TicariMusteri ticariMusteri = new TicariMusteri();
                ticariMusteri.Ad = txtMusteriAdi.Text;
                ticariMusteri.Soyad = txtMusteriSoyadi.Text;
                ticariMusteri.Sifre = Convert.ToInt32(txtMusteriSifre.Text);
                DateTime tarih = Convert.ToDateTime(txtTarih.Text);

                banka.MusteriEkle(ticariMusteri);
                lstMusteriler.Items.Add(ticariMusteri);

            }
            // Müşteri Tipi Girilmemişse
            else { MessageBox.Show("Müşteri Tipini Seçiniz! "); }
            */
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmLogin Giris = new frmLogin();
            this.Hide();
            Giris.ShowDialog();
            this.Close();
        }

        private void btnRaporGoruntule_Click(object sender, EventArgs e)
        {
            decimal gelenPara = 0;
            decimal gidenPara = 0;
            foreach (Musteri musteri in banka.Musteriler)
            {
                foreach (Hesap hesap in musteri.Hesaplar)
                {
                    foreach (HesapOzeti hareket in hesap.Defter)
                    {
                        if (hareket.IsTransfer == false)
                        {
                            gelenPara += hareket.GelenPara;
                            gidenPara += hareket.GidenPara;
                        }
                    }
                }
            }
            dtgrdRapor.Rows.Clear();
            dtgrdRapor.Rows.Add(gelenPara.ToString(), gidenPara.ToString(), (gelenPara - gidenPara).ToString());
        }
    }
}
