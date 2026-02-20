namespace TinyHouseProjesi
{
	partial class EvSahibiOdemeBilgileri
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
			this.dgvOdemeGecmisi = new System.Windows.Forms.DataGridView();
			this.lblToplamGelir = new System.Windows.Forms.Label();
			this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
			this.dtpBitis = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnFiltrele = new System.Windows.Forms.Button();
			this.btnPDFOlustur = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvOdemeGecmisi)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvOdemeGecmisi
			// 
			this.dgvOdemeGecmisi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvOdemeGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOdemeGecmisi.Location = new System.Drawing.Point(131, 115);
			this.dgvOdemeGecmisi.Name = "dgvOdemeGecmisi";
			this.dgvOdemeGecmisi.RowHeadersWidth = 51;
			this.dgvOdemeGecmisi.RowTemplate.Height = 24;
			this.dgvOdemeGecmisi.Size = new System.Drawing.Size(823, 269);
			this.dgvOdemeGecmisi.TabIndex = 0;
			// 
			// lblToplamGelir
			// 
			this.lblToplamGelir.AutoSize = true;
			this.lblToplamGelir.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblToplamGelir.Location = new System.Drawing.Point(674, 540);
			this.lblToplamGelir.Name = "lblToplamGelir";
			this.lblToplamGelir.Size = new System.Drawing.Size(196, 28);
			this.lblToplamGelir.TabIndex = 3;
			this.lblToplamGelir.Text = "Toplam Gelir : 0.0 ₺";
			// 
			// dtpBaslangic
			// 
			this.dtpBaslangic.Location = new System.Drawing.Point(326, 512);
			this.dtpBaslangic.Name = "dtpBaslangic";
			this.dtpBaslangic.Size = new System.Drawing.Size(200, 22);
			this.dtpBaslangic.TabIndex = 7;
			// 
			// dtpBitis
			// 
			this.dtpBitis.Location = new System.Drawing.Point(326, 573);
			this.dtpBitis.Name = "dtpBitis";
			this.dtpBitis.Size = new System.Drawing.Size(200, 22);
			this.dtpBitis.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(149, 513);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 22);
			this.label2.TabIndex = 9;
			this.label2.Text = "Başlangıç Tarihi : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(149, 573);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 22);
			this.label3.TabIndex = 10;
			this.label3.Text = "Bitiş Tarihi : ";
			// 
			// btnFiltrele
			// 
			this.btnFiltrele.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnFiltrele.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnFiltrele.Location = new System.Drawing.Point(275, 755);
			this.btnFiltrele.Name = "btnFiltrele";
			this.btnFiltrele.Size = new System.Drawing.Size(125, 60);
			this.btnFiltrele.TabIndex = 11;
			this.btnFiltrele.Text = "Filtrele";
			this.btnFiltrele.UseVisualStyleBackColor = false;
			this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
			// 
			// btnPDFOlustur
			// 
			this.btnPDFOlustur.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnPDFOlustur.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnPDFOlustur.Location = new System.Drawing.Point(679, 755);
			this.btnPDFOlustur.Name = "btnPDFOlustur";
			this.btnPDFOlustur.Size = new System.Drawing.Size(125, 60);
			this.btnPDFOlustur.TabIndex = 12;
			this.btnPDFOlustur.Text = "PDF Oluştur";
			this.btnPDFOlustur.UseVisualStyleBackColor = false;
			this.btnPDFOlustur.Click += new System.EventHandler(this.btnPDFOlustur_Click);
			// 
			// EvSahibiOdemeBilgileri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1082, 853);
			this.Controls.Add(this.btnPDFOlustur);
			this.Controls.Add(this.btnFiltrele);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpBitis);
			this.Controls.Add(this.dtpBaslangic);
			this.Controls.Add(this.lblToplamGelir);
			this.Controls.Add(this.dgvOdemeGecmisi);
			this.Name = "EvSahibiOdemeBilgileri";
			this.Text = "Ödeme Bilgileri";
			this.Load += new System.EventHandler(this.EvSahibiOdemeBilgileri_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvOdemeGecmisi)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvOdemeGecmisi;
		private System.Windows.Forms.Label lblToplamGelir;
		private System.Windows.Forms.DateTimePicker dtpBaslangic;
		private System.Windows.Forms.DateTimePicker dtpBitis;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnFiltrele;
		private System.Windows.Forms.Button btnPDFOlustur;
	}
}