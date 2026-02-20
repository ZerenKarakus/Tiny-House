namespace TinyHouseProjesi
{
	partial class EvSahibiGiris
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvSahibiGiris));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMailVeyaKullanici = new System.Windows.Forms.TextBox();
			this.txtEvSahibiSifre = new System.Windows.Forms.TextBox();
			this.btnGirisYap = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.btnKayitOl = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.btnGeri = new System.Windows.Forms.Button();
			this.btnCikis = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(379, 94);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(222, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 11F);
			this.label1.Location = new System.Drawing.Point(415, 297);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "EV SAHİBİ GİRİŞİ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
			this.label2.Location = new System.Drawing.Point(310, 340);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "E-MAİL  VEYA";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
			this.label3.Location = new System.Drawing.Point(311, 360);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 21);
			this.label3.TabIndex = 3;
			this.label3.Text = "KULLANICI ADI";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(439, 347);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 25);
			this.label4.TabIndex = 4;
			this.label4.Text = ":";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
			this.label5.Location = new System.Drawing.Point(311, 399);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 21);
			this.label5.TabIndex = 5;
			this.label5.Text = "ŞİFRE :";
			// 
			// txtMailVeyaKullanici
			// 
			this.txtMailVeyaKullanici.Location = new System.Drawing.Point(470, 350);
			this.txtMailVeyaKullanici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMailVeyaKullanici.Name = "txtMailVeyaKullanici";
			this.txtMailVeyaKullanici.Size = new System.Drawing.Size(188, 22);
			this.txtMailVeyaKullanici.TabIndex = 6;
			// 
			// txtEvSahibiSifre
			// 
			this.txtEvSahibiSifre.Location = new System.Drawing.Point(470, 399);
			this.txtEvSahibiSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEvSahibiSifre.Name = "txtEvSahibiSifre";
			this.txtEvSahibiSifre.Size = new System.Drawing.Size(188, 22);
			this.txtEvSahibiSifre.TabIndex = 7;
			// 
			// btnGirisYap
			// 
			this.btnGirisYap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnGirisYap.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.btnGirisYap.Location = new System.Drawing.Point(316, 442);
			this.btnGirisYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGirisYap.Name = "btnGirisYap";
			this.btnGirisYap.Size = new System.Drawing.Size(343, 46);
			this.btnGirisYap.TabIndex = 8;
			this.btnGirisYap.Text = "GİRİŞ YAP";
			this.btnGirisYap.UseVisualStyleBackColor = false;
			this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Sans Serif Collection", 7.999999F, System.Drawing.FontStyle.Bold);
			this.linkLabel1.Location = new System.Drawing.Point(412, 548);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(145, 48);
			this.linkLabel1.TabIndex = 13;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Şifremi Unuttum";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// btnKayitOl
			// 
			this.btnKayitOl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnKayitOl.Font = new System.Drawing.Font("Franklin Gothic Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKayitOl.Location = new System.Drawing.Point(470, 502);
			this.btnKayitOl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnKayitOl.Name = "btnKayitOl";
			this.btnKayitOl.Size = new System.Drawing.Size(188, 33);
			this.btnKayitOl.TabIndex = 12;
			this.btnKayitOl.Text = "KAYIT OL";
			this.btnKayitOl.UseVisualStyleBackColor = false;
			this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(311, 510);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "Hesabın yok mu?";
			// 
			// btnGeri
			// 
			this.btnGeri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGeri.Location = new System.Drawing.Point(40, 30);
			this.btnGeri.Name = "btnGeri";
			this.btnGeri.Size = new System.Drawing.Size(30, 35);
			this.btnGeri.TabIndex = 14;
			this.btnGeri.Text = "-";
			this.btnGeri.UseVisualStyleBackColor = true;
			this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
			// 
			// btnCikis
			// 
			this.btnCikis.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCikis.Location = new System.Drawing.Point(888, 31);
			this.btnCikis.Name = "btnCikis";
			this.btnCikis.Size = new System.Drawing.Size(30, 35);
			this.btnCikis.TabIndex = 15;
			this.btnCikis.Text = "x";
			this.btnCikis.UseVisualStyleBackColor = true;
			this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
			// 
			// EvSahibiGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(958, 675);
			this.Controls.Add(this.btnCikis);
			this.Controls.Add(this.btnGeri);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.btnKayitOl);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnGirisYap);
			this.Controls.Add(this.txtEvSahibiSifre);
			this.Controls.Add(this.txtMailVeyaKullanici);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "EvSahibiGiris";
			this.Text = "Ev Sahibi Giriş Sayfası";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMailVeyaKullanici;
		private System.Windows.Forms.TextBox txtEvSahibiSifre;
		private System.Windows.Forms.Button btnGirisYap;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button btnKayitOl;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnGeri;
		private System.Windows.Forms.Button btnCikis;
	}
};