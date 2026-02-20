namespace TinyHouseProjesi
{
	partial class KiraciAnaSayfa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiraciAnaSayfa));
			this.txtArama = new System.Windows.Forms.TextBox();
			this.cmbEvTipi = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbIl = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMaxFiyat = new System.Windows.Forms.TextBox();
			this.txtMinFiyat = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbKapasite = new System.Windows.Forms.ComboBox();
			this.btnAra = new System.Windows.Forms.Button();
			this.dataGridViewEvListele = new System.Windows.Forms.DataGridView();
			this.btnOdeme = new System.Windows.Forms.Button();
			this.btnRezervasyon = new System.Windows.Forms.Button();
			this.dgvEnYuksekPuan = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvListele)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEnYuksekPuan)).BeginInit();
			this.SuspendLayout();
			// 
			// txtArama
			// 
			this.txtArama.Location = new System.Drawing.Point(655, 70);
			this.txtArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtArama.Name = "txtArama";
			this.txtArama.Size = new System.Drawing.Size(174, 22);
			this.txtArama.TabIndex = 0;
			// 
			// cmbEvTipi
			// 
			this.cmbEvTipi.FormattingEnabled = true;
			this.cmbEvTipi.Items.AddRange(new object[] {
            "Apartman Dairesi",
            "Dubleks",
            "Müstakil"});
			this.cmbEvTipi.Location = new System.Drawing.Point(655, 111);
			this.cmbEvTipi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbEvTipi.Name = "cmbEvTipi";
			this.cmbEvTipi.Size = new System.Drawing.Size(174, 24);
			this.cmbEvTipi.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.label1.Location = new System.Drawing.Point(552, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "EV TİPİ :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.label2.Location = new System.Drawing.Point(552, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "ARAMA :";
			// 
			// cmbIl
			// 
			this.cmbIl.FormattingEnabled = true;
			this.cmbIl.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir",
            "Manisa",
            "Çorum",
            "Aksaray",
            "Kocaeli",
            "Rize",
            "Eskişehir"});
			this.cmbIl.Location = new System.Drawing.Point(655, 154);
			this.cmbIl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbIl.Name = "cmbIl";
			this.cmbIl.Size = new System.Drawing.Size(174, 24);
			this.cmbIl.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(552, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "İL :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.label4.Location = new System.Drawing.Point(552, 198);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "GÜNLÜK FİYAT ";
			// 
			// txtMaxFiyat
			// 
			this.txtMaxFiyat.Location = new System.Drawing.Point(655, 229);
			this.txtMaxFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMaxFiyat.Name = "txtMaxFiyat";
			this.txtMaxFiyat.Size = new System.Drawing.Size(89, 22);
			this.txtMaxFiyat.TabIndex = 7;
			// 
			// txtMinFiyat
			// 
			this.txtMinFiyat.Location = new System.Drawing.Point(655, 261);
			this.txtMinFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMinFiyat.Name = "txtMinFiyat";
			this.txtMinFiyat.Size = new System.Drawing.Size(89, 22);
			this.txtMinFiyat.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(552, 231);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "EN FAZLA :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(552, 263);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 20);
			this.label6.TabIndex = 10;
			this.label6.Text = "EN AZ :";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(45, 32);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(133, 120);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.label8.Location = new System.Drawing.Point(552, 303);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 20);
			this.label8.TabIndex = 13;
			this.label8.Text = "KAPASİTE :";
			// 
			// cmbKapasite
			// 
			this.cmbKapasite.FormattingEnabled = true;
			this.cmbKapasite.Items.AddRange(new object[] {
            "Studio",
            "1+1",
            "2+1",
            "3+1",
            "4+1"});
			this.cmbKapasite.Location = new System.Drawing.Point(655, 299);
			this.cmbKapasite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbKapasite.Name = "cmbKapasite";
			this.cmbKapasite.Size = new System.Drawing.Size(174, 24);
			this.cmbKapasite.TabIndex = 14;
			// 
			// btnAra
			// 
			this.btnAra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnAra.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.btnAra.Location = new System.Drawing.Point(556, 346);
			this.btnAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAra.Name = "btnAra";
			this.btnAra.Size = new System.Drawing.Size(273, 36);
			this.btnAra.TabIndex = 15;
			this.btnAra.Text = "ARA";
			this.btnAra.UseVisualStyleBackColor = false;
			this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
			// 
			// dataGridViewEvListele
			// 
			this.dataGridViewEvListele.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.dataGridViewEvListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEvListele.Location = new System.Drawing.Point(54, 421);
			this.dataGridViewEvListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridViewEvListele.Name = "dataGridViewEvListele";
			this.dataGridViewEvListele.RowHeadersWidth = 62;
			this.dataGridViewEvListele.RowTemplate.Height = 28;
			this.dataGridViewEvListele.Size = new System.Drawing.Size(860, 212);
			this.dataGridViewEvListele.TabIndex = 16;
			this.dataGridViewEvListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEvListele_CellContentClick);
			// 
			// btnOdeme
			// 
			this.btnOdeme.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnOdeme.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.btnOdeme.Location = new System.Drawing.Point(268, 104);
			this.btnOdeme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnOdeme.Name = "btnOdeme";
			this.btnOdeme.Size = new System.Drawing.Size(151, 36);
			this.btnOdeme.TabIndex = 17;
			this.btnOdeme.Text = "ÖDEME";
			this.btnOdeme.UseVisualStyleBackColor = false;
			this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
			// 
			// btnRezervasyon
			// 
			this.btnRezervasyon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnRezervasyon.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.btnRezervasyon.Location = new System.Drawing.Point(238, 54);
			this.btnRezervasyon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRezervasyon.Name = "btnRezervasyon";
			this.btnRezervasyon.Size = new System.Drawing.Size(203, 37);
			this.btnRezervasyon.TabIndex = 18;
			this.btnRezervasyon.Text = "REZERVASYONLARIM";
			this.btnRezervasyon.UseVisualStyleBackColor = false;
			this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
			// 
			// dgvEnYuksekPuan
			// 
			this.dgvEnYuksekPuan.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dgvEnYuksekPuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEnYuksekPuan.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvEnYuksekPuan.Location = new System.Drawing.Point(45, 211);
			this.dgvEnYuksekPuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvEnYuksekPuan.Name = "dgvEnYuksekPuan";
			this.dgvEnYuksekPuan.RowHeadersWidth = 62;
			this.dgvEnYuksekPuan.RowTemplate.Height = 28;
			this.dgvEnYuksekPuan.Size = new System.Drawing.Size(453, 170);
			this.dgvEnYuksekPuan.TabIndex = 19;
			this.dgvEnYuksekPuan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnYuksekPuan_CellContentClick);
			// 
			// KiraciAnaSayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(958, 675);
			this.Controls.Add(this.dgvEnYuksekPuan);
			this.Controls.Add(this.btnRezervasyon);
			this.Controls.Add(this.btnOdeme);
			this.Controls.Add(this.dataGridViewEvListele);
			this.Controls.Add(this.btnAra);
			this.Controls.Add(this.cmbKapasite);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtMinFiyat);
			this.Controls.Add(this.txtMaxFiyat);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbIl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbEvTipi);
			this.Controls.Add(this.txtArama);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "KiraciAnaSayfa";
			this.Text = "Kiraci";
			this.Load += new System.EventHandler(this.KiraciAnaSayfa_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvListele)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEnYuksekPuan)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtArama;
		private System.Windows.Forms.ComboBox cmbEvTipi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbIl;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtMaxFiyat;
		private System.Windows.Forms.TextBox txtMinFiyat;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbKapasite;
		private System.Windows.Forms.Button btnAra;
		private System.Windows.Forms.DataGridView dataGridViewEvListele;
		private System.Windows.Forms.Button btnOdeme;
		private System.Windows.Forms.Button btnRezervasyon;
		private System.Windows.Forms.DataGridView dgvEnYuksekPuan;
	}
}