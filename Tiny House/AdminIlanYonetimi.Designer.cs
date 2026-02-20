using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace TinyHouseProjesi
{
	partial class AdminIlanYonetimi
	{
		private System.ComponentModel.IContainer components = null;
		private Label lblBaslik;
		private DataGridView dgvIlanlar;
		private TextBox txtAra;
		private Button btnAra;
		private Button btnSil;
		private Button btnDuzenle;
		private Button btnDurumDegistir;
		private Button btnYeniEkle;


		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
			this.btnDurumDegistir.Click += new EventHandler(this.btnDurumDegistir_Click);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminIlanYonetimi));
			this.lblBaslik = new System.Windows.Forms.Label();
			this.dgvIlanlar = new System.Windows.Forms.DataGridView();
			this.txtAra = new System.Windows.Forms.TextBox();
			this.btnAra = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnDuzenle = new System.Windows.Forms.Button();
			this.btnDurumDegistir = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnYeniEkle = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvIlanlar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBaslik
			// 
			this.lblBaslik.AutoSize = true;
			this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblBaslik.Location = new System.Drawing.Point(292, 151);
			this.lblBaslik.Name = "lblBaslik";
			this.lblBaslik.Size = new System.Drawing.Size(203, 41);
			this.lblBaslik.TabIndex = 0;
			this.lblBaslik.Text = "İlan Yönetimi";
			// 
			// dgvIlanlar
			// 
			this.dgvIlanlar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvIlanlar.ColumnHeadersHeight = 29;
			this.dgvIlanlar.Location = new System.Drawing.Point(52, 263);
			this.dgvIlanlar.Name = "dgvIlanlar";
			this.dgvIlanlar.ReadOnly = true;
			this.dgvIlanlar.RowHeadersWidth = 51;
			this.dgvIlanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvIlanlar.Size = new System.Drawing.Size(680, 412);
			this.dgvIlanlar.TabIndex = 3;
			// 
			// txtAra
			// 
			this.txtAra.Location = new System.Drawing.Point(52, 209);
			this.txtAra.Name = "txtAra";
			this.txtAra.Size = new System.Drawing.Size(200, 22);
			this.txtAra.TabIndex = 1;
			// 
			// btnAra
			// 
			this.btnAra.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnAra.Location = new System.Drawing.Point(272, 207);
			this.btnAra.Name = "btnAra";
			this.btnAra.Size = new System.Drawing.Size(75, 29);
			this.btnAra.TabIndex = 2;
			this.btnAra.Text = "Ara";
			this.btnAra.UseVisualStyleBackColor = false;
			this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
			// 
			// btnSil
			// 
			this.btnSil.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnSil.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSil.Location = new System.Drawing.Point(361, 737);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(157, 40);
			this.btnSil.TabIndex = 5;
			this.btnSil.Text = "Seçili İlanı Sil";
			this.btnSil.UseVisualStyleBackColor = false;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnDuzenle
			// 
			this.btnDuzenle.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnDuzenle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDuzenle.Location = new System.Drawing.Point(203, 737);
			this.btnDuzenle.Name = "btnDuzenle";
			this.btnDuzenle.Size = new System.Drawing.Size(152, 40);
			this.btnDuzenle.TabIndex = 4;
			this.btnDuzenle.Text = "İlanı Düzenle";
			this.btnDuzenle.UseVisualStyleBackColor = false;
			this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
			// 
			// btnDurumDegistir
			// 
			this.btnDurumDegistir.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnDurumDegistir.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDurumDegistir.Location = new System.Drawing.Point(524, 737);
			this.btnDurumDegistir.Name = "btnDurumDegistir";
			this.btnDurumDegistir.Size = new System.Drawing.Size(208, 40);
			this.btnDurumDegistir.TabIndex = 6;
			this.btnDurumDegistir.Text = "Aktif/Pasif Yap";
			this.btnDurumDegistir.UseVisualStyleBackColor = false;
			this.btnDurumDegistir.Click += new System.EventHandler(this.btnDurumDegistir_Click);
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
			// btnYeniEkle
			// 
			this.btnYeniEkle.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnYeniEkle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnYeniEkle.Location = new System.Drawing.Point(52, 737);
			this.btnYeniEkle.Name = "btnYeniEkle";
			this.btnYeniEkle.Size = new System.Drawing.Size(145, 40);
			this.btnYeniEkle.TabIndex = 0;
			this.btnYeniEkle.Text = "Yeni İlan Ekle";
			this.btnYeniEkle.UseVisualStyleBackColor = false;
			this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
			// 
			// AdminIlanYonetimi
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(780, 870);
			this.Controls.Add(this.btnYeniEkle);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblBaslik);
			this.Controls.Add(this.txtAra);
			this.Controls.Add(this.btnAra);
			this.Controls.Add(this.dgvIlanlar);
			this.Controls.Add(this.btnDuzenle);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnDurumDegistir);
			this.Name = "AdminIlanYonetimi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "İlan Yönetimi";
			((System.ComponentModel.ISupportInitialize)(this.dgvIlanlar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private PictureBox pictureBox1;
	}
}
