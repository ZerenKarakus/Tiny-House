namespace TinyHouseProjesi
{
	partial class SifremiUnuttum
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.btnGonder = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.rbAdmin = new System.Windows.Forms.RadioButton();
			this.rbEvSahibi = new System.Windows.Forms.RadioButton();
			this.rbKiraci = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(382, 86);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(222, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 11F);
			this.label1.ForeColor = System.Drawing.Color.DarkBlue;
			this.label1.Location = new System.Drawing.Point(349, 378);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "MESAJ GÖNDERİLECEK E-MAİL :\r\n";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(325, 413);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(337, 22);
			this.txtEmail.TabIndex = 3;
			// 
			// btnGonder
			// 
			this.btnGonder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnGonder.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.btnGonder.Location = new System.Drawing.Point(325, 447);
			this.btnGonder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGonder.Name = "btnGonder";
			this.btnGonder.Size = new System.Drawing.Size(336, 34);
			this.btnGonder.TabIndex = 4;
			this.btnGonder.Text = "GÖNDER";
			this.btnGonder.UseVisualStyleBackColor = false;
			this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 11F);
			this.label2.ForeColor = System.Drawing.Color.DarkBlue;
			this.label2.Location = new System.Drawing.Point(324, 289);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(330, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "MESAJ GÖNDERİLECEK E-MAİL TÜRÜ :";
			// 
			// rbAdmin
			// 
			this.rbAdmin.AutoSize = true;
			this.rbAdmin.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.rbAdmin.Location = new System.Drawing.Point(324, 326);
			this.rbAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbAdmin.Name = "rbAdmin";
			this.rbAdmin.Size = new System.Drawing.Size(74, 24);
			this.rbAdmin.TabIndex = 6;
			this.rbAdmin.TabStop = true;
			this.rbAdmin.Text = "ADMİN";
			this.rbAdmin.UseVisualStyleBackColor = true;
			// 
			// rbEvSahibi
			// 
			this.rbEvSahibi.AutoSize = true;
			this.rbEvSahibi.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.rbEvSahibi.Location = new System.Drawing.Point(443, 326);
			this.rbEvSahibi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbEvSahibi.Name = "rbEvSahibi";
			this.rbEvSahibi.Size = new System.Drawing.Size(95, 24);
			this.rbEvSahibi.TabIndex = 7;
			this.rbEvSahibi.TabStop = true;
			this.rbEvSahibi.Text = "EV SAHİBİ";
			this.rbEvSahibi.UseVisualStyleBackColor = true;
			// 
			// rbKiraci
			// 
			this.rbKiraci.AutoSize = true;
			this.rbKiraci.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.rbKiraci.Location = new System.Drawing.Point(582, 326);
			this.rbKiraci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbKiraci.Name = "rbKiraci";
			this.rbKiraci.Size = new System.Drawing.Size(75, 24);
			this.rbKiraci.TabIndex = 8;
			this.rbKiraci.TabStop = true;
			this.rbKiraci.Text = "KİRACI";
			this.rbKiraci.UseVisualStyleBackColor = true;
			// 
			// SifremiUnuttum
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(958, 675);
			this.Controls.Add(this.rbKiraci);
			this.Controls.Add(this.rbEvSahibi);
			this.Controls.Add(this.rbAdmin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnGonder);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "SifremiUnuttum";
			this.Text = "SifremiUnuttum";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Button btnGonder;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rbAdmin;
		private System.Windows.Forms.RadioButton rbEvSahibi;
		private System.Windows.Forms.RadioButton rbKiraci;
	}
}