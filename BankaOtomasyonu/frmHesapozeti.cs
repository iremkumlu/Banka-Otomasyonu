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
    public partial class frmHesapOzeti : Form
    {
        public Hesap hesapOzeti;
        public frmHesapOzeti(Hesap gosterilecekHesapOzeti)
        {
            InitializeComponent();
            this.hesapOzeti = gosterilecekHesapOzeti;
            dataGridView1.Columns.Add("Miktar", "Çekilen/Yatırılan");
            dataGridView1.Columns.Add("Kime", "Kime/Kimden");
            dataGridView1.Columns.Add("Tarih", "İşlem Tarihi");
            dataGridView1.Columns.Add("Tip", "İşlem Tipi");          
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = dateTimePicker1.Value;
            DateTime bitisTarihi = dateTimePicker2.Value;
            hesapOzeti.LoadHesapHareketleriToGridView(dataGridView1, baslangicTarihi, bitisTarihi);
        }
    }
}
