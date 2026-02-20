namespace TinyHouseProjesi
{
	partial class KiraciRezervasyonlari
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
			this.components = new System.ComponentModel.Container();
			this.dgvOnaylanmis = new System.Windows.Forms.DataGridView();
			this.dgvOnayBekleyen = new System.Windows.Forms.DataGridView();
			this.dgvGecmis = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ctxtMenuRezervasyon = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.detayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iPTALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yorumYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label4 = new System.Windows.Forms.Label();
			this.btnGeri = new System.Windows.Forms.Button();
			this.btnCikis = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvOnaylanmis)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvOnayBekleyen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvGecmis)).BeginInit();
			this.ctxtMenuRezervasyon.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvOnaylanmis
			// 
			this.dgvOnaylanmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOnaylanmis.Location = new System.Drawing.Point(44, 101);
			this.dgvOnaylanmis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvOnaylanmis.Name = "dgvOnaylanmis";
			this.dgvOnaylanmis.RowHeadersWidth = 62;
			this.dgvOnaylanmis.RowTemplate.Height = 28;
			this.dgvOnaylanmis.Size = new System.Drawing.Size(895, 142);
			this.dgvOnaylanmis.TabIndex = 0;
			// 
			// dgvOnayBekleyen
			// 
			this.dgvOnayBekleyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOnayBekleyen.Location = new System.Drawing.Point(44, 305);
			this.dgvOnayBekleyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvOnayBekleyen.Name = "dgvOnayBekleyen";
			this.dgvOnayBekleyen.RowHeadersWidth = 62;
			this.dgvOnayBekleyen.RowTemplate.Height = 28;
			this.dgvOnayBekleyen.Size = new System.Drawing.Size(895, 142);
			this.dgvOnayBekleyen.TabIndex = 1;
			this.dgvOnayBekleyen.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOnayBekleyen_CellMouseClick);
			// 
			// dgvGecmis
			// 
			this.dgvGecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGecmis.Location = new System.Drawing.Point(44, 511);
			this.dgvGecmis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvGecmis.Name = "dgvGecmis";
			this.dgvGecmis.RowHeadersWidth = 62;
			this.dgvGecmis.RowTemplate.Height = 28;
			this.dgvGecmis.Size = new System.Drawing.Size(895, 142);
			this.dgvGecmis.TabIndex = 2;
			this.dgvGecmis.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGecmis_CellMouseClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.label1.Location = new System.Drawing.Point(40, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(230, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "ONAYLANMIŞ REZERVASYONLAR :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.label2.Location = new System.Drawing.Point(44, 269);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(250, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "ONAY BEKLEYEN REZERVASYONLAR :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.label3.Location = new System.Drawing.Point(44, 475);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(196, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "GEÇMİŞ REZERVASYONLAR :";
			// 
			// ctxtMenuRezervasyon
			// 
			this.ctxtMenuRezervasyon.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.ctxtMenuRezervasyon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.detayToolStripMenuItem,
			this.iPTALToolStripMenuItem,
			this.yorumYapToolStripMenuItem});
			this.ctxtMenuRezervasyon.Name = "ctxtMenuRezervasyon";
			this.ctxtMenuRezervasyon.Size = new System.Drawing.Size(208, 76);
			// 
			// detayToolStripMenuItem
			// 
			this.detayToolStripMenuItem.Name = "detayToolStripMenuItem";
			this.detayToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
			this.detayToolStripMenuItem.Text = "Rezervasyon Detay";
			this.detayToolStripMenuItem.Click += new System.EventHandler(this.detayToolStripMenuItem_Click);
			// 
			// iPTALToolStripMenuItem
			// 
			this.iPTALToolStripMenuItem.Name = "iPTALToolStripMenuItem";
			this.iPTALToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
			this.iPTALToolStripMenuItem.Text = "Rezervasyon İptal";
			this.iPTALToolStripMenuItem.Click += new System.EventHandler(this.iPTALToolStripMenuItem_Click);
			// 
			// yorumYapToolStripMenuItem
			// 
			this.yorumYapToolStripMenuItem.Name = "yorumYapToolStripMenuItem";
			this.yorumYapToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
			this.yorumYapToolStripMenuItem.Text = "Yorum Ve Puan Ekle";
			this.yorumYapToolStripMenuItem.Click += new System.EventHandler(this.yorumYapToolStripMenuItem_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(40, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(566, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "REZERVASYON İPTALİ, DETAYI YORUM/PUAN EKLEMEYE SAĞ TIK İLE ULAŞABİLİRSİNİZ\r\n";
			// 
			// btnGeri
			// 
			this.btnGeri.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGeri.Location = new System.Drawing.Point(12, 12);
			this.btnGeri.Name = "btnGeri";
			this.btnGeri.Size = new System.Drawing.Size(30, 35);
			this.btnGeri.TabIndex = 8;
			this.btnGeri.Text = "-";
			this.btnGeri.UseVisualStyleBackColor = true;
			this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
			// 
			// btnCikis
			// 
			this.btnCikis.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCikis.Location = new System.Drawing.Point(916, 12);
			this.btnCikis.Name = "btnCikis";
			this.btnCikis.Size = new System.Drawing.Size(30, 35);
			this.btnCikis.TabIndex = 9;
			this.btnCikis.Text = "x";
			this.btnCikis.UseVisualStyleBackColor = true;
			this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
			// 
			// KiraciRezervasyonlari
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(958, 675);
			this.Controls.Add(this.btnCikis);
			this.Controls.Add(this.btnGeri);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvGecmis);
			this.Controls.Add(this.dgvOnayBekleyen);
			this.Controls.Add(this.dgvOnaylanmis);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "KiraciRezervasyonlari";
			this.Text = "Rezervasyonlarim";
			((System.ComponentModel.ISupportInitialize)(this.dgvOnaylanmis)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvOnayBekleyen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvGecmis)).EndInit();
			this.ctxtMenuRezervasyon.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvOnaylanmis;
		private System.Windows.Forms.DataGridView dgvOnayBekleyen;
		private System.Windows.Forms.DataGridView dgvGecmis;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ContextMenuStrip ctxtMenuRezervasyon;
		private System.Windows.Forms.ToolStripMenuItem detayToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem iPTALToolStripMenuItem;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolStripMenuItem yorumYapToolStripMenuItem;
		private System.Windows.Forms.Button btnGeri;
		private System.Windows.Forms.Button btnCikis;
	}
}