using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public class Banka
    {
        public List<TicariMusteri> TicariMusteriler { get; set; }
        public List<BireyselMusteri> BireyselMusteriler { get; set; }
        public List<Musteri> Musteriler { get; set; }
        public List<Rapor> BankaRaporlar { get; set; }
        public List<Hesap> Hesaplar { get; set; }
        public decimal ToplamPara { get; set; }
        public decimal GelenPara { get; set; }
        public decimal GidenPara { get; set; }

        BireyselMusteri bireyselMusteri;
        TicariMusteri ticariMusteri;
        Rapor rapor;
        public Banka()
        {
            this.BankaRaporlar = new List<Rapor>();
            this.TicariMusteriler = new List<TicariMusteri>();
            BireyselMusteriler = new List<BireyselMusteri>();
            Hesaplar = new List<Hesap>();
            bireyselMusteri = new BireyselMusteri();
            ticariMusteri = new TicariMusteri();
            this.Musteriler = new List<Musteri>();

            rapor = new Rapor();
            this.ToplamPara = this.GelenPara - this.GidenPara;
            this.GelenPara = 0;
            this.GidenPara = 0;
        }
        public void MusteriEkle(Musteri m)
        {
            bool kontrol = true;
            foreach (Musteri ms in Musteriler)
            {
                if (ms.MusteriNumarasi == m.MusteriNumarasi)
                    kontrol = false;
            }
            if (kontrol == true)
                Musteriler.Add(m);
            else
                MessageBox.Show("Aynı numaraya sahip müşteri var!");
        }
        public void BireyselMusteriEkle(BireyselMusteri bm)
        {
            bool kontrol = true;
            foreach (BireyselMusteri ms in BireyselMusteriler)
            {
                if (ms.MusteriNumarasi == bm.MusteriNumarasi)
                    kontrol = false;
            }
            if (kontrol == true)
            {
                BireyselMusteriler.Add(bm);
                MessageBox.Show("Bireysel Müşteri Başarıyla Eklendi.");
            }    
            else
            { MessageBox.Show("Aynı numaraya sahip müşteri var!");}      
        }
        public void TicariMusteriEkle(TicariMusteri tm)
        {
            bool kontrol = true;
            foreach (TicariMusteri ms in TicariMusteriler)
            {
                if (ms.MusteriNumarasi == tm.MusteriNumarasi)
                    kontrol = false;
            }
            if (kontrol == true)
            {
                TicariMusteriler.Add(tm);
                MessageBox.Show("Ticari Müşteri Başarıyla Eklendi.");
            }
            else
            { MessageBox.Show("Aynı numaraya sahip müşteri var!"); }
        }
        public void RaporEkle(string rapor, DateTime tarih)
        {
            Rapor r = new Rapor();
            r.rapor = rapor;
            r.tarih = tarih;
            BankaRaporlar.Add(r);
        }
    }
}
