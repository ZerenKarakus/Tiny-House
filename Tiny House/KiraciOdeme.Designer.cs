namespace TinyHouseProjesi
{
	partial class KiraciOdeme
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
			this.dgvOdeme = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.rezervasyonDetayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rezervasyonDetayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.btnGeri = new System.Windows.Forms.Button();
			this.btnCikis = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvOdeme)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvOdeme
			// 
			this.dgvOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOdeme.Location = new System.Drawing.Point(144, 246);
			this.dgvOdeme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvOdeme.Name = "dgvOdeme";
			this.dgvOdeme.RowHeadersWidth = 62;
			this.dgvOdeme.RowTemplate.Height = 28;
			this.dgvOdeme.Size = new System.Drawing.Size(662, 205);
			this.dgvOdeme.TabIndex = 0;
			this.dgvOdeme.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOdeme_CellMouseClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.label1.Location = new System.Drawing.Point(144, 202);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "ÖDEMESİ YAPILMAMIŞ REZERVASYONLAR :\r\n";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(144, 168);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(508, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "ÖDEME YAPMA VEYA REZERVASYON DETAYINA SAĞ TIK İLE ULAŞABİLİRSİNİZ\r\n";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.rezervasyonDetayToolStripMenuItem,
			this.rezervasyonDetayToolStripMenuItem1});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(204, 52);
			// 
			// rezervasyonDetayToolStripMenuItem
			// 
			this.rezervasyonDetayToolStripMenuItem.Name = "rezervasyonDetayToolStripMenuItem";
			this.rezervasyonDetayToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
			this.rezervasyonDetayToolStripMenuItem.Text = "Ödeme Yap";
			this.rezervasyonDetayToolStripMenuItem.Click += new System.EventHandler(this.rezervasyonDetayToolStripMenuItem_Click);
			// 
			// rezervasyonDetayToolStripMenuItem1
			// 
			this.rezervasyonDetayToolStripMenuItem1.Name = "rezervasyonDetayToolStripMenuItem1";
			this.rezervasyonDetayToolStripMenuItem1.Size = new System.Drawing.Size(203, 24);
			this.rezervasyonDetayToolStripMenuItem1.Text = "Rezervasyon Detay";
			this.rezervasyonDetayToolStripMenuItem1.Click += new System.EventHandler(this.rezervasyonDetayToolStripMenuItem1_Click);
			// 
			// btnGeri
			// 
			this.btnGeri.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGeri.Location = new System.Drawing.Point(34, 31);
			this.btnGeri.Name = "btnGeri";
			this.btnGeri.Size = new System.Drawing.Size(30, 35);
			this.btnGeri.TabIndex = 3;
			this.btnGeri.Text = "-";
			this.btnGeri.UseVisualStyleBackColor = true;
			this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
			// 
			// btnCikis
			// 
			this.btnCikis.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCikis.Location = new System.Drawing.Point(896, 31);
			this.btnCikis.Name = "btnCikis";
			this.btnCikis.Size = new System.Drawing.Size(30, 35);
			this.btnCikis.TabIndex = 4;
			this.btnCikis.Text = "x";
			this.btnCikis.UseVisualStyleBackColor = true;
			this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
			// 
			// KiraciOdeme
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(958, 675);
			this.Controls.Add(this.btnCikis);
			this.Controls.Add(this.btnGeri);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvOdeme);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "KiraciOdeme";
			this.Text = "Odeme";
			((System.ComponentModel.ISupportInitialize)(this.dgvOdeme)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvOdeme;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem rezervasyonDetayToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rezervasyonDetayToolStripMenuItem1;
		private System.Windows.Forms.Button btnGeri;
		private System.Windows.Forms.Button btnCikis;
	}
}