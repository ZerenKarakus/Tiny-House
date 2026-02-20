using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
	partial class AdminKullaniciYonetimi
	{
		private System.ComponentModel.IContainer components = null;
		private DataGridView dgvKullanicilar;
		private TextBox txtAra;
		private Button btnAra;
		private Button btnYeniEkle;
		private Button btnGuncelle;
		private Button btnPasifYap;
		private Button btnAktifYap;
		private Label lblBaslik;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminKullaniciYonetimi));
			this.lblBaslik = new System.Windows.Forms.Label();
			this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
			this.txtAra = new System.Windows.Forms.TextBox();
			this.btnAra = new System.Windows.Forms.Button();
			this.btnYeniEkle = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnPasifYap = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnAktifYap = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBaslik
			// 
			this.lblBaslik.AutoSize = true;
			this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblBaslik.Location = new System.Drawing.Point(271, 156);
			this.lblBaslik.Name = "lblBaslik";
			this.lblBaslik.Size = new System.Drawing.Size(271, 41);
			this.lblBaslik.TabIndex = 0;
			this.lblBaslik.Text = "Kullanıcı Yönetimi";
			// 
			// dgvKullanicilar
			// 
			this.dgvKullanicilar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvKullanicilar.ColumnHeadersHeight = 29;
			this.dgvKullanicilar.Location = new System.Drawing.Point(51, 267);
			this.dgvKullanicilar.Name = "dgvKullanicilar";
			this.dgvKullanicilar.ReadOnly = true;
			this.dgvKullanicilar.RowHeadersWidth = 51;
			this.dgvKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvKullanicilar.Size = new System.Drawing.Size(676, 402);
			this.dgvKullanicilar.TabIndex = 3;
			// 
			// txtAra
			// 
			this.txtAra.Location = new System.Drawing.Point(51, 223);
			this.txtAra.Name = "txtAra";
			this.txtAra.Size = new System.Drawing.Size(200, 22);
			this.txtAra.TabIndex = 0;
			// 
			// btnAra
			// 
			this.btnAra.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnAra.Location = new System.Drawing.Point(257, 223);
			this.btnAra.Name = "btnAra";
			this.btnAra.Size = new System.Drawing.Size(75, 27);
			this.btnAra.TabIndex = 1;
			this.btnAra.Text = "Ara";
			this.btnAra.UseVisualStyleBackColor = false;
			this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
			// 
			// btnYeniEkle
			// 
			this.btnYeniEkle.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnYeniEkle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnYeniEkle.Location = new System.Drawing.Point(12, 736);
			this.btnYeniEkle.Name = "btnYeniEkle";
			this.btnYeniEkle.Size = new System.Drawing.Size(143, 40);
			this.btnYeniEkle.TabIndex = 4;
			this.btnYeniEkle.Text = "Yeni Kullanıcı Ekle";
			this.btnYeniEkle.UseVisualStyleBackColor = false;
			this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnGuncelle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.Location = new System.Drawing.Point(161, 736);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(187, 40);
			this.btnGuncelle.TabIndex = 5;
			this.btnGuncelle.Text = "Seçili Kullanıcıyı Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = false;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnPasifYap
			// 
			this.btnPasifYap.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnPasifYap.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnPasifYap.Location = new System.Drawing.Point(354, 736);
			this.btnPasifYap.Name = "btnPasifYap";
			this.btnPasifYap.Size = new System.Drawing.Size(201, 40);
			this.btnPasifYap.TabIndex = 0;
			this.btnPasifYap.Text = "Seçili Kullanıcıyı Pasif Yap";
			this.btnPasifYap.UseVisualStyleBackColor = false;
			this.btnPasifYap.Click += new System.EventHandler(this.btnPasifYap_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(220, 180);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// btnAktifYap
			// 
			this.btnAktifYap.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnAktifYap.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAktifYap.Location = new System.Drawing.Point(561, 736);
			this.btnAktifYap.Name = "btnAktifYap";
			this.btnAktifYap.Size = new System.Drawing.Size(207, 40);
			this.btnAktifYap.TabIndex = 0;
			this.btnAktifYap.Text = "Seçili Kullanıcıyı Aktif Yap";
			this.btnAktifYap.UseVisualStyleBackColor = false;
			this.btnAktifYap.Click += new System.EventHandler(this.btnAktifYap_Click);
			// 
			// AdminKullaniciYonetimi
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(780, 870);
			this.Controls.Add(this.btnAktifYap);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblBaslik);
			this.Controls.Add(this.txtAra);
			this.Controls.Add(this.btnAra);
			this.Controls.Add(this.dgvKullanicilar);
			this.Controls.Add(this.btnYeniEkle);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnPasifYap);
			this.Name = "AdminKullaniciYonetimi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kullanıcı Yönetimi";
			((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private PictureBox pictureBox1;
		private Button button1;
	}
}
