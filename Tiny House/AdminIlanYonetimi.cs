using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHouseProjesi;

namespace TinyHouseProjesi
{
	public partial class AdminIlanYonetimi : Form
	{
		public AdminIlanYonetimi()
		{
			InitializeComponent();
		}

		private void AdminIlanYonetimi_Load(object sender, EventArgs e)
		{
			IlanlariYukle();
		}

		private void IlanlariYukle(string arama = "")
		{
			try
			{
				VeritabaniYardimci db = new VeritabaniYardimci();
				string sql = @"
                    SELECT 
                        Ilanlar.IlanID,
                        Ilanlar.Baslik,
                        Ilanlar.Konum,
                        Ilanlar.Fiyat,
                        Ilanlar.Durum,
                        K.Ad AS EvSahibiAd, K.Soyad AS EvSahibiSoyad
                    FROM Ilanlar
                    INNER JOIN Kullanicilar K ON Ilanlar.EvSahibiID = K.KullaniciID
                    WHERE Ilanlar.Baslik LIKE @Arama OR Ilanlar.Konum LIKE @Arama";

				SqlParameter[] parametreler = {
					new SqlParameter("@Arama", "%" + arama + "%")
				};

				DataTable dt = db.ParametreliVeriGetir(sql, parametreler);
				dgvIlanlar.DataSource = dt;
				dgvIlanlar.Columns["IlanID"].Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex.Message);
			}
		}

		private void btnAra_Click(object sender, EventArgs e)
		{
			IlanlariYukle(txtAra.Text.Trim());
		}

		private void btnYeniEkle_Click(object sender, EventArgs e)
		{
			AdminYeniIlanEkle frm = new AdminYeniIlanEkle();
			frm.ShowDialog();
			IlanlariYukle();
		}

		private void btnDuzenle_Click(object sender, EventArgs e)
		{
			if (dgvIlanlar.SelectedRows.Count == 0)
			{
				MessageBox.Show("Lütfen bir ilan seçiniz.");
				return;
			}

			int ilanID = Convert.ToInt32(dgvIlanlar.SelectedRows[0].Cells["IlanID"].Value);

			AdminIlanGuncelle frm = new AdminIlanGuncelle(ilanID);
			frm.ShowDialog();
			IlanlariYukle();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (dgvIlanlar.SelectedRows.Count == 0)
			{
				MessageBox.Show("Lütfen silmek istediğiniz ilanı seçin.");
				return;
			}

			int ilanID = Convert.ToInt32(dgvIlanlar.SelectedRows[0].Cells["IlanID"].Value);
			DialogResult onay = MessageBox.Show("Bu ilanı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (onay == DialogResult.Yes)
			{
				try
				{
					VeritabaniYardimci db = new VeritabaniYardimci();
					string sorgu = "DELETE FROM Ilanlar WHERE IlanID = @IlanID";
					SqlParameter[] parametreler = { new SqlParameter("@IlanID", ilanID) };
					int sonuc = db.ParametreliKomut(sorgu, parametreler);

					if (sonuc > 0)
						MessageBox.Show("İlan başarıyla silindi.");
					else
						MessageBox.Show("Silme başarısız.");

					IlanlariYukle();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Hata: " + ex.Message);
				}
			}
		}

		private void btnDurumDegistir_Click(object sender, EventArgs e)
		{
			if (dgvIlanlar.SelectedRows.Count == 0)
			{
				MessageBox.Show("Lütfen durumunu değiştirmek istediğiniz ilanı seçin.");
				return;
			}

			int ilanID = Convert.ToInt32(dgvIlanlar.SelectedRows[0].Cells["IlanID"].Value);
			string mevcutDurum = dgvIlanlar.SelectedRows[0].Cells["Durum"].Value.ToString();
			string yeniDurum = mevcutDurum == "Aktif" ? "Pasif" : "Aktif";

			DialogResult onay = MessageBox.Show($"Bu ilanı '{yeniDurum}' yapmak istiyor musunuz?", "Onay", MessageBoxButtons.YesNo);

			if (onay == DialogResult.Yes)
			{
				try
				{
					VeritabaniYardimci db = new VeritabaniYardimci();
					string sorgu = "UPDATE Ilanlar SET Durum = @Durum WHERE IlanID = @IlanID";
					SqlParameter[] parametreler = {
						new SqlParameter("@Durum", yeniDurum),
						new SqlParameter("@IlanID", ilanID)
					};
					int sonuc = db.ParametreliKomut(sorgu, parametreler);

					if (sonuc > 0)
						MessageBox.Show("Durum güncellendi.");
					else
						MessageBox.Show("Güncelleme başarısız.");

					IlanlariYukle();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Hata: " + ex.Message);
				}
			}
		}
	}
}
