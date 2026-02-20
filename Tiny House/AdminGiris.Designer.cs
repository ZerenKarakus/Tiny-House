namespace TinyHouseProjesi
{
	partial class AdminGiris
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGiris));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEMail = new System.Windows.Forms.TextBox();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGirisYap = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.btnGeri = new System.Windows.Forms.Button();
			this.btnCikis = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(374, 95);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(222, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 11F);
			this.label2.Location = new System.Drawing.Point(429, 298);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "ADMİN GİRİŞİ ";
			// 
			// txtEMail
			// 
			this.txtEMail.Location = new System.Drawing.Point(406, 346);
			this.txtEMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEMail.Name = "txtEMail";
			this.txtEMail.Size = new System.Drawing.Size(223, 22);
			this.txtEMail.TabIndex = 3;
			// 
			// txtSifre
			// 
			this.txtSifre.Location = new System.Drawing.Point(406, 400);
			this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(223, 22);
			this.txtSifre.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(329, 346);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 21);
			this.label1.TabIndex = 5;
			this.label1.Text = "E-MAİL :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(329, 400);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 21);
			this.label3.TabIndex = 6;
			this.label3.Text = "ŞİFRE :";
			// 
			// btnGirisYap
			// 
			this.btnGirisYap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnGirisYap.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.btnGirisYap.Location = new System.Drawing.Point(333, 446);
			this.btnGirisYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGirisYap.Name = "btnGirisYap";
			this.btnGirisYap.Size = new System.Drawing.Size(295, 44);
			this.btnGirisYap.TabIndex = 7;
			this.btnGirisYap.Text = "GİRİŞ YAP";
			this.btnGirisYap.UseVisualStyleBackColor = false;
			this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Sans Serif Collection", 7.999999F, System.Drawing.FontStyle.Bold);
			this.linkLabel1.Location = new System.Drawing.Point(426, 493);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(145, 48);
			this.linkLabel1.TabIndex = 10;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Şifremi Unuttum";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// btnGeri
			// 
			this.btnGeri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGeri.Location = new System.Drawing.Point(37, 32);
			this.btnGeri.Name = "btnGeri";
			this.btnGeri.Size = new System.Drawing.Size(30, 35);
			this.btnGeri.TabIndex = 11;
			this.btnGeri.Text = "-";
			this.btnGeri.UseVisualStyleBackColor = true;
			this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
			// 
			// btnCikis
			// 
			this.btnCikis.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCikis.Location = new System.Drawing.Point(891, 33);
			this.btnCikis.Name = "btnCikis";
			this.btnCikis.Size = new System.Drawing.Size(30, 35);
			this.btnCikis.TabIndex = 12;
			this.btnCikis.Text = "x";
			this.btnCikis.UseVisualStyleBackColor = true;
			this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
			// 
			// AdminGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(958, 675);
			this.Controls.Add(this.btnCikis);
			this.Controls.Add(this.btnGeri);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.btnGirisYap);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.txtEMail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "AdminGiris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin Giriş Sayfası";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEMail;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnGirisYap;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button btnGeri;
		private System.Windows.Forms.Button btnCikis;
	}
}