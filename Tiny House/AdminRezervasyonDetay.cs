using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
	public partial class AdminRezervasyonDetay : Form
	{
		private int rezervasyonID;

		public AdminRezervasyonDetay(int rezervasyonID)
		{
			InitializeComponent();
			this.rezervasyonID = rezervasyonID;
			RezervasyonBilgileriniYukle();
		}

		private void RezervasyonBilgileriniYukle()
		{
			string connectionString = "Server=LAPTOP-QCSD0KI9\\ZEREN ;Database=tinyHouse;Trusted_Connection=True;";

			string query = @"
			SELECT 
				CONCAT(k.Ad, ' ', k.Soyad) AS KiraciAdi,
				i.Baslik AS IlanBasligi,
				r.BaslangicTarihi,
				r.BitisTarihi,
				r.Durum,
				r.OdemeDurumu
			FROM Rezervasyonlar r
			INNER JOIN Kullanicilar k ON r.KiraciID = k.KullaniciID
			INNER JOIN Ilanlar i ON r.IlanID = i.IlanID
			WHERE r.RezervasyonID = @RezervasyonID";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@RezervasyonID", rezervasyonID);

				try
				{
					conn.Open();
					SqlDataReader reader = cmd.ExecuteReader();

					if (reader.Read())
					{
						lblKiraci.Text = reader["KiraciAdi"].ToString();
						lblIlan.Text = reader["IlanBasligi"].ToString();
						lblBaslangic.Text = Convert.ToDateTime(reader["BaslangicTarihi"]).ToShortDateString();
						lblBitis.Text = Convert.ToDateTime(reader["BitisTarihi"]).ToShortDateString();
						lblDurum.Text = reader["Durum"].ToString();
						lblOdeme.Text = reader["OdemeDurumu"].ToString();
					}
					else
					{
						MessageBox.Show("Rezervasyon bilgisi bulunamadı.");
						this.Close();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Hata oluştu: " + ex.Message);
				}
			}
		}

	}
}
