using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    public class Hesap
    {
        public int HesapNumarasi { get; set; }
        public decimal Bakiye { get; set; }
        public decimal EkBakiye { get; set; }
        public decimal GunlukLimit { get; set; }
        public decimal Limit { get; set; }
        public List<HesapOzeti> Defter;

        public Hesap()
        {
            Random r = new Random();
            this.HesapNumarasi = r.Next(1, 100);
            this.Bakiye = 100;
            this.EkBakiye = 2000;
            this.Defter = new List<HesapOzeti>();
        }
        public void DefterEkle(HesapOzeti ozet)
        {
            Defter.Add(ozet);
        }
        public void LoadHesapHareketleriToGridView(DataGridView grid, DateTime baslangic, DateTime bitis)
        {
            string tutar = "";
            string kim = "";
            string tur = "";
            grid.Rows.Clear();
            foreach (HesapOzeti hesap_hareketi in this.Defter)
            {
                if (hesap_hareketi.IslemTarihi.Date >= baslangic.Date && hesap_hareketi.IslemTarihi.Date <= bitis.Date)
                {
                    if (hesap_hareketi.GelenPara != 0)
                        tutar = "+" + hesap_hareketi.GelenPara;
                    else
                        tutar = "-" + hesap_hareketi.GidenPara;
                    if (hesap_hareketi.IsTransfer == false)
                    {
                        kim = "";
                        tur = "ATM";
                    }
                    else
                    {
                        kim = hesap_hareketi.HesapSahibi.Ad + " " + hesap_hareketi.HesapSahibi.Soyad;
                        tur = "Havale";
                    }

                    grid.Rows.Add(tutar, kim, hesap_hareketi.IslemTarihi.ToShortDateString(), tur);
                }
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", "Hesap No:", HesapNumarasi, " Bakiye:", Bakiye, "TL", "Ek Hesap Bakiye:", EkBakiye, "TL");
        }
    }
}
