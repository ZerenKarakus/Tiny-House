using System;
using System.Data;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
	public partial class AdminAnaSayfa : Form
	{
		public AdminAnaSayfa()
		{
			InitializeComponent();
			this.Load += AdminAnaSayfaForm_Load; //  Burası eklendi!
		}

		private void AdminAnaSayfaForm_Load(object sender, EventArgs e)
		{
			try
			{
				VeritabaniYardimci db = new VeritabaniYardimci();
				DataTable tablo = db.VeriGetir("SELECT COUNT(*) AS Sayi FROM Kullanicilar");

				int kullaniciSayisi = Convert.ToInt32(tablo.Rows[0]["Sayi"]);
				lblKullaniciSayisi.Text = "Toplam Kullanıcı: " + kullaniciSayisi;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Veritabanı hatası: " + ex.Message);
			}
		}

		private void btnKullaniciYonetimi_Click(object sender, EventArgs e)
		{
			AdminKullaniciYonetimi kullaniciForm = new AdminKullaniciYonetimi();
			kullaniciForm.ShowDialog();
		}

		private void btnIlanYonetimi_Click(object sender, EventArgs e)
		{
			AdminIlanYonetimi ilanForm = new AdminIlanYonetimi();
			ilanForm.ShowDialog();
		}

		private void btnRezervasyonYonetimi_Click(object sender, EventArgs e)
		{
			AdminRezervasyonYonetimi rezervasyonForm = new AdminRezervasyonYonetimi();
			rezervasyonForm.ShowDialog();
		}

		private void btnOdemeYonetimi_Click(object sender, EventArgs e)
		{
			AdminOdemeYonetimi odemeForm = new AdminOdemeYonetimi();
			odemeForm.ShowDialog();
		}

		private void btnIstatistik_Click(object sender, EventArgs e)
		{
			AdminIstatistikRapor istatistikForm = new AdminIstatistikRapor();
			istatistikForm.ShowDialog();
		}
	}
}
