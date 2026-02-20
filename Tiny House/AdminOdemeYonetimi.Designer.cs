using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
	partial class AdminOdemeYonetimi
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DateTimePicker dtBaslangic;
		private System.Windows.Forms.DateTimePicker dtBitis;
		private System.Windows.Forms.Button btnFiltrele;
		private System.Windows.Forms.Button btnYenile;
		private System.Windows.Forms.Label lblToplamGelir;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
			this.dtBitis = new System.Windows.Forms.DateTimePicker();
			this.btnFiltrele = new System.Windows.Forms.Button();
			this.btnYenile = new System.Windows.Forms.Button();
			this.lblToplamGelir = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.ColumnHeadersHeight = 29;
			this.dataGridView1.Location = new System.Drawing.Point(20, 50);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(740, 370);
			this.dataGridView1.TabIndex = 4;
			// 
			// dtBaslangic
			// 
			this.dtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtBaslangic.Location = new System.Drawing.Point(20, 15);
			this.dtBaslangic.Name = "dtBaslangic";
			this.dtBaslangic.Size = new System.Drawing.Size(120, 22);
			this.dtBaslangic.TabIndex = 0;
			// 
			// dtBitis
			// 
			this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtBitis.Location = new System.Drawing.Point(150, 15);
			this.dtBitis.Name = "dtBitis";
			this.dtBitis.Size = new System.Drawing.Size(120, 22);
			this.dtBitis.TabIndex = 1;
			// 
			// btnFiltrele
			// 
			this.btnFiltrele.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnFiltrele.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnFiltrele.Location = new System.Drawing.Point(280, 12);
			this.btnFiltrele.Name = "btnFiltrele";
			this.btnFiltrele.Size = new System.Drawing.Size(75, 27);
			this.btnFiltrele.TabIndex = 2;
			this.btnFiltrele.Text = "Filtrele";
			this.btnFiltrele.UseVisualStyleBackColor = false;
			this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
			// 
			// btnYenile
			// 
			this.btnYenile.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnYenile.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnYenile.Location = new System.Drawing.Point(365, 12);
			this.btnYenile.Name = "btnYenile";
			this.btnYenile.Size = new System.Drawing.Size(75, 27);
			this.btnYenile.TabIndex = 3;
			this.btnYenile.Text = "Yenile";
			this.btnYenile.UseVisualStyleBackColor = false;
			this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
			// 
			// lblToplamGelir
			// 
			this.lblToplamGelir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lblToplamGelir.Location = new System.Drawing.Point(20, 430);
			this.lblToplamGelir.Name = "lblToplamGelir";
			this.lblToplamGelir.Size = new System.Drawing.Size(400, 30);
			this.lblToplamGelir.TabIndex = 5;
			this.lblToplamGelir.Text = "Toplam Gelir: ₺0";
			// 
			// AdminOdemeYonetimi
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(780, 480);
			this.Controls.Add(this.dtBaslangic);
			this.Controls.Add(this.dtBitis);
			this.Controls.Add(this.btnFiltrele);
			this.Controls.Add(this.btnYenile);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.lblToplamGelir);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AdminOdemeYonetimi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "💰 Ödeme Yönetimi";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
