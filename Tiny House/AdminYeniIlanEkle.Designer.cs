using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
	partial class AdminYeniIlanEkle
	{
		private System.ComponentModel.IContainer components = null;

		private Label lblBaslik, lblAciklama, lblUcret, lblKonum, lblDurum;
		private TextBox txtBaslik, txtAciklama, txtUcret, txtKonum;
		private ComboBox cmbDurum;
		private Button btnKaydet;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.lblBaslik = new System.Windows.Forms.Label();
			this.txtBaslik = new System.Windows.Forms.TextBox();
			this.lblAciklama = new System.Windows.Forms.Label();
			this.txtAciklama = new System.Windows.Forms.TextBox();
			this.lblUcret = new System.Windows.Forms.Label();
			this.txtUcret = new System.Windows.Forms.TextBox();
			this.lblKonum = new System.Windows.Forms.Label();
			this.txtKonum = new System.Windows.Forms.TextBox();
			this.lblDurum = new System.Windows.Forms.Label();
			this.cmbDurum = new System.Windows.Forms.ComboBox();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblBaslik
			// 
			this.lblBaslik.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBaslik.Location = new System.Drawing.Point(40, 40);
			this.lblBaslik.Name = "lblBaslik";
			this.lblBaslik.Size = new System.Drawing.Size(100, 23);
			this.lblBaslik.TabIndex = 0;
			this.lblBaslik.Text = "Başlık:";
			// 
			// txtBaslik
			// 
			this.txtBaslik.Location = new System.Drawing.Point(140, 40);
			this.txtBaslik.Name = "txtBaslik";
			this.txtBaslik.Size = new System.Drawing.Size(300, 22);
			this.txtBaslik.TabIndex = 1;
			// 
			// lblAciklama
			// 
			this.lblAciklama.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAciklama.Location = new System.Drawing.Point(40, 80);
			this.lblAciklama.Name = "lblAciklama";
			this.lblAciklama.Size = new System.Drawing.Size(100, 23);
			this.lblAciklama.TabIndex = 2;
			this.lblAciklama.Text = "Açıklama:";
			// 
			// txtAciklama
			// 
			this.txtAciklama.Location = new System.Drawing.Point(140, 80);
			this.txtAciklama.Multiline = true;
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Size = new System.Drawing.Size(300, 100);
			this.txtAciklama.TabIndex = 3;
			// 
			// lblUcret
			// 
			this.lblUcret.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblUcret.Location = new System.Drawing.Point(40, 200);
			this.lblUcret.Name = "lblUcret";
			this.lblUcret.Size = new System.Drawing.Size(100, 23);
			this.lblUcret.TabIndex = 4;
			this.lblUcret.Text = "Fiyat:";
			// 
			// txtUcret
			// 
			this.txtUcret.Location = new System.Drawing.Point(140, 200);
			this.txtUcret.Name = "txtUcret";
			this.txtUcret.Size = new System.Drawing.Size(300, 22);
			this.txtUcret.TabIndex = 5;
			// 
			// lblKonum
			// 
			this.lblKonum.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblKonum.Location = new System.Drawing.Point(40, 240);
			this.lblKonum.Name = "lblKonum";
			this.lblKonum.Size = new System.Drawing.Size(100, 23);
			this.lblKonum.TabIndex = 6;
			this.lblKonum.Text = "Konum:";
			// 
			// txtKonum
			// 
			this.txtKonum.Location = new System.Drawing.Point(140, 240);
			this.txtKonum.Name = "txtKonum";
			this.txtKonum.Size = new System.Drawing.Size(300, 22);
			this.txtKonum.TabIndex = 7;
			// 
			// lblDurum
			// 
			this.lblDurum.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDurum.Location = new System.Drawing.Point(40, 280);
			this.lblDurum.Name = "lblDurum";
			this.lblDurum.Size = new System.Drawing.Size(100, 23);
			this.lblDurum.TabIndex = 8;
			this.lblDurum.Text = "Durum:";
			// 
			// cmbDurum
			// 
			this.cmbDurum.Items.AddRange(new object[] {
			"Aktif",
			"Pasif"});
			this.cmbDurum.Location = new System.Drawing.Point(140, 280);
			this.cmbDurum.Name = "cmbDurum";
			this.cmbDurum.Size = new System.Drawing.Size(300, 24);
			this.cmbDurum.TabIndex = 9;
			// 
			// btnKaydet
			// 
			this.btnKaydet.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnKaydet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKaydet.ForeColor = System.Drawing.Color.Maroon;
			this.btnKaydet.Location = new System.Drawing.Point(333, 354);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(107, 45);
			this.btnKaydet.TabIndex = 10;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = false;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// AdminYeniIlanEkle
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(500, 450);
			this.Controls.Add(this.lblBaslik);
			this.Controls.Add(this.txtBaslik);
			this.Controls.Add(this.lblAciklama);
			this.Controls.Add(this.txtAciklama);
			this.Controls.Add(this.lblUcret);
			this.Controls.Add(this.txtUcret);
			this.Controls.Add(this.lblKonum);
			this.Controls.Add(this.txtKonum);
			this.Controls.Add(this.lblDurum);
			this.Controls.Add(this.cmbDurum);
			this.Controls.Add(this.btnKaydet);
			this.Name = "AdminYeniIlanEkle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Yeni İlan Ekle";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

	}
}
