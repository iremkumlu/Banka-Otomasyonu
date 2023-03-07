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
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }
        public static Banka banka = new Banka();

        private void yetkiliİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYetkili frmYetkili = new frmYetkili();
            frmYetkili.MdiParent = this;
            frmYetkili.Show();
        }

        private void müşteriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteri frmMusteri = new frmMusteri();
            frmMusteri.MdiParent = this;
            frmMusteri.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBilgi frmBilgi = new frmBilgi();
            frmBilgi.MdiParent = this;
            frmBilgi.Show();
        }
    }
}
