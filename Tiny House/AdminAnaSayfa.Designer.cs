using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
	partial class AdminAnaSayfa
	{
		private System.ComponentModel.IContainer components = null;
		private Label lblBaslik;
		private Button btnKullaniciYonetimi;
		private Button btnIlanYonetimi;
		private Button btnRezervasyonYonetimi;
		private Button btnOdemeYonetimi;
		private Button btnIstatistik;
		private PictureBox pictureBox1;
		private Label lblKullaniciSayisi;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAnaSayfa));
			this.lblBaslik = new System.Windows.Forms.Label();
			this.btnKullaniciYonetimi = new System.Windows.Forms.Button();
			this.btnIlanYonetimi = new System.Windows.Forms.Button();
			this.btnRezervasyonYonetimi = new System.Windows.Forms.Button();
			this.btnOdemeYonetimi = new System.Windows.Forms.Button();
			this.btnIstatistik = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblKullaniciSayisi = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBaslik
			// 
			this.lblBaslik.AutoSize = true;
			this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
			this.lblBaslik.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblBaslik.Location = new System.Drawing.Point(265, 224);
			this.lblBaslik.Name = "lblBaslik";
			this.lblBaslik.Size = new System.Drawing.Size(258, 46);
			this.lblBaslik.TabIndex = 1;
			this.lblBaslik.Text = "Yönetim Paneli";
			// 
			// btnKullaniciYonetimi
			// 
			this.btnKullaniciYonetimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnKullaniciYonetimi.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnKullaniciYonetimi.Location = new System.Drawing.Point(242, 314);
			this.btnKullaniciYonetimi.Name = "btnKullaniciYonetimi";
			this.btnKullaniciYonetimi.Size = new System.Drawing.Size(300, 50);
			this.btnKullaniciYonetimi.TabIndex = 2;
			this.btnKullaniciYonetimi.Text = "Kullanıcı Yönetimi";
			this.btnKullaniciYonetimi.UseVisualStyleBackColor = false;
			this.btnKullaniciYonetimi.Click += new System.EventHandler(this.btnKullaniciYonetimi_Click);
			// 
			// btnIlanYonetimi
			// 
			this.btnIlanYonetimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnIlanYonetimi.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnIlanYonetimi.Location = new System.Drawing.Point(242, 384);
			this.btnIlanYonetimi.Name = "btnIlanYonetimi";
			this.btnIlanYonetimi.Size = new System.Drawing.Size(300, 50);
			this.btnIlanYonetimi.TabIndex = 3;
			this.btnIlanYonetimi.Text = "İlan Yönetimi";
			this.btnIlanYonetimi.UseVisualStyleBackColor = false;
			this.btnIlanYonetimi.Click += new System.EventHandler(this.btnIlanYonetimi_Click);
			// 
			// btnRezervasyonYonetimi
			// 
			this.btnRezervasyonYonetimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnRezervasyonYonetimi.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnRezervasyonYonetimi.Location = new System.Drawing.Point(242, 454);
			this.btnRezervasyonYonetimi.Name = "btnRezervasyonYonetimi";
			this.btnRezervasyonYonetimi.Size = new System.Drawing.Size(300, 50);
			this.btnRezervasyonYonetimi.TabIndex = 4;
			this.btnRezervasyonYonetimi.Text = "Rezervasyon Yönetimi";
			this.btnRezervasyonYonetimi.UseVisualStyleBackColor = false;
			this.btnRezervasyonYonetimi.Click += new System.EventHandler(this.btnRezervasyonYonetimi_Click);
			// 
			// btnOdemeYonetimi
			// 
			this.btnOdemeYonetimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnOdemeYonetimi.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnOdemeYonetimi.Location = new System.Drawing.Point(242, 524);
			this.btnOdemeYonetimi.Name = "btnOdemeYonetimi";
			this.btnOdemeYonetimi.Size = new System.Drawing.Size(300, 50);
			this.btnOdemeYonetimi.TabIndex = 5;
			this.btnOdemeYonetimi.Text = "Ödeme Yönetimi";
			this.btnOdemeYonetimi.UseVisualStyleBackColor = false;
			this.btnOdemeYonetimi.Click += new System.EventHandler(this.btnOdemeYonetimi_Click);
			// 
			// btnIstatistik
			// 
			this.btnIstatistik.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnIstatistik.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnIstatistik.Location = new System.Drawing.Point(242, 594);
			this.btnIstatistik.Name = "btnIstatistik";
			this.btnIstatistik.Size = new System.Drawing.Size(300, 50);
			this.btnIstatistik.TabIndex = 6;
			this.btnIstatistik.Text = "İstatistik ve Raporlar";
			this.btnIstatistik.UseVisualStyleBackColor = false;
			this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(220, 180);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lblKullaniciSayisi
			// 
			this.lblKullaniciSayisi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.lblKullaniciSayisi.Location = new System.Drawing.Point(242, 673);
			this.lblKullaniciSayisi.Name = "lblKullaniciSayisi";
			this.lblKullaniciSayisi.Size = new System.Drawing.Size(300, 40);
			this.lblKullaniciSayisi.TabIndex = 7;
			this.lblKullaniciSayisi.Text = "Toplam Kullanıcı: -";
			// 
			// AdminAnaSayfa
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(780, 870);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblBaslik);
			this.Controls.Add(this.btnKullaniciYonetimi);
			this.Controls.Add(this.btnIlanYonetimi);
			this.Controls.Add(this.btnRezervasyonYonetimi);
			this.Controls.Add(this.btnOdemeYonetimi);
			this.Controls.Add(this.btnIstatistik);
			this.Controls.Add(this.lblKullaniciSayisi);
			this.Name = "AdminAnaSayfa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin Paneli";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
