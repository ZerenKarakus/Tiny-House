using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
	public partial class GirisTuruSecme : Form
	{
		public GirisTuruSecme()
		{
			InitializeComponent();
		}

		private void btnEvSahibiGiris_Click(object sender, EventArgs e)
		{
			try
			{
				this.Hide(); // ana formu gizledik

				using (EvSahibiGiris evSahibiGiris = new EvSahibiGiris()) // yeni form olusturduk
					evSahibiGiris.ShowDialog(); // yeni formu actik

				this.Close(); // EvSahibiGiris kapandıktan sonra ana formu geri göster
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!");
			}
		}

		private void btnAdminGiris_Click(object sender, EventArgs e)
		{
			try
			{
				this.Hide();

				using (AdminGiris adminGiris = new AdminGiris())
					adminGiris.ShowDialog();

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!");
			}
		}

		private void btnKirraciGiris_Click(object sender, EventArgs e)
		{
			try
			{
				this.Hide();

				using (KiraciGiris kiraciGiris = new KiraciGiris())
					kiraciGiris.ShowDialog();

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!");
			}
		}
	}
}
