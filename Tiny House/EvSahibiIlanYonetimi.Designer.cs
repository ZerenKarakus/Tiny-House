namespace TinyHouseProjesi
{
	partial class EvSahibiIlanYonetimi
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
			this.dgvIlanlar = new System.Windows.Forms.DataGridView();
			this.txtBaslik = new System.Windows.Forms.TextBox();
			this.txtAciklama = new System.Windows.Forms.TextBox();
			this.txtKonum = new System.Windows.Forms.TextBox();
			this.txtFiyat = new System.Windows.Forms.TextBox();
			this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
			this.dtpBitis = new System.Windows.Forms.DateTimePicker();
			this.cmbDurum = new System.Windows.Forms.ComboBox();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnTemizle = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnResimEkle = new System.Windows.Forms.Button();
			this.pbResim = new System.Windows.Forms.PictureBox();
			this.btnResimSil = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.cmbKapasite = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvIlanlar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvIlanlar
			// 
			this.dgvIlanlar.AllowUserToAddRows = false;
			this.dgvIlanlar.AllowUserToDeleteRows = false;
			this.dgvIlanlar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvIlanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvIlanlar.Location = new System.Drawing.Point(124, 77);
			this.dgvIlanlar.MultiSelect = false;
			this.dgvIlanlar.Name = "dgvIlanlar";
			this.dgvIlanlar.ReadOnly = true;
			this.dgvIlanlar.RowHeadersWidth = 51;
			this.dgvIlanlar.RowTemplate.Height = 24;
			this.dgvIlanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvIlanlar.Size = new System.Drawing.Size(459, 179);
			this.dgvIlanlar.TabIndex = 0;
			this.dgvIlanlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIlanlar_CellClick);
			// 
			// txtBaslik
			// 
			this.txtBaslik.Location = new System.Drawing.Point(212, 421);
			this.txtBaslik.Name = "txtBaslik";
			this.txtBaslik.Size = new System.Drawing.Size(155, 22);
			this.txtBaslik.TabIndex = 1;
			// 
			// txtAciklama
			// 
			this.txtAciklama.Location = new System.Drawing.Point(212, 482);
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Size = new System.Drawing.Size(155, 22);
			this.txtAciklama.TabIndex = 2;
			// 
			// txtKonum
			// 
			this.txtKonum.Location = new System.Drawing.Point(212, 543);
			this.txtKonum.Name = "txtKonum";
			this.txtKonum.Size = new System.Drawing.Size(155, 22);
			this.txtKonum.TabIndex = 3;
			// 
			// txtFiyat
			// 
			this.txtFiyat.Location = new System.Drawing.Point(212, 606);
			this.txtFiyat.Name = "txtFiyat";
			this.txtFiyat.Size = new System.Drawing.Size(155, 22);
			this.txtFiyat.TabIndex = 4;
			// 
			// dtpBaslangic
			// 
			this.dtpBaslangic.Location = new System.Drawing.Point(788, 541);
			this.dtpBaslangic.Name = "dtpBaslangic";
			this.dtpBaslangic.Size = new System.Drawing.Size(200, 22);
			this.dtpBaslangic.TabIndex = 5;
			// 
			// dtpBitis
			// 
			this.dtpBitis.Location = new System.Drawing.Point(788, 603);
			this.dtpBitis.Name = "dtpBitis";
			this.dtpBitis.Size = new System.Drawing.Size(200, 22);
			this.dtpBitis.TabIndex = 6;
			// 
			// cmbDurum
			// 
			this.cmbDurum.FormattingEnabled = true;
			this.cmbDurum.Location = new System.Drawing.Point(788, 480);
			this.cmbDurum.Name = "cmbDurum";
			this.cmbDurum.Size = new System.Drawing.Size(121, 24);
			this.cmbDurum.TabIndex = 7;
			// 
			// btnKaydet
			// 
			this.btnKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnKaydet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKaydet.ForeColor = System.Drawing.Color.Maroon;
			this.btnKaydet.Location = new System.Drawing.Point(83, 730);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(123, 57);
			this.btnKaydet.TabIndex = 8;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = false;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnGuncelle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.ForeColor = System.Drawing.Color.Maroon;
			this.btnGuncelle.Location = new System.Drawing.Point(364, 730);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(123, 57);
			this.btnGuncelle.TabIndex = 9;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = false;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnSil
			// 
			this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSil.ForeColor = System.Drawing.Color.Maroon;
			this.btnSil.Location = new System.Drawing.Point(641, 730);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(123, 57);
			this.btnSil.TabIndex = 10;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = false;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnTemizle
			// 
			this.btnTemizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnTemizle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnTemizle.ForeColor = System.Drawing.Color.Maroon;
			this.btnTemizle.Location = new System.Drawing.Point(893, 730);
			this.btnTemizle.Name = "btnTemizle";
			this.btnTemizle.Size = new System.Drawing.Size(123, 57);
			this.btnTemizle.TabIndex = 11;
			this.btnTemizle.Text = "Temizle";
			this.btnTemizle.UseVisualStyleBackColor = false;
			this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(90, 422);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 21);
			this.label1.TabIndex = 12;
			this.label1.Text = "Başlık : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(90, 484);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 21);
			this.label2.TabIndex = 13;
			this.label2.Text = "Açıklama : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(90, 545);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 21);
			this.label3.TabIndex = 14;
			this.label3.Text = "Konum : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(90, 606);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 21);
			this.label4.TabIndex = 15;
			this.label4.Text = "Fiyat : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(637, 484);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 21);
			this.label5.TabIndex = 16;
			this.label5.Text = "Durum : ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(637, 543);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(130, 21);
			this.label6.TabIndex = 17;
			this.label6.Text = "Başlangıç Tarihi : ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(637, 605);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 21);
			this.label7.TabIndex = 18;
			this.label7.Text = "Bitiş Tarihi : ";
			// 
			// btnResimEkle
			// 
			this.btnResimEkle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnResimEkle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnResimEkle.Location = new System.Drawing.Point(715, 298);
			this.btnResimEkle.Name = "btnResimEkle";
			this.btnResimEkle.Size = new System.Drawing.Size(110, 40);
			this.btnResimEkle.TabIndex = 22;
			this.btnResimEkle.Text = "Resim Ekle";
			this.btnResimEkle.UseVisualStyleBackColor = false;
			this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
			// 
			// pbResim
			// 
			this.pbResim.Location = new System.Drawing.Point(746, 77);
			this.pbResim.Name = "pbResim";
			this.pbResim.Size = new System.Drawing.Size(217, 179);
			this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbResim.TabIndex = 23;
			this.pbResim.TabStop = false;
			// 
			// btnResimSil
			// 
			this.btnResimSil.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnResimSil.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnResimSil.Location = new System.Drawing.Point(906, 298);
			this.btnResimSil.Name = "btnResimSil";
			this.btnResimSil.Size = new System.Drawing.Size(110, 40);
			this.btnResimSil.TabIndex = 24;
			this.btnResimSil.Text = "Resmi Sil";
			this.btnResimSil.UseVisualStyleBackColor = false;
			this.btnResimSil.Click += new System.EventHandler(this.btnResimSil_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// cmbKapasite
			// 
			this.cmbKapasite.FormattingEnabled = true;
			this.cmbKapasite.Location = new System.Drawing.Point(788, 419);
			this.cmbKapasite.Name = "cmbKapasite";
			this.cmbKapasite.Size = new System.Drawing.Size(121, 24);
			this.cmbKapasite.TabIndex = 25;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(637, 421);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(79, 21);
			this.label8.TabIndex = 26;
			this.label8.Text = "Kapasite :";
			// 
			// EvSahibiIlanYonetimi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1082, 853);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cmbKapasite);
			this.Controls.Add(this.btnResimSil);
			this.Controls.Add(this.pbResim);
			this.Controls.Add(this.btnResimEkle);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnTemizle);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.cmbDurum);
			this.Controls.Add(this.dtpBitis);
			this.Controls.Add(this.dtpBaslangic);
			this.Controls.Add(this.txtFiyat);
			this.Controls.Add(this.txtKonum);
			this.Controls.Add(this.txtAciklama);
			this.Controls.Add(this.txtBaslik);
			this.Controls.Add(this.dgvIlanlar);
			this.Name = "EvSahibiIlanYonetimi";
			this.Text = "İlan Yönetimi";
			((System.ComponentModel.ISupportInitialize)(this.dgvIlanlar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvIlanlar;
		private System.Windows.Forms.TextBox txtBaslik;
		private System.Windows.Forms.TextBox txtAciklama;
		private System.Windows.Forms.TextBox txtKonum;
		private System.Windows.Forms.TextBox txtFiyat;
		private System.Windows.Forms.DateTimePicker dtpBaslangic;
		private System.Windows.Forms.DateTimePicker dtpBitis;
		private System.Windows.Forms.ComboBox cmbDurum;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnTemizle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnResimEkle;
		private System.Windows.Forms.PictureBox pbResim;
		private System.Windows.Forms.Button btnResimSil;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ComboBox cmbKapasite;
		private System.Windows.Forms.Label label8;
	}
}