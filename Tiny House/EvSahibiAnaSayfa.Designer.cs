namespace TinyHouseProjesi
{
	partial class EvSahibiAnaSayfa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvSahibiAnaSayfa));
			this.logo = new System.Windows.Forms.PictureBox();
			this.baslik = new System.Windows.Forms.Label();
			this.btnIlan = new System.Windows.Forms.Button();
			this.btnRezervasyon = new System.Windows.Forms.Button();
			this.btnYorumPuan = new System.Windows.Forms.Button();
			this.btnOdeme = new System.Windows.Forms.Button();
			this.toplamIlan = new System.Windows.Forms.Label();
			this.toplamRezervasyon = new System.Windows.Forms.Label();
			this.toplamGelir = new System.Windows.Forms.Label();
			this.ortalamaPuan = new System.Windows.Forms.Label();
			this.lblToplamIlan = new System.Windows.Forms.Label();
			this.lblToplamRezervasyon = new System.Windows.Forms.Label();
			this.lblToplamGelir = new System.Windows.Forms.Label();
			this.lblOrtalamaPuan = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
			this.SuspendLayout();
			// 
			// logo
			// 
			this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
			this.logo.Location = new System.Drawing.Point(63, 67);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(386, 304);
			this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.logo.TabIndex = 0;
			this.logo.TabStop = false;
			// 
			// baslik
			// 
			this.baslik.AutoSize = true;
			this.baslik.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.baslik.ForeColor = System.Drawing.Color.MidnightBlue;
			this.baslik.Location = new System.Drawing.Point(618, 67);
			this.baslik.Name = "baslik";
			this.baslik.Size = new System.Drawing.Size(392, 58);
			this.baslik.TabIndex = 1;
			this.baslik.Text = "ZUE\'ye Hoşgeldiniz";
			// 
			// btnIlan
			// 
			this.btnIlan.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.btnIlan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnIlan.Location = new System.Drawing.Point(696, 275);
			this.btnIlan.Name = "btnIlan";
			this.btnIlan.Size = new System.Drawing.Size(240, 60);
			this.btnIlan.TabIndex = 2;
			this.btnIlan.Text = "İlan Yönetimi";
			this.btnIlan.UseVisualStyleBackColor = false;
			this.btnIlan.Click += new System.EventHandler(this.btnIlan_Click);
			// 
			// btnRezervasyon
			// 
			this.btnRezervasyon.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.btnRezervasyon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnRezervasyon.Location = new System.Drawing.Point(696, 398);
			this.btnRezervasyon.Name = "btnRezervasyon";
			this.btnRezervasyon.Size = new System.Drawing.Size(240, 60);
			this.btnRezervasyon.TabIndex = 3;
			this.btnRezervasyon.Text = "Rezervasyon Yönetimi";
			this.btnRezervasyon.UseVisualStyleBackColor = false;
			this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
			// 
			// btnYorumPuan
			// 
			this.btnYorumPuan.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.btnYorumPuan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnYorumPuan.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnYorumPuan.Location = new System.Drawing.Point(696, 519);
			this.btnYorumPuan.Name = "btnYorumPuan";
			this.btnYorumPuan.Size = new System.Drawing.Size(240, 60);
			this.btnYorumPuan.TabIndex = 4;
			this.btnYorumPuan.Text = "Yorumlar ve Puanlar";
			this.btnYorumPuan.UseVisualStyleBackColor = false;
			this.btnYorumPuan.Click += new System.EventHandler(this.btnYorumPuan_Click);
			// 
			// btnOdeme
			// 
			this.btnOdeme.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.btnOdeme.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnOdeme.Location = new System.Drawing.Point(696, 639);
			this.btnOdeme.Name = "btnOdeme";
			this.btnOdeme.Size = new System.Drawing.Size(240, 60);
			this.btnOdeme.TabIndex = 5;
			this.btnOdeme.Text = "Ödeme Bilgileri";
			this.btnOdeme.UseVisualStyleBackColor = false;
			this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
			// 
			// toplamIlan
			// 
			this.toplamIlan.AutoSize = true;
			this.toplamIlan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.toplamIlan.Location = new System.Drawing.Point(59, 493);
			this.toplamIlan.Name = "toplamIlan";
			this.toplamIlan.Size = new System.Drawing.Size(123, 24);
			this.toplamIlan.TabIndex = 6;
			this.toplamIlan.Text = "Toplam İlan : ";
			// 
			// toplamRezervasyon
			// 
			this.toplamRezervasyon.AutoSize = true;
			this.toplamRezervasyon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.toplamRezervasyon.Location = new System.Drawing.Point(59, 555);
			this.toplamRezervasyon.Name = "toplamRezervasyon";
			this.toplamRezervasyon.Size = new System.Drawing.Size(196, 24);
			this.toplamRezervasyon.TabIndex = 7;
			this.toplamRezervasyon.Text = "Toplam Rezervasyon : ";
			// 
			// toplamGelir
			// 
			this.toplamGelir.AutoSize = true;
			this.toplamGelir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.toplamGelir.Location = new System.Drawing.Point(59, 615);
			this.toplamGelir.Name = "toplamGelir";
			this.toplamGelir.Size = new System.Drawing.Size(132, 24);
			this.toplamGelir.TabIndex = 8;
			this.toplamGelir.Text = "Toplam Gelir : ";
			// 
			// ortalamaPuan
			// 
			this.ortalamaPuan.AutoSize = true;
			this.ortalamaPuan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ortalamaPuan.Location = new System.Drawing.Point(59, 675);
			this.ortalamaPuan.Name = "ortalamaPuan";
			this.ortalamaPuan.Size = new System.Drawing.Size(153, 24);
			this.ortalamaPuan.TabIndex = 9;
			this.ortalamaPuan.Text = "Ortalama Puan : ";
			// 
			// lblToplamIlan
			// 
			this.lblToplamIlan.AutoSize = true;
			this.lblToplamIlan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblToplamIlan.Location = new System.Drawing.Point(346, 493);
			this.lblToplamIlan.Name = "lblToplamIlan";
			this.lblToplamIlan.Size = new System.Drawing.Size(20, 24);
			this.lblToplamIlan.TabIndex = 10;
			this.lblToplamIlan.Text = "0";
			// 
			// lblToplamRezervasyon
			// 
			this.lblToplamRezervasyon.AutoSize = true;
			this.lblToplamRezervasyon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblToplamRezervasyon.Location = new System.Drawing.Point(346, 555);
			this.lblToplamRezervasyon.Name = "lblToplamRezervasyon";
			this.lblToplamRezervasyon.Size = new System.Drawing.Size(20, 24);
			this.lblToplamRezervasyon.TabIndex = 11;
			this.lblToplamRezervasyon.Text = "0";
			// 
			// lblToplamGelir
			// 
			this.lblToplamGelir.AutoSize = true;
			this.lblToplamGelir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblToplamGelir.Location = new System.Drawing.Point(346, 615);
			this.lblToplamGelir.Name = "lblToplamGelir";
			this.lblToplamGelir.Size = new System.Drawing.Size(35, 24);
			this.lblToplamGelir.TabIndex = 12;
			this.lblToplamGelir.Text = "0 ₺";
			// 
			// lblOrtalamaPuan
			// 
			this.lblOrtalamaPuan.AutoSize = true;
			this.lblOrtalamaPuan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblOrtalamaPuan.Location = new System.Drawing.Point(346, 675);
			this.lblOrtalamaPuan.Name = "lblOrtalamaPuan";
			this.lblOrtalamaPuan.Size = new System.Drawing.Size(20, 24);
			this.lblOrtalamaPuan.TabIndex = 13;
			this.lblOrtalamaPuan.Text = "0";
			// 
			// EvSahibiAnaSayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1082, 853);
			this.Controls.Add(this.lblOrtalamaPuan);
			this.Controls.Add(this.lblToplamGelir);
			this.Controls.Add(this.lblToplamRezervasyon);
			this.Controls.Add(this.lblToplamIlan);
			this.Controls.Add(this.ortalamaPuan);
			this.Controls.Add(this.toplamGelir);
			this.Controls.Add(this.toplamRezervasyon);
			this.Controls.Add(this.toplamIlan);
			this.Controls.Add(this.btnOdeme);
			this.Controls.Add(this.btnYorumPuan);
			this.Controls.Add(this.btnRezervasyon);
			this.Controls.Add(this.btnIlan);
			this.Controls.Add(this.baslik);
			this.Controls.Add(this.logo);
			this.Name = "EvSahibiAnaSayfa";
			this.Text = "Ev Sahibi Ana Sayfa";
			this.Load += new System.EventHandler(this.EvSahibiAnaSayfa_Load);
			((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox logo;
		private System.Windows.Forms.Label baslik;
		private System.Windows.Forms.Button btnIlan;
		private System.Windows.Forms.Button btnRezervasyon;
		private System.Windows.Forms.Button btnYorumPuan;
		private System.Windows.Forms.Button btnOdeme;
		private System.Windows.Forms.Label toplamIlan;
		private System.Windows.Forms.Label toplamRezervasyon;
		private System.Windows.Forms.Label toplamGelir;
		private System.Windows.Forms.Label ortalamaPuan;
		private System.Windows.Forms.Label lblToplamIlan;
		private System.Windows.Forms.Label lblToplamRezervasyon;
		private System.Windows.Forms.Label lblToplamGelir;
		private System.Windows.Forms.Label lblOrtalamaPuan;
	}
}

