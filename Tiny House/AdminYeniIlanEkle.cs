using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHouseProjesi;

namespace TinyHouseProjesi
{
	public partial class AdminYeniIlanEkle : Form
	{
		public AdminYeniIlanEkle()
		{
			InitializeComponent();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				string baslik = txtBaslik.Text.Trim();
				string aciklama = txtAciklama.Text.Trim();
				string ucretText = txtUcret.Text.Trim();
				string konum = txtKonum.Text.Trim();
				string durum = cmbDurum.SelectedItem?.ToString();

				if (string.IsNullOrWhiteSpace(baslik) || string.IsNullOrWhiteSpace(ucretText) || string.IsNullOrWhiteSpace(konum) || string.IsNullOrWhiteSpace(durum))
				{
					MessageBox.Show("Lütfen tüm zorunlu alanları doldurun.");
					return;
				}

				if (!decimal.TryParse(ucretText, out decimal ucret))
				{
					MessageBox.Show("Lütfen geçerli bir ücret giriniz.");
					return;
				}

				int sahipID = 12; 

				string sorgu = @"
					INSERT INTO Ilanlar (EvSahibiID, Baslik, Aciklama, Fiyat, Konum, Durum)
					VALUES (@EvSahibiID, @Baslik, @Aciklama, @Fiyat, @Konum, @Durum)";

				SqlParameter[] parametreler = new SqlParameter[]
				{
					new SqlParameter("@EvSahibiID", sahipID),
					new SqlParameter("@Baslik", baslik),
					new SqlParameter("@Aciklama", aciklama),
					new SqlParameter("@Fiyat", ucret),
					new SqlParameter("@Konum", konum),
					new SqlParameter("@Durum", durum)
				};

				VeritabaniYardimci db = new VeritabaniYardimci();
				int sonuc = db.ParametreliKomut(sorgu, parametreler);

				if (sonuc > 0)
				{
					MessageBox.Show("İlan başarıyla eklendi.");
					this.Close();
				}
				else
				{
					MessageBox.Show("İlan eklenemedi.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex.Message);
			}
		}
	}
}
