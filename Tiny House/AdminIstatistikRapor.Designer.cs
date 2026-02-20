using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
	partial class AdminIstatistikRapor
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblKullaniciSayisi;
		private System.Windows.Forms.Label lblIlanSayisi;
		private System.Windows.Forms.Label lblRezervasyonSayisi;
		private System.Windows.Forms.Label lblOdemeSayisi;
		private System.Windows.Forms.Label lblToplamGelir;


		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.lblKullaniciSayisi = new System.Windows.Forms.Label();
			this.lblIlanSayisi = new System.Windows.Forms.Label();
			this.lblRezervasyonSayisi = new System.Windows.Forms.Label();
			this.lblOdemeSayisi = new System.Windows.Forms.Label();
			this.lblToplamGelir = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblKullaniciSayisi
			// 
			this.lblKullaniciSayisi.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblKullaniciSayisi.Location = new System.Drawing.Point(314, 57);
			this.lblKullaniciSayisi.Name = "lblKullaniciSayisi";
			this.lblKullaniciSayisi.Size = new System.Drawing.Size(258, 30);
			this.lblKullaniciSayisi.TabIndex = 0;
			this.lblKullaniciSayisi.Text = "_";
			// 
			// lblIlanSayisi
			// 
			this.lblIlanSayisi.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblIlanSayisi.Location = new System.Drawing.Point(316, 127);
			this.lblIlanSayisi.Name = "lblIlanSayisi";
			this.lblIlanSayisi.Size = new System.Drawing.Size(258, 30);
			this.lblIlanSayisi.TabIndex = 1;
			this.lblIlanSayisi.Text = "_";
			// 
			// lblRezervasyonSayisi
			// 
			this.lblRezervasyonSayisi.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblRezervasyonSayisi.Location = new System.Drawing.Point(316, 189);
			this.lblRezervasyonSayisi.Name = "lblRezervasyonSayisi";
			this.lblRezervasyonSayisi.Size = new System.Drawing.Size(258, 30);
			this.lblRezervasyonSayisi.TabIndex = 2;
			this.lblRezervasyonSayisi.Text = "_";
			// 
			// lblOdemeSayisi
			// 
			this.lblOdemeSayisi.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblOdemeSayisi.Location = new System.Drawing.Point(314, 260);
			this.lblOdemeSayisi.Name = "lblOdemeSayisi";
			this.lblOdemeSayisi.Size = new System.Drawing.Size(258, 30);
			this.lblOdemeSayisi.TabIndex = 3;
			this.lblOdemeSayisi.Text = "_";
			// 
			// lblToplamGelir
			// 
			this.lblToplamGelir.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblToplamGelir.Location = new System.Drawing.Point(314, 333);
			this.lblToplamGelir.Name = "lblToplamGelir";
			this.lblToplamGelir.Size = new System.Drawing.Size(258, 30);
			this.lblToplamGelir.TabIndex = 4;
			this.lblToplamGelir.Text = "_";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(27, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(243, 28);
			this.label1.TabIndex = 5;
			this.label1.Text = "Toplam Kullanıcı Sayısı : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(29, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(196, 28);
			this.label2.TabIndex = 6;
			this.label2.Text = "Toplam İlan Sayısı : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(29, 191);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(281, 28);
			this.label3.TabIndex = 7;
			this.label3.Text = "Toplam Rezervasyon Sayısı : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(29, 260);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(232, 28);
			this.label4.TabIndex = 8;
			this.label4.Text = "Toplam Ödeme Sayısı : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(29, 335);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(224, 28);
			this.label5.TabIndex = 9;
			this.label5.Text = "Toplam Gelir Miktarı : ";
			// 
			// AdminIstatistikRapor
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(600, 474);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblKullaniciSayisi);
			this.Controls.Add(this.lblIlanSayisi);
			this.Controls.Add(this.lblRezervasyonSayisi);
			this.Controls.Add(this.lblOdemeSayisi);
			this.Controls.Add(this.lblToplamGelir);
			this.Name = "AdminIstatistikRapor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "İstatistik ve Raporlar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
	}
}
