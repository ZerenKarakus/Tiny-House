using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHouseProjesi;

namespace TinyHouseProjesi
{
	public partial class AdminRezervasyonYonetimi : Form
	{
		public AdminRezervasyonYonetimi()
		{
			InitializeComponent();
			this.Load += AdminRezervasyonYonetimi_Load;
		}

		private void AdminRezervasyonYonetimi_Load(object sender, EventArgs e)
		{
			try
			{
				VeritabaniYardimci db = new VeritabaniYardimci();
				string sql = @"
				SELECT 
					R.RezervasyonID,
					K.Ad + ' ' + K.Soyad AS Kiraci,
					I.Baslik AS Ilan,
					R.BaslangicTarihi,
					R.BitisTarihi,
					R.Durum,
					R.OdemeDurumu
				FROM Rezervasyonlar R
				INNER JOIN Kullanicilar K ON R.KiraciID = K.KullaniciID
				INNER JOIN Ilanlar I ON R.IlanID = I.IlanID";

				DataTable dt = db.VeriGetir(sql);
				dgvRezervasyonlar.DataSource = dt;
				dgvRezervasyonlar.Columns["RezervasyonID"].Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu: " + ex.Message);
			}
			GuncelToplamRezervasyonSayisi();

		}

		private void btnDetaylar_Click(object sender, EventArgs e)
		{
			if (dgvRezervasyonlar.SelectedRows.Count == 0)
			{
				MessageBox.Show("Lütfen bir rezervasyon seçiniz.");
				return;
			}

			int rezervasyonID = Convert.ToInt32(dgvRezervasyonlar.SelectedRows[0].Cells["RezervasyonID"].Value);

			AdminRezervasyonDetay frm = new AdminRezervasyonDetay(rezervasyonID);
			frm.ShowDialog();
		}

		private void btnIptalEt_Click(object sender, EventArgs e)
		{
			if (dgvRezervasyonlar.SelectedRows.Count == 0)
			{
				MessageBox.Show("Lütfen iptal etmek istediğiniz rezervasyonu seçin.");
				return;
			}

			int id = Convert.ToInt32(dgvRezervasyonlar.SelectedRows[0].Cells["RezervasyonID"].Value);

			DialogResult onay = MessageBox.Show("Bu rezervasyonu iptal etmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo);
			if (onay == DialogResult.Yes)
			{
				try
				{
					VeritabaniYardimci db = new VeritabaniYardimci();
					string sorgu = "UPDATE Rezervasyonlar SET Durum = @Durum WHERE RezervasyonID = @RezervasyonID";

					SqlParameter[] parametreler = {
						new SqlParameter("@Durum", "Iptal"),
						new SqlParameter("@RezervasyonID", id)
					};

					int sonuc = db.ParametreliKomut(sorgu, parametreler);

					if (sonuc > 0)
					{
						MessageBox.Show("Rezervasyon iptal edildi.");
						AdminRezervasyonYonetimi_Load(null, null); // Yeniden yükle
					}
					else
					{
						MessageBox.Show("İptal işlemi başarısız oldu.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("İptal sırasında hata oluştu: " + ex.Message);
				}
			}
		}

		private void btnAra_Click(object sender, EventArgs e)
		{
			string filtre = txtAra.Text.Trim();
			if (filtre == "")
			{
				AdminRezervasyonYonetimi_Load(null, null);
				return;
			}

			try
			{
				VeritabaniYardimci db = new VeritabaniYardimci();
				string sql = @"
				SELECT 
					R.RezervasyonID,
					K.Ad + ' ' + K.Soyad AS Kiraci,
					I.Baslik AS Ilan,
					R.BaslangicTarihi,
					R.BitisTarihi,
					R.Durum,
					R.OdemeDurumu
				FROM Rezervasyonlar R
				INNER JOIN Kullanicilar K ON R.KiraciID = K.KullaniciID
				INNER JOIN Ilanlar I ON R.IlanID = I.IlanID
				WHERE K.Ad + ' ' + K.Soyad LIKE @filtre
				   OR I.Baslik LIKE @filtre";

				SqlParameter[] parametreler = {
					new SqlParameter("@filtre", "%" + filtre + "%")
				};

				DataTable dt = db.ParametreliVeriGetir(sql, parametreler);
				dgvRezervasyonlar.DataSource = dt;
				dgvRezervasyonlar.Columns["RezervasyonID"].Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Arama sırasında hata oluştu: " + ex.Message);
			}
		}

		//  SQL Fonksiyonunu kullanarak toplam rezervasyon sayısı
		private void GuncelToplamRezervasyonSayisi()
		{
			try
			{
				string connectionString = "Server=LAPTOP-QCSD0KI9\\ZEREN;Database=tinyHouse;Trusted_Connection=True;";
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					SqlCommand cmd = new SqlCommand("SELECT dbo.fn_ToplamRezervasyonSayisi()", conn);
					object sonuc = cmd.ExecuteScalar();

					if (sonuc != null && sonuc != DBNull.Value)
					{
						int toplam = Convert.ToInt32(sonuc);
						lblToplamRezervasyon.Text = $"{toplam}";
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Toplam rezervasyon sayısı alınırken hata oluştu: " + ex.Message);
			}
		}
	}
}
