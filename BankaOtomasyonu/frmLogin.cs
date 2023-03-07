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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static Musteri GirisYapan = new Musteri();
        public static Yetkili Yetkili1 = new Yetkili("SEDA", "YAPRAK", 1);
        public static Yetkili Yetkili2 = new Yetkili("IREM", "KUMLU", 1);

        private void btnGiris_Click(object sender, EventArgs e)
        {
            frmAnaForm Anasayfa = new frmAnaForm();
            frmYetkili YetkiliSayfasi = new frmYetkili();
            GirisYapan.Ad = txtKullaniciAdi.Text.ToUpper();
            GirisYapan.Soyad = txtKullaniciSoyadi.Text.ToUpper();
            GirisYapan.Sifre = Convert.ToInt32(txtSifre.Text);
            bool kontrol = true;
            if (kontrol == true)
            {
                   
            }
            if (kontrol == true)
            {
                if (GirisYapan.Ad == Yetkili1.Ad && GirisYapan.Soyad == Yetkili1.Soyad && GirisYapan.Sifre == Yetkili1.Sifre)
                {
                    this.Hide();
                    Anasayfa.ShowDialog();
                    this.Close();
                }
                else if (GirisYapan.Ad == Yetkili2.Ad && GirisYapan.Soyad == Yetkili2.Soyad && GirisYapan.Sifre == Yetkili2.Sifre)
                {
                    this.Hide();
                    Anasayfa.Show();
                    this.Close();
                }
                else if (kontrol == true)
                {
                    foreach (Musteri m in frmYetkili.banka.Musteriler)
                    {
                        if (GirisYapan.Ad == m.Ad && GirisYapan.Soyad == m.Soyad && GirisYapan.Sifre == m.Sifre)
                        {
                            this.Hide();
                            Anasayfa.Show();
                            this.Close();
                        }
                        else
                        { MessageBox.Show("Hatalı giriş yaptınız !");}
                    }   
                }
                else if (kontrol == true)
                {
                    MessageBox.Show("Hatalı giriş yaptınız.Tekrar deneyiniz!");
                    txtKullaniciAdi.Text = "";
                    txtKullaniciSoyadi.Text = "";
                    txtSifre.Text = "";
                }
            }
        }
    }
}
