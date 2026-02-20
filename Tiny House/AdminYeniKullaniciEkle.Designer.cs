using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
	partial class AdminYeniKullaniciEkle
	{
		private System.ComponentModel.IContainer components = null;
		private Label lblAdSoyad, lblEposta, lblSifre, lblRol;
		private TextBox txtAd, txtEposta, txtSifre;
		private ComboBox cmbRol;
		private Button btnKaydet;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.lblAdSoyad = new System.Windows.Forms.Label();
			this.lblEposta = new System.Windows.Forms.Label();
			this.lblSifre = new System.Windows.Forms.Label();
			this.lblRol = new System.Windows.Forms.Label();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.txtEposta = new System.Windows.Forms.TextBox();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblAdSoyad
			// 
			this.lblAdSoyad.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAdSoyad.Location = new System.Drawing.Point(30, 30);
			this.lblAdSoyad.Name = "lblAdSoyad";
			this.lblAdSoyad.Size = new System.Drawing.Size(100, 23);
			this.lblAdSoyad.TabIndex = 0;
			this.lblAdSoyad.Text = "Ad Soyad:";
			// 
			// lblEposta
			// 
			this.lblEposta.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblEposta.Location = new System.Drawing.Point(30, 113);
			this.lblEposta.Name = "lblEposta";
			this.lblEposta.Size = new System.Drawing.Size(100, 23);
			this.lblEposta.TabIndex = 2;
			this.lblEposta.Text = "E-posta:";
			// 
			// lblSifre
			// 
			this.lblSifre.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSifre.Location = new System.Drawing.Point(30, 159);
			this.lblSifre.Name = "lblSifre";
			this.lblSifre.Size = new System.Drawing.Size(100, 23);
			this.lblSifre.TabIndex = 4;
			this.lblSifre.Text = "Şifre:";
			// 
			// lblRol
			// 
			this.lblRol.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblRol.Location = new System.Drawing.Point(30, 206);
			this.lblRol.Name = "lblRol";
			this.lblRol.Size = new System.Drawing.Size(100, 23);
			this.lblRol.TabIndex = 6;
			this.lblRol.Text = "Rol:";
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(150, 30);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(200, 22);
			this.txtAd.TabIndex = 1;
			// 
			// txtEposta
			// 
			this.txtEposta.Location = new System.Drawing.Point(150, 113);
			this.txtEposta.Name = "txtEposta";
			this.txtEposta.Size = new System.Drawing.Size(200, 22);
			this.txtEposta.TabIndex = 3;
			// 
			// txtSifre
			// 
			this.txtSifre.Location = new System.Drawing.Point(150, 159);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.PasswordChar = '*';
			this.txtSifre.Size = new System.Drawing.Size(200, 22);
			this.txtSifre.TabIndex = 5;
			// 
			// cmbRol
			// 
			this.cmbRol.Items.AddRange(new object[] {
			"Admin",
			"EvSahibi",
			"Kiraci"});
			this.cmbRol.Location = new System.Drawing.Point(150, 206);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(200, 24);
			this.cmbRol.TabIndex = 7;
			// 
			// btnKaydet
			// 
			this.btnKaydet.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnKaydet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKaydet.ForeColor = System.Drawing.Color.Maroon;
			this.btnKaydet.Location = new System.Drawing.Point(249, 277);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(101, 45);
			this.btnKaydet.TabIndex = 8;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = false;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(30, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 21);
			this.label1.TabIndex = 9;
			this.label1.Text = "Soyad:";
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(150, 71);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(200, 22);
			this.txtSoyad.TabIndex = 10;
			// 
			// AdminYeniKullaniciEkle
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(400, 400);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblAdSoyad);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.lblEposta);
			this.Controls.Add(this.txtEposta);
			this.Controls.Add(this.lblSifre);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.lblRol);
			this.Controls.Add(this.cmbRol);
			this.Controls.Add(this.btnKaydet);
			this.Name = "AdminYeniKullaniciEkle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Yeni Kullanıcı Ekle";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private Label label1;
		private TextBox txtSoyad;
	}
}
