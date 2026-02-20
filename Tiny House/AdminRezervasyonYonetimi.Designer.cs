using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
	partial class AdminRezervasyonYonetimi
	{
		private System.ComponentModel.IContainer components = null;
		private Label lblBaslik;
		private DataGridView dgvRezervasyonlar;
		private TextBox txtAra;
		private Button btnAra;
		private Button btnIptalEt;
		private Button btnDetaylar;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRezervasyonYonetimi));
			this.lblBaslik = new System.Windows.Forms.Label();
			this.dgvRezervasyonlar = new System.Windows.Forms.DataGridView();
			this.txtAra = new System.Windows.Forms.TextBox();
			this.btnAra = new System.Windows.Forms.Button();
			this.btnIptalEt = new System.Windows.Forms.Button();
			this.btnDetaylar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblToplamRezervasyon = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBaslik
			// 
			this.lblBaslik.AutoSize = true;
			this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblBaslik.Location = new System.Drawing.Point(240, 155);
			this.lblBaslik.Name = "lblBaslik";
			this.lblBaslik.Size = new System.Drawing.Size(325, 41);
			this.lblBaslik.TabIndex = 0;
			this.lblBaslik.Text = "Rezervasyon Yönetimi";
			// 
			// dgvRezervasyonlar
			// 
			this.dgvRezervasyonlar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvRezervasyonlar.ColumnHeadersHeight = 29;
			this.dgvRezervasyonlar.Location = new System.Drawing.Point(50, 255);
			this.dgvRezervasyonlar.Name = "dgvRezervasyonlar";
			this.dgvRezervasyonlar.ReadOnly = true;
			this.dgvRezervasyonlar.RowHeadersWidth = 51;
			this.dgvRezervasyonlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRezervasyonlar.Size = new System.Drawing.Size(683, 383);
			this.dgvRezervasyonlar.TabIndex = 3;
			// 
			// txtAra
			// 
			this.txtAra.Location = new System.Drawing.Point(50, 215);
			this.txtAra.Name = "txtAra";
			this.txtAra.Size = new System.Drawing.Size(200, 22);
			this.txtAra.TabIndex = 1;
			// 
			// btnAra
			// 
			this.btnAra.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnAra.Location = new System.Drawing.Point(270, 213);
			this.btnAra.Name = "btnAra";
			this.btnAra.Size = new System.Drawing.Size(75, 29);
			this.btnAra.TabIndex = 2;
			this.btnAra.Text = "Ara";
			this.btnAra.UseVisualStyleBackColor = false;
			this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
			// 
			// btnIptalEt
			// 
			this.btnIptalEt.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnIptalEt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnIptalEt.Location = new System.Drawing.Point(270, 680);
			this.btnIptalEt.Name = "btnIptalEt";
			this.btnIptalEt.Size = new System.Drawing.Size(250, 40);
			this.btnIptalEt.TabIndex = 5;
			this.btnIptalEt.Text = "Rezervasyonu İptal Et";
			this.btnIptalEt.UseVisualStyleBackColor = false;
			this.btnIptalEt.Click += new System.EventHandler(this.btnIptalEt_Click);
			// 
			// btnDetaylar
			// 
			this.btnDetaylar.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnDetaylar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDetaylar.Location = new System.Drawing.Point(50, 680);
			this.btnDetaylar.Name = "btnDetaylar";
			this.btnDetaylar.Size = new System.Drawing.Size(200, 40);
			this.btnDetaylar.TabIndex = 4;
			this.btnDetaylar.Text = "Detaylar";
			this.btnDetaylar.UseVisualStyleBackColor = false;
			this.btnDetaylar.Click += new System.EventHandler(this.btnDetaylar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(9, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(220, 180);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// lblToplamRezervasyon
			// 
			this.lblToplamRezervasyon.AutoSize = true;
			this.lblToplamRezervasyon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblToplamRezervasyon.Location = new System.Drawing.Point(306, 754);
			this.lblToplamRezervasyon.Name = "lblToplamRezervasyon";
			this.lblToplamRezervasyon.Size = new System.Drawing.Size(20, 24);
			this.lblToplamRezervasyon.TabIndex = 7;
			this.lblToplamRezervasyon.Text = "_";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(46, 754);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(247, 24);
			this.label1.TabIndex = 8;
			this.label1.Text = "Toplam Rezervasyon Sayısı : ";
			// 
			// AdminRezervasyonYonetimi
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(780, 870);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblToplamRezervasyon);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblBaslik);
			this.Controls.Add(this.txtAra);
			this.Controls.Add(this.btnAra);
			this.Controls.Add(this.dgvRezervasyonlar);
			this.Controls.Add(this.btnDetaylar);
			this.Controls.Add(this.btnIptalEt);
			this.Name = "AdminRezervasyonYonetimi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rezervasyon Yönetimi";
			((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private PictureBox pictureBox1;
		private Label lblToplamRezervasyon;
		private Label label1;
	}
}
