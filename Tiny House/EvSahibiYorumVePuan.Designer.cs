namespace TinyHouseProjesi
{
	partial class EvSahibiYorumVePuan
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
			this.dgvYorumlar = new System.Windows.Forms.DataGridView();
			this.cmbPuanFiltre = new System.Windows.Forms.ComboBox();
			this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
			this.dtpBitis = new System.Windows.Forms.DateTimePicker();
			this.btnFiltrele = new System.Windows.Forms.Button();
			this.btnTumunuGoster = new System.Windows.Forms.Button();
			this.lblOrtalamaPuan = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvYorumlar)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvYorumlar
			// 
			this.dgvYorumlar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvYorumlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvYorumlar.Location = new System.Drawing.Point(117, 81);
			this.dgvYorumlar.Name = "dgvYorumlar";
			this.dgvYorumlar.RowHeadersWidth = 51;
			this.dgvYorumlar.RowTemplate.Height = 24;
			this.dgvYorumlar.Size = new System.Drawing.Size(841, 233);
			this.dgvYorumlar.TabIndex = 0;
			// 
			// cmbPuanFiltre
			// 
			this.cmbPuanFiltre.FormattingEnabled = true;
			this.cmbPuanFiltre.Location = new System.Drawing.Point(239, 448);
			this.cmbPuanFiltre.Name = "cmbPuanFiltre";
			this.cmbPuanFiltre.Size = new System.Drawing.Size(153, 24);
			this.cmbPuanFiltre.TabIndex = 1;
			// 
			// dtpBaslangic
			// 
			this.dtpBaslangic.Location = new System.Drawing.Point(768, 446);
			this.dtpBaslangic.Name = "dtpBaslangic";
			this.dtpBaslangic.Size = new System.Drawing.Size(200, 22);
			this.dtpBaslangic.TabIndex = 2;
			// 
			// dtpBitis
			// 
			this.dtpBitis.Location = new System.Drawing.Point(768, 559);
			this.dtpBitis.Name = "dtpBitis";
			this.dtpBitis.Size = new System.Drawing.Size(200, 22);
			this.dtpBitis.TabIndex = 3;
			// 
			// btnFiltrele
			// 
			this.btnFiltrele.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnFiltrele.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnFiltrele.ForeColor = System.Drawing.Color.Maroon;
			this.btnFiltrele.Location = new System.Drawing.Point(170, 703);
			this.btnFiltrele.Name = "btnFiltrele";
			this.btnFiltrele.Size = new System.Drawing.Size(179, 63);
			this.btnFiltrele.TabIndex = 4;
			this.btnFiltrele.Text = "Filtrele";
			this.btnFiltrele.UseVisualStyleBackColor = false;
			this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
			// 
			// btnTumunuGoster
			// 
			this.btnTumunuGoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnTumunuGoster.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnTumunuGoster.ForeColor = System.Drawing.Color.Maroon;
			this.btnTumunuGoster.Location = new System.Drawing.Point(749, 703);
			this.btnTumunuGoster.Name = "btnTumunuGoster";
			this.btnTumunuGoster.Size = new System.Drawing.Size(179, 63);
			this.btnTumunuGoster.TabIndex = 5;
			this.btnTumunuGoster.Text = "Tümünü Göster";
			this.btnTumunuGoster.UseVisualStyleBackColor = false;
			this.btnTumunuGoster.Click += new System.EventHandler(this.btnTumunuGoster_Click);
			// 
			// lblOrtalamaPuan
			// 
			this.lblOrtalamaPuan.AutoSize = true;
			this.lblOrtalamaPuan.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblOrtalamaPuan.Location = new System.Drawing.Point(79, 561);
			this.lblOrtalamaPuan.Name = "lblOrtalamaPuan";
			this.lblOrtalamaPuan.Size = new System.Drawing.Size(128, 21);
			this.lblOrtalamaPuan.TabIndex = 6;
			this.lblOrtalamaPuan.Text = "Ortalama Puan : ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(79, 451);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 21);
			this.label1.TabIndex = 7;
			this.label1.Text = "Puan Filtresi : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(601, 448);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 21);
			this.label2.TabIndex = 8;
			this.label2.Text = "Başlangıç Tarihi : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(601, 561);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 21);
			this.label3.TabIndex = 9;
			this.label3.Text = "Bitiş Tarihi : ";
			// 
			// EvSahibiYorumVePuan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1082, 853);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblOrtalamaPuan);
			this.Controls.Add(this.btnTumunuGoster);
			this.Controls.Add(this.btnFiltrele);
			this.Controls.Add(this.dtpBitis);
			this.Controls.Add(this.dtpBaslangic);
			this.Controls.Add(this.cmbPuanFiltre);
			this.Controls.Add(this.dgvYorumlar);
			this.Name = "EvSahibiYorumVePuan";
			this.Text = "Yorumlar ve Puanlar";
			this.Load += new System.EventHandler(this.EvSahibiYorumVePuan_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvYorumlar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvYorumlar;
		private System.Windows.Forms.ComboBox cmbPuanFiltre;
		private System.Windows.Forms.DateTimePicker dtpBaslangic;
		private System.Windows.Forms.DateTimePicker dtpBitis;
		private System.Windows.Forms.Button btnFiltrele;
		private System.Windows.Forms.Button btnTumunuGoster;
		private System.Windows.Forms.Label lblOrtalamaPuan;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}