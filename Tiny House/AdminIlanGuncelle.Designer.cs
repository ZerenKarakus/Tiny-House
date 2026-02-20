using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
	partial class AdminIlanGuncelle
	{
		private System.ComponentModel.IContainer components = null;
		private Label lblBaslik, lblAciklama, lblUcret, lblKonum, lblDurum;
		private TextBox txtBaslik, txtAciklama, txtKonum, txtUcret;
		private ComboBox cmbDurum;
		private Button btnGuncelle;
		private int ilanID; // Dahili olarak kullanılacak

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.lblBaslik = new System.Windows.Forms.Label();
			this.lblAciklama = new System.Windows.Forms.Label();
			this.lblUcret = new System.Windows.Forms.Label();
			this.lblKonum = new System.Windows.Forms.Label();
			this.lblDurum = new System.Windows.Forms.Label();
			this.txtBaslik = new System.Windows.Forms.TextBox();
			this.txtAciklama = new System.Windows.Forms.TextBox();
			this.txtUcret = new System.Windows.Forms.TextBox();
			this.txtKonum = new System.Windows.Forms.TextBox();
			this.cmbDurum = new System.Windows.Forms.ComboBox();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblBaslik
			// 
			this.lblBaslik.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBaslik.Location = new System.Drawing.Point(44, 81);
			this.lblBaslik.Name = "lblBaslik";
			this.lblBaslik.Size = new System.Drawing.Size(100, 23);
			this.lblBaslik.TabIndex = 0;
			this.lblBaslik.Text = "Başlık:";
			// 
			// lblAciklama
			// 
			this.lblAciklama.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAciklama.Location = new System.Drawing.Point(44, 121);
			this.lblAciklama.Name = "lblAciklama";
			this.lblAciklama.Size = new System.Drawing.Size(100, 23);
			this.lblAciklama.TabIndex = 2;
			this.lblAciklama.Text = "Açıklama:";
			// 
			// lblUcret
			// 
			this.lblUcret.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblUcret.Location = new System.Drawing.Point(44, 241);
			this.lblUcret.Name = "lblUcret";
			this.lblUcret.Size = new System.Drawing.Size(100, 22);
			this.lblUcret.TabIndex = 4;
			this.lblUcret.Text = "Fiyat:";
			// 
			// lblKonum
			// 
			this.lblKonum.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblKonum.Location = new System.Drawing.Point(44, 281);
			this.lblKonum.Name = "lblKonum";
			this.lblKonum.Size = new System.Drawing.Size(100, 23);
			this.lblKonum.TabIndex = 6;
			this.lblKonum.Text = "Konum:";
			// 
			// lblDurum
			// 
			this.lblDurum.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDurum.Location = new System.Drawing.Point(44, 321);
			this.lblDurum.Name = "lblDurum";
			this.lblDurum.Size = new System.Drawing.Size(100, 23);
			this.lblDurum.TabIndex = 8;
			this.lblDurum.Text = "Durum:";
			// 
			// txtBaslik
			// 
			this.txtBaslik.Location = new System.Drawing.Point(144, 81);
			this.txtBaslik.Name = "txtBaslik";
			this.txtBaslik.Size = new System.Drawing.Size(300, 22);
			this.txtBaslik.TabIndex = 1;
			// 
			// txtAciklama
			// 
			this.txtAciklama.Location = new System.Drawing.Point(144, 121);
			this.txtAciklama.Multiline = true;
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Size = new System.Drawing.Size(300, 100);
			this.txtAciklama.TabIndex = 3;
			// 
			// txtUcret
			// 
			this.txtUcret.Location = new System.Drawing.Point(144, 241);
			this.txtUcret.Name = "txtUcret";
			this.txtUcret.Size = new System.Drawing.Size(300, 22);
			this.txtUcret.TabIndex = 5;
			// 
			// txtKonum
			// 
			this.txtKonum.Location = new System.Drawing.Point(144, 281);
			this.txtKonum.Name = "txtKonum";
			this.txtKonum.Size = new System.Drawing.Size(300, 22);
			this.txtKonum.TabIndex = 7;
			// 
			// cmbDurum
			// 
			this.cmbDurum.Items.AddRange(new object[] {
			"Aktif",
			"Pasif"});
			this.cmbDurum.Location = new System.Drawing.Point(144, 321);
			this.cmbDurum.Name = "cmbDurum";
			this.cmbDurum.Size = new System.Drawing.Size(300, 24);
			this.cmbDurum.TabIndex = 9;
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnGuncelle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.ForeColor = System.Drawing.Color.Maroon;
			this.btnGuncelle.Location = new System.Drawing.Point(333, 389);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(111, 45);
			this.btnGuncelle.TabIndex = 10;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = false;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// AdminIlanGuncelle
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(500, 500);
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
			this.Controls.Add(this.btnGuncelle);
			this.Name = "AdminIlanGuncelle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "İlan Güncelle";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
