using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    public class HesapOzeti
    {
        public DateTime IslemTarihi;
        public decimal GelenPara;
        public decimal GidenPara;
        public Musteri HesapSahibi;
        public bool IsTransfer;
    }
}
