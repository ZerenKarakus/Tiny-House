namespace TinyHouseProjesi
{
	partial class EvSahibiRezYonetimi
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
			this.dgvRezervasyonlar = new System.Windows.Forms.DataGridView();
			this.txtKiraci = new System.Windows.Forms.TextBox();
			this.txtIlan = new System.Windows.Forms.TextBox();
			this.txtOdemeDurumu = new System.Windows.Forms.TextBox();
			this.txtTarih = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnYenile = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtRezID = new System.Windows.Forms.TextBox();
			this.cmbDurum = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvRezervasyonlar
			// 
			this.dgvRezervasyonlar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvRezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRezervasyonlar.Location = new System.Drawing.Point(106, 89);
			this.dgvRezervasyonlar.Name = "dgvRezervasyonlar";
			this.dgvRezervasyonlar.RowHeadersWidth = 51;
			this.dgvRezervasyonlar.RowTemplate.Height = 24;
			this.dgvRezervasyonlar.Size = new System.Drawing.Size(843, 238);
			this.dgvRezervasyonlar.TabIndex = 0;
			this.dgvRezervasyonlar.SelectionChanged += new System.EventHandler(this.dgvRezervasyonlar_SelectionChanged);
			// 
			// txtKiraci
			// 
			this.txtKiraci.BackColor = System.Drawing.SystemColors.Window;
			this.txtKiraci.Location = new System.Drawing.Point(193, 536);
			this.txtKiraci.Name = "txtKiraci";
			this.txtKiraci.ReadOnly = true;
			this.txtKiraci.Size = new System.Drawing.Size(175, 22);
			this.txtKiraci.TabIndex = 1;
			// 
			// txtIlan
			// 
			this.txtIlan.BackColor = System.Drawing.SystemColors.Window;
			this.txtIlan.Location = new System.Drawing.Point(193, 648);
			this.txtIlan.Name = "txtIlan";
			this.txtIlan.ReadOnly = true;
			this.txtIlan.Size = new System.Drawing.Size(175, 22);
			this.txtIlan.TabIndex = 2;
			// 
			// txtOdemeDurumu
			// 
			this.txtOdemeDurumu.BackColor = System.Drawing.SystemColors.Window;
			this.txtOdemeDurumu.Location = new System.Drawing.Point(740, 536);
			this.txtOdemeDurumu.Name = "txtOdemeDurumu";
			this.txtOdemeDurumu.ReadOnly = true;
			this.txtOdemeDurumu.Size = new System.Drawing.Size(192, 22);
			this.txtOdemeDurumu.TabIndex = 3;
			// 
			// txtTarih
			// 
			this.txtTarih.BackColor = System.Drawing.SystemColors.Window;
			this.txtTarih.Location = new System.Drawing.Point(740, 444);
			this.txtTarih.Name = "txtTarih";
			this.txtTarih.ReadOnly = true;
			this.txtTarih.Size = new System.Drawing.Size(192, 22);
			this.txtTarih.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(41, 537);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 21);
			this.label1.TabIndex = 6;
			this.label1.Text = "Kiracı : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(41, 648);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 21);
			this.label2.TabIndex = 7;
			this.label2.Text = "İlan : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(530, 445);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 21);
			this.label3.TabIndex = 8;
			this.label3.Text = "Tarih : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(530, 537);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(138, 21);
			this.label4.TabIndex = 9;
			this.label4.Text = "Ödeme Durumu : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(530, 651);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 21);
			this.label5.TabIndex = 10;
			this.label5.Text = "Durum : ";
			// 
			// btnYenile
			// 
			this.btnYenile.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnYenile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnYenile.ForeColor = System.Drawing.Color.Maroon;
			this.btnYenile.Location = new System.Drawing.Point(810, 732);
			this.btnYenile.Name = "btnYenile";
			this.btnYenile.Size = new System.Drawing.Size(201, 85);
			this.btnYenile.TabIndex = 13;
			this.btnYenile.Text = "Güncelle";
			this.btnYenile.UseVisualStyleBackColor = false;
			this.btnYenile.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(41, 444);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(137, 21);
			this.label6.TabIndex = 14;
			this.label6.Text = "Rezervasyon No : ";
			// 
			// txtRezID
			// 
			this.txtRezID.BackColor = System.Drawing.SystemColors.Window;
			this.txtRezID.Location = new System.Drawing.Point(193, 444);
			this.txtRezID.Name = "txtRezID";
			this.txtRezID.ReadOnly = true;
			this.txtRezID.Size = new System.Drawing.Size(175, 22);
			this.txtRezID.TabIndex = 15;
			// 
			// cmbDurum
			// 
			this.cmbDurum.FormattingEnabled = true;
			this.cmbDurum.Location = new System.Drawing.Point(740, 648);
			this.cmbDurum.Name = "cmbDurum";
			this.cmbDurum.Size = new System.Drawing.Size(192, 24);
			this.cmbDurum.TabIndex = 18;
			// 
			// EvSahibiRezYonetimi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1082, 853);
			this.Controls.Add(this.cmbDurum);
			this.Controls.Add(this.txtRezID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnYenile);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTarih);
			this.Controls.Add(this.txtOdemeDurumu);
			this.Controls.Add(this.txtIlan);
			this.Controls.Add(this.txtKiraci);
			this.Controls.Add(this.dgvRezervasyonlar);
			this.Name = "EvSahibiRezYonetimi";
			this.Text = "Rezervasyon Yönetimi";
			this.Load += new System.EventHandler(this.EvSahibiRezYonetimi_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvRezervasyonlar;
		private System.Windows.Forms.TextBox txtKiraci;
		private System.Windows.Forms.TextBox txtIlan;
		private System.Windows.Forms.TextBox txtOdemeDurumu;
		private System.Windows.Forms.TextBox txtTarih;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnYenile;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtRezID;
		private System.Windows.Forms.ComboBox cmbDurum;
	}
}