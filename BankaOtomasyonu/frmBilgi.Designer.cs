namespace BankaOtomasyonu
{
    partial class frmBilgi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAd1 = new System.Windows.Forms.Label();
            this.grpBilgi = new System.Windows.Forms.GroupBox();
            this.lblAd2 = new System.Windows.Forms.Label();
            this.grpBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAd1
            // 
            this.lblAd1.AutoSize = true;
            this.lblAd1.Location = new System.Drawing.Point(6, 37);
            this.lblAd1.Name = "lblAd1";
            this.lblAd1.Size = new System.Drawing.Size(166, 20);
            this.lblAd1.TabIndex = 0;
            this.lblAd1.Text = "Seda Yaprak 190604003";
            // 
            // grpBilgi
            // 
            this.grpBilgi.Controls.Add(this.lblAd2);
            this.grpBilgi.Controls.Add(this.lblAd1);
            this.grpBilgi.Location = new System.Drawing.Point(12, 12);
            this.grpBilgi.Name = "grpBilgi";
            this.grpBilgi.Size = new System.Drawing.Size(216, 126);
            this.grpBilgi.TabIndex = 1;
            this.grpBilgi.TabStop = false;
            this.grpBilgi.Text = "Hazırlayanlar";
            // 
            // lblAd2
            // 
            this.lblAd2.AutoSize = true;
            this.lblAd2.Location = new System.Drawing.Point(6, 72);
            this.lblAd2.Name = "lblAd2";
            this.lblAd2.Size = new System.Drawing.Size(161, 20);
            this.lblAd2.TabIndex = 1;
            this.lblAd2.Text = "İrem Kumlu 190601017";
            // 
            // frmBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 464);
            this.Controls.Add(this.grpBilgi);
            this.Name = "frmBilgi";
            this.Text = "BİL201 Nesne Yönelimli Programlama Dönem Projesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpBilgi.ResumeLayout(false);
            this.grpBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblAd1;
        private GroupBox grpBilgi;
        private Label lblAd2;
    }
}