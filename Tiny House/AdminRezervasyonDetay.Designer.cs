using System;
using System.Windows.Forms;
using System.Drawing;

namespace TinyHouseProjesi
{
	partial class AdminRezervasyonDetay : Form
	{
		private System.ComponentModel.IContainer components = null;

		private Label lblKiraci, lblIlan, lblBaslangic, lblBitis, lblDurum, lblOdeme;

		private void InitializeComponent()
		{
			this.lblKiraci = new System.Windows.Forms.Label();
			this.lblIlan = new System.Windows.Forms.Label();
			this.lblBaslangic = new System.Windows.Forms.Label();
			this.lblBitis = new System.Windows.Forms.Label();
			this.lblDurum = new System.Windows.Forms.Label();
			this.lblOdeme = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblKiraci
			// 
			this.lblKiraci.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblKiraci.Location = new System.Drawing.Point(271, 33);
			this.lblKiraci.Name = "lblKiraci";
			this.lblKiraci.Size = new System.Drawing.Size(161, 28);
			this.lblKiraci.TabIndex = 0;
			this.lblKiraci.Text = "_";
			// 
			// lblIlan
			// 
			this.lblIlan.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblIlan.Location = new System.Drawing.Point(271, 99);
			this.lblIlan.Name = "lblIlan";
			this.lblIlan.Size = new System.Drawing.Size(161, 28);
			this.lblIlan.TabIndex = 1;
			this.lblIlan.Text = "_";
			// 
			// lblBaslangic
			// 
			this.lblBaslangic.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBaslangic.Location = new System.Drawing.Point(268, 158);
			this.lblBaslangic.Name = "lblBaslangic";
			this.lblBaslangic.Size = new System.Drawing.Size(164, 28);
			this.lblBaslangic.TabIndex = 2;
			this.lblBaslangic.Text = "_";
			// 
			// lblBitis
			// 
			this.lblBitis.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBitis.Location = new System.Drawing.Point(268, 223);
			this.lblBitis.Name = "lblBitis";
			this.lblBitis.Size = new System.Drawing.Size(164, 28);
			this.lblBitis.TabIndex = 3;
			this.lblBitis.Text = "_";
			// 
			// lblDurum
			// 
			this.lblDurum.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDurum.Location = new System.Drawing.Point(268, 288);
			this.lblDurum.Name = "lblDurum";
			this.lblDurum.Size = new System.Drawing.Size(164, 28);
			this.lblDurum.TabIndex = 4;
			this.lblDurum.Text = "_";
			// 
			// lblOdeme
			// 
			this.lblOdeme.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblOdeme.Location = new System.Drawing.Point(268, 350);
			this.lblOdeme.Name = "lblOdeme";
			this.lblOdeme.Size = new System.Drawing.Size(164, 28);
			this.lblOdeme.TabIndex = 5;
			this.lblOdeme.Text = "_";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(49, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 28);
			this.label1.TabIndex = 6;
			this.label1.Text = "Kiracı Ad-Soyad : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(49, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 28);
			this.label2.TabIndex = 7;
			this.label2.Text = "İlan Başlığı : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(49, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(174, 28);
			this.label3.TabIndex = 8;
			this.label3.Text = "Başlangıç Tarihi : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(49, 223);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 28);
			this.label4.TabIndex = 9;
			this.label4.Text = "Bitiş Tarihi : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(49, 288);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 28);
			this.label5.TabIndex = 10;
			this.label5.Text = "Durum : ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(49, 350);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(182, 28);
			this.label6.TabIndex = 11;
			this.label6.Text = "Ödeme Durumu : ";
			// 
			// AdminRezervasyonDetay
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(460, 441);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblKiraci);
			this.Controls.Add(this.lblIlan);
			this.Controls.Add(this.lblBaslangic);
			this.Controls.Add(this.lblBitis);
			this.Controls.Add(this.lblDurum);
			this.Controls.Add(this.lblOdeme);
			this.Name = "AdminRezervasyonDetay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rezervasyon Detayları";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
	}
}
