using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
	public partial class AdminOdemeYonetimi : Form
	{
		public AdminOdemeYonetimi()
		{
			InitializeComponent();
		}

		private void AdminOdemeYonetimi_Load(object sender, EventArgs e)
		{
			dtBaslangic.Value = DateTime.Now.AddMonths(-1);
			dtBitis.Value = DateTime.Now;
			OdemeVerileriniYukle();
		}

		private void OdemeVerileriniYukle()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection("Server=LAPTOP-QCSD0KI9\\ZEREN ;Database=tinyHouse;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
				{
					conn.Open();
					string query = @"
                        SELECT 
                            OdemeID,
                            RezervasyonID,
                            Tutar,
                            OdemeTarihi
                        FROM Odemeler
                        ORDER BY OdemeTarihi DESC";

					SqlDataAdapter da = new SqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);
					dataGridView1.DataSource = dt;
					ToplamGeliriHesapla(); // Fonksiyonla toplam gelir hesaplama
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message);
			}
		}

		private void btnFiltrele_Click(object sender, EventArgs e)
		{
			DateTime baslangic = dtBaslangic.Value.Date;
			DateTime bitis = dtBitis.Value.Date.AddDays(1);

			string query = @"
                SELECT 
                    OdemeID,
                    RezervasyonID,
                    Tutar,
                    OdemeTarihi
                FROM Odemeler
                WHERE OdemeTarihi BETWEEN @Baslangic AND @Bitis
                ORDER BY OdemeTarihi DESC";

			try
			{
				using (SqlConnection conn = new SqlConnection("Server=LAPTOP-QCSD0KI9\\ZEREN ;Database=tinyHouse;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@Baslangic", baslangic);
					cmd.Parameters.AddWithValue("@Bitis", bitis);

					SqlDataAdapter da = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					da.Fill(dt);
					dataGridView1.DataSource = dt;

					ToplamGeliriHesapla(); // Fonksiyonla toplam geliri hesapla
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Filtreleme sırasında hata oluştu: " + ex.Message);
			}
		}

		private void btnYenile_Click(object sender, EventArgs e)
		{
			dtBaslangic.Value = DateTime.Now.AddMonths(-1);
			dtBitis.Value = DateTime.Now;
			OdemeVerileriniYukle();
		}

		// SQL Fonksiyonunu kullanarak toplam gelir hesaplama
		private void ToplamGeliriHesapla()
		{
			DateTime baslangic = dtBaslangic.Value.Date;
			DateTime bitis = dtBitis.Value.Date.AddDays(1);

			try
			{
				using (SqlConnection conn = new SqlConnection("Server=LAPTOP-QCSD0KI9\\ZEREN ;Database=tinyHouse;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
				{
					conn.Open();

					SqlCommand cmd = new SqlCommand("SELECT dbo.fn_ToplamGelir(@Baslangic, @Bitis)", conn);
					cmd.Parameters.AddWithValue("@Baslangic", baslangic);
					cmd.Parameters.AddWithValue("@Bitis", bitis);

					object sonuc = cmd.ExecuteScalar();
					if (sonuc != null)
					{
						decimal toplam = Convert.ToDecimal(sonuc);
						lblToplamGelir.Text = "Toplam Gelir: ₺" + toplam.ToString("N2");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Toplam gelir hesaplanırken hata oluştu: " + ex.Message);
			}
		}
	}
}
