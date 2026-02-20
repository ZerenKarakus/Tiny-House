using System;
using System.Data;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
	public partial class AdminIstatistikRapor : Form
	{
		public AdminIstatistikRapor()
		{
			InitializeComponent();
			this.Load += AdminIstatistikRapor_Load;
		}

		private void AdminIstatistikRapor_Load(object sender, EventArgs e)
		{
			try
			{
				VeritabaniYardimci db = new VeritabaniYardimci();

				// Kullanıcı sayısı
				var dtKullanici = db.VeriGetir("SELECT COUNT(*) AS Say FROM Kullanicilar");
				lblKullaniciSayisi.Text = $"{dtKullanici.Rows[0]["Say"]}";

				// Toplam ilan
				var dtIlan = db.VeriGetir("SELECT COUNT(*) AS Say FROM Ilanlar");
				lblIlanSayisi.Text = $"{dtIlan.Rows[0]["Say"]}";

				// Rezervasyon sayısı
				var dtRez = db.VeriGetir("SELECT COUNT(*) AS Say FROM Rezervasyonlar");
				lblRezervasyonSayisi.Text = $"{dtRez.Rows[0]["Say"]}";

				// Ödeme sayısı
				var dtOdeme = db.VeriGetir("SELECT COUNT(*) AS Say FROM Odemeler");
				lblOdemeSayisi.Text = $"{dtOdeme.Rows[0]["Say"]}";

				// Toplam gelir
				var gelirDt = db.VeriGetir("SELECT SUM(Tutar) AS Toplam FROM Odemeler");
				decimal toplamGelir = gelirDt.Rows[0]["Toplam"] != DBNull.Value
					? Convert.ToDecimal(gelirDt.Rows[0]["Toplam"])
					: 0;
				lblToplamGelir.Text = $"₺{toplamGelir:N2}";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message);
			}
		}


	}
}
