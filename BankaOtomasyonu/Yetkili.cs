using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    public class Yetkili : Kisi
    {
        public Yetkili(string Ad, string Soyad, int Sifre)
        {
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.Sifre = Sifre;
        }
        public override void KisiBilgisiDoldur(string Ad, string Soyad)
        {
            base.KisiBilgisiDoldur(Ad, Soyad);
        }
    }
}
