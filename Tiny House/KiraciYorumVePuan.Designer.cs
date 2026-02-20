namespace TinyHouseProjesi
{
	partial class KiraciYorumVePuan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiraciYorumVePuan));
			this.nupPuan = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.rtxtYorum = new System.Windows.Forms.RichTextBox();
			this.btnEkle = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnGeri = new System.Windows.Forms.Button();
			this.btnCikis = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nupPuan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// nupPuan
			// 
			this.nupPuan.Location = new System.Drawing.Point(431, 322);
			this.nupPuan.Name = "nupPuan";
			this.nupPuan.Size = new System.Drawing.Size(333, 25);
			this.nupPuan.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.label1.Location = new System.Drawing.Point(251, 423);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "YORUMUNUZ :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.label2.Location = new System.Drawing.Point(251, 326);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "PUANINIZ :";
			// 
			// rtxtYorum
			// 
			this.rtxtYorum.Location = new System.Drawing.Point(431, 423);
			this.rtxtYorum.Name = "rtxtYorum";
			this.rtxtYorum.Size = new System.Drawing.Size(333, 159);
			this.rtxtYorum.TabIndex = 5;
			this.rtxtYorum.Text = "";
			// 
			// btnEkle
			// 
			this.btnEkle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnEkle.Location = new System.Drawing.Point(255, 629);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(509, 62);
			this.btnEkle.TabIndex = 6;
			this.btnEkle.Text = "YORUM VE PUAN EKLE";
			this.btnEkle.UseVisualStyleBackColor = false;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(413, 91);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(180, 180);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// btnGeri
			// 
			this.btnGeri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGeri.Location = new System.Drawing.Point(36, 31);
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
			this.btnCikis.Location = new System.Drawing.Point(1004, 32);
			this.btnCikis.Name = "btnCikis";
			this.btnCikis.Size = new System.Drawing.Size(30, 35);
			this.btnCikis.TabIndex = 9;
			this.btnCikis.Text = "x";
			this.btnCikis.UseVisualStyleBackColor = true;
			this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
			// 
			// KiraciYorumVePuan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1078, 844);
			this.Controls.Add(this.btnCikis);
			this.Controls.Add(this.btnGeri);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.rtxtYorum);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nupPuan);
			this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.Name = "KiraciYorumVePuan";
			this.Text = "YorumVePuan";
			((System.ComponentModel.ISupportInitialize)(this.nupPuan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.NumericUpDown nupPuan;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox rtxtYorum;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnGeri;
		private System.Windows.Forms.Button btnCikis;
	}
}