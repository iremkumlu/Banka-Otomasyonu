using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    public class Musteri : Kisi
    {
        public int MusteriNumarasi { get; set; }
        public string MusteriTipi { get; set; }
        public List<Hesap> Hesaplar { get; set; } = new List<Hesap>();
        public Hesap MusteriHesabi { get; set; } = new Hesap();
        public Musteri()
        {
            this.MusteriHesabi = new Hesap();
            this.Hesaplar =  new List<Hesap>();
            Hesaplar.Add(MusteriHesabi);
            Random r = new Random();
            this.MusteriNumarasi = r.Next(1, 100);
            MusteriTipi = "";
        }
        public override void KisiBilgisiDoldur(string Ad, string Soyad)
        {
            base.KisiBilgisiDoldur(Ad, Soyad);
        }
        public Musteri(String ad, string soyad, int musteriNo, int sifre, string musteriTipi)
        {
            this.Ad = ad.ToUpper();
            this.Soyad = soyad.ToUpper();
            this.MusteriNumarasi = musteriNo;
            this.Sifre = sifre;
            this.MusteriTipi = musteriTipi;
        }
        public void HesapActirma(Hesap h)
        {
            Hesaplar.Add(h);
        }
        public void HesapKapama(Hesap h)
        {
            Hesaplar.Remove(h);
        }
        public void ParaCekme(Hesap h, decimal miktar)
        {
            foreach (Hesap hs in Hesaplar)
            {
                if (hs.HesapNumarasi == h.HesapNumarasi)
                {
                    // Çekilecek Miktar günlük 750TL'den fazla olmamalıdır.
                    if (miktar <= 750)
                    {
                        if (miktar <= h.Bakiye)
                        {
                            h.Bakiye -= miktar;
                            frmYetkili.banka.GidenPara -= h.Bakiye; 
                            MessageBox.Show("Hesabınızdan " + miktar + " TL çekilmiştir. \n Mevcut Bakiyeniz: " + h.Bakiye + " TL");
                        }
                        else
                        {
                            MessageBox.Show("Bakiyeniz yetersiz olduğu için ek hesabınızdan işlem yapıldı!");
                            h.EkBakiye = h.EkBakiye - miktar;
                        }
                        HesapOzeti HesapHareketi = new HesapOzeti();
                        HesapHareketi.GelenPara = 0;
                        HesapHareketi.GidenPara = miktar;
                        HesapHareketi.HesapSahibi = this;
                        HesapHareketi.IslemTarihi = DateTime.Now;
                        HesapHareketi.IsTransfer = false;

                        h.DefterEkle(HesapHareketi);
                    }
                    else
                    {
                        MessageBox.Show("Günlük para çekme limiti 750 TL'dir.İşleminiz gerçekleştirilemedi!");
                    }
                }
            }
        }
        public void ParaYatirma(Hesap h, decimal miktar)
        {
            decimal odenenBorc = 0;
            h.Bakiye += miktar;
            MessageBox.Show("Hesabınıza " + miktar + " TL eklenmiştir. \n Mevcut Bakiyeniz: " + h.Bakiye + " TL");

            //EkBakiye borcu varsa
            if (h.EkBakiye < h.Limit)//Ekbakiye borcu varsa
            {
                decimal borc = h.Limit - h.EkBakiye;
                //EkBakiye borcu varsa para yatırıldığında ilk olarak borç ödenir.
                for (decimal i = h.EkBakiye; h.EkBakiye < h.Limit; i += 0.1m)
                {
                    if (h.Bakiye == 0.0m) { break; }
                    else
                    {
                        h.Bakiye -= 0.1m;
                        odenenBorc += 0.1m;
                        h.EkBakiye += 0.1m;
                    }
                    HesapOzeti hesapOzeti = new HesapOzeti();
                    hesapOzeti.GelenPara = 0;
                    hesapOzeti.GidenPara = miktar;
                    hesapOzeti.HesapSahibi = this;
                    hesapOzeti.IslemTarihi = DateTime.Now;
                    hesapOzeti.IsTransfer = false;

                    h.DefterEkle(hesapOzeti);
                }
                MessageBox.Show(" " + borc + " TL olan ek bakiye borcunuzun '" + odenenBorc + " TL kadarı bakiyenizden alınmıştır.");
            }
        }
        public void HesabaHavale(Hesap h1, Hesap h2, Musteri m1, Musteri m2, decimal miktar)
        {
            decimal havaleucreti = 0;
            int index = 0;
            if (0 <= index && index < frmYetkili.banka.Musteriler.Count)
            {   
                Musteri M1 = frmYetkili.banka.Musteriler[index];

                if (M1.MusteriTipi == "Bireysel")
                {
                    havaleucreti = (miktar * 2) / 100;
                    MessageBox.Show("Bireysel müşteri olduğunuz için " + havaleucreti + "TL havale ücreti alındı!");
                    h1.Bakiye -= havaleucreti;
                }

                h1.Bakiye -= miktar;
                h2.Bakiye += miktar;
                HesapOzeti HesapHareketi1 = new HesapOzeti();
                HesapHareketi1.GelenPara = 0;
                HesapHareketi1.GidenPara = miktar;
                HesapHareketi1.HesapSahibi = m2;
                HesapHareketi1.IsTransfer = true;
                HesapHareketi1.IslemTarihi = DateTime.Now;

                HesapOzeti HesapHareketi2 = new HesapOzeti();
                HesapHareketi2.GidenPara = miktar;
                HesapHareketi2.GidenPara = 0;
                HesapHareketi2.IsTransfer = true;
                HesapHareketi2.HesapSahibi = m2;
                HesapHareketi2.IslemTarihi = HesapHareketi1.IslemTarihi;

                h1.DefterEkle(HesapHareketi1);
                h2.DefterEkle(HesapHareketi2);

                MessageBox.Show("Havale başarıyla gerçekleştirildi!");
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", "Ad:", Ad, " Soyad:", Soyad, " Müşteri No:", MusteriNumarasi, " Tipi:", MusteriTipi);
        }
    }

}
