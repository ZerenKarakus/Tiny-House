using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System;
using TinyHouseProjesi;

namespace TinyHouseProjesi
{
	public partial class EvSahibiIlanYonetimi : Form
	{
		SqlConnection baglanti = new SqlConnection("Server=LAPTOP-QCSD0KI9\\ZEREN;Database=tinyHouse;Trusted_Connection=True;");
		int seciliIlanID = -1;
		string seciliResimYolu = "";
		private int EvSahibiID;

		public EvSahibiIlanYonetimi()
		{
			InitializeComponent();
			EvSahibiID = EvSahibiGiris.KullaniciBilgileri.EvSahibiID;
			cmbDurum.Items.AddRange(new string[] { "Aktif", "Pasif" });
			cmbKapasite.Items.AddRange(new string[] { "1+1", "2+1", "3+1", "4+1" }); // kapasite combobox
			IlanlariYukle();
		}

		private void IlanlariYukle()
		{
			SqlDataAdapter da = new SqlDataAdapter("sp_IlanlariGetirByEvSahibiID", baglanti);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@EvSahibiID", EvSahibiID);

			DataTable dt = new DataTable();
			da.Fill(dt);
			dgvIlanlar.DataSource = dt;

			if (dgvIlanlar.Columns.Contains("ResimYolu"))
				dgvIlanlar.Columns["ResimYolu"].Visible = false;
		}


		private void btnResimEkle_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				seciliResimYolu = ofd.FileName;
				pbResim.Image = Image.FromFile(seciliResimYolu);
			}
		}

		private void btnResimSil_Click(object sender, EventArgs e)
		{
			if (seciliIlanID == -1)
			{
				MessageBox.Show("Lütfen önce bir ilan seçin.");
				return;
			}

			DialogResult result = MessageBox.Show("Bu ilanın resmini silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result != DialogResult.Yes) return;

			// Görseli arayüzden temizle
			pbResim.Image = null;
			seciliResimYolu = "";

			// Veritabanından sil
			try
			{
				using (SqlConnection conn = new SqlConnection(baglanti.ConnectionString))
				{
					conn.Open();
					string sql = "DELETE FROM IlanResimleri WHERE IlanID = @IlanID";

					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@IlanID", seciliIlanID);
						cmd.ExecuteNonQuery();
					}
				}

				MessageBox.Show("Resim silindi.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Resim silinirken hata oluştu: " + ex.Message);
			}
		}


		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtBaslik.Text) ||
				string.IsNullOrWhiteSpace(txtAciklama.Text) ||
				string.IsNullOrWhiteSpace(txtKonum.Text) ||
				string.IsNullOrWhiteSpace(txtFiyat.Text) ||
				cmbDurum.SelectedIndex == -1 ||
				cmbKapasite.SelectedIndex == -1 ||
				string.IsNullOrWhiteSpace(seciliResimYolu))
			{
				MessageBox.Show("Lütfen tüm alanları doldurun ve resim ekleyin.");
				return;
			}

			if (!decimal.TryParse(txtFiyat.Text, out decimal fiyat))
			{
				MessageBox.Show("Geçerli bir fiyat giriniz.");
				return;
			}

			// Aynı başlık varsa kayıt yapılmasın
			SqlCommand kontrolCmd = new SqlCommand("SELECT COUNT(*) FROM Ilanlar WHERE Baslik = @Baslik AND Durum <> 'Silinmis'", baglanti);
			kontrolCmd.Parameters.AddWithValue("@Baslik", txtBaslik.Text);
			baglanti.Open();
			int sayi = (int)kontrolCmd.ExecuteScalar();
			baglanti.Close();

			if (sayi > 0)
			{
				MessageBox.Show("Bu başlığa sahip bir ilan zaten var.");
				return;
			}

			// Resmi güvenli şekilde kopyala
			string hedefKlasor = Path.Combine(Application.StartupPath, "Resimler");
			Directory.CreateDirectory(hedefKlasor);
			string dosyaAdi = Guid.NewGuid().ToString() + Path.GetExtension(seciliResimYolu);
			string hedefResimYolu = Path.Combine(hedefKlasor, dosyaAdi);

			try
			{
				using (Image image = Image.FromFile(seciliResimYolu))
				{
					image.Save(hedefResimYolu);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Resim kopyalanırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Veritabanına ilan ekle
			SqlCommand cmd = new SqlCommand(@"
		INSERT INTO Ilanlar (Baslik, Aciklama, Fiyat, BaslangicTarihi, BitisTarihi, Durum, Konum, Kapasite, EvSahibiID)
		VALUES (@Baslik, @Aciklama, @Fiyat, @BaslangicTarihi, @BitisTarihi, @Durum, @Konum, @Kapasite, @EvSahibiID);
		SELECT SCOPE_IDENTITY();", baglanti);

			cmd.Parameters.AddWithValue("@Baslik", txtBaslik.Text);
			cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
			cmd.Parameters.AddWithValue("@Fiyat", fiyat);
			cmd.Parameters.AddWithValue("@BaslangicTarihi", dtpBaslangic.Value);
			cmd.Parameters.AddWithValue("@BitisTarihi", dtpBitis.Value);
			cmd.Parameters.AddWithValue("@Durum", cmbDurum.SelectedItem.ToString());
			cmd.Parameters.AddWithValue("@Konum", txtKonum.Text);
			cmd.Parameters.AddWithValue("@Kapasite", cmbKapasite.SelectedItem.ToString());
			cmd.Parameters.AddWithValue("@EvSahibiID", EvSahibiID);

			baglanti.Open();
			int ilanID = Convert.ToInt32(cmd.ExecuteScalar());

			SqlCommand resimCmd = new SqlCommand("INSERT INTO IlanResimleri (IlanID, ResimYolu) VALUES (@IlanID, @ResimYolu)", baglanti);
			resimCmd.Parameters.AddWithValue("@IlanID", ilanID);
			resimCmd.Parameters.AddWithValue("@ResimYolu", hedefResimYolu);
			resimCmd.ExecuteNonQuery();
			baglanti.Close();

			MessageBox.Show("İlan başarıyla kaydedildi.");
			IlanlariYukle();
			Temizle();
		}




		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (seciliIlanID == -1)
			{
				MessageBox.Show("Lütfen güncellenecek bir ilan seçin.");
				return;
			}

			if (!decimal.TryParse(txtFiyat.Text, out decimal fiyat))
			{
				MessageBox.Show("Geçerli bir fiyat giriniz.");
				return;
			}

			string yeniResimYolu = "";

			if (!string.IsNullOrWhiteSpace(seciliResimYolu))
			{
				try
				{
					string hedefKlasor = Path.Combine(Application.StartupPath, "Resimler");
					Directory.CreateDirectory(hedefKlasor);

					string dosyaAdi = Guid.NewGuid().ToString() + Path.GetExtension(seciliResimYolu); // eşsiz isim
					yeniResimYolu = Path.Combine(hedefKlasor, dosyaAdi);

					// Dosyayı belleğe alıp yeni adla kaydet
					using (Image image = Image.FromFile(seciliResimYolu))
					{
						image.Save(yeniResimYolu);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Resim kopyalanırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			SqlCommand cmd = new SqlCommand(@"
		UPDATE Ilanlar
		SET Baslik = @Baslik,
			Aciklama = @Aciklama,
			Fiyat = @Fiyat,
			BaslangicTarihi = @BaslangicTarihi,
			BitisTarihi = @BitisTarihi,
			Durum = @Durum,
			Konum = @Konum,
			Kapasite = @Kapasite
		WHERE IlanID = @IlanID", baglanti);

			cmd.Parameters.AddWithValue("@Baslik", txtBaslik.Text);
			cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
			cmd.Parameters.AddWithValue("@Fiyat", fiyat);
			cmd.Parameters.AddWithValue("@BaslangicTarihi", dtpBaslangic.Value);
			cmd.Parameters.AddWithValue("@BitisTarihi", dtpBitis.Value);
			cmd.Parameters.AddWithValue("@Durum", cmbDurum.SelectedItem?.ToString() ?? "Aktif");
			cmd.Parameters.AddWithValue("@Konum", txtKonum.Text);
			cmd.Parameters.AddWithValue("@Kapasite", cmbKapasite.SelectedItem?.ToString() ?? "1+1");
			cmd.Parameters.AddWithValue("@IlanID", seciliIlanID);

			baglanti.Open();
			cmd.ExecuteNonQuery();

			if (!string.IsNullOrWhiteSpace(seciliResimYolu))
			{
				SqlCommand silCmd = new SqlCommand("DELETE FROM IlanResimleri WHERE IlanID = @IlanID", baglanti);
				silCmd.Parameters.AddWithValue("@IlanID", seciliIlanID);
				silCmd.ExecuteNonQuery();

				SqlCommand resimCmd = new SqlCommand("INSERT INTO IlanResimleri (IlanID, ResimYolu) VALUES (@IlanID, @ResimYolu)", baglanti);
				resimCmd.Parameters.AddWithValue("@IlanID", seciliIlanID);
				resimCmd.Parameters.AddWithValue("@ResimYolu", yeniResimYolu);
				resimCmd.ExecuteNonQuery();
			}

			baglanti.Close();
			MessageBox.Show("İlan başarıyla güncellendi.");
			IlanlariYukle();
			Temizle();
		}





		private void btnSil_Click(object sender, EventArgs e)
		{
			if (seciliIlanID == -1)
			{
				MessageBox.Show("Lütfen silinecek ilanı seçin.");
				return;
			}

			SqlCommand cmd = new SqlCommand("DELETE FROM IlanResimleri WHERE IlanID = @IlanID; DELETE FROM Ilanlar WHERE IlanID = @IlanID", baglanti);
			cmd.Parameters.AddWithValue("@IlanID", seciliIlanID);

			baglanti.Open();
			cmd.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("İlan silindi.");
			IlanlariYukle();
			Temizle();
		}

		private void btnTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}

		private void Temizle()
		{
			txtBaslik.Clear();
			txtAciklama.Clear();
			txtFiyat.Clear();
			txtKonum.Clear();
			dtpBaslangic.Value = DateTime.Today;
			dtpBitis.Value = DateTime.Today;
			cmbDurum.SelectedIndex = -1;
			cmbKapasite.SelectedIndex = -1;
			pbResim.Image = null;
			seciliResimYolu = "";
			seciliIlanID = -1;
		}

		private void dgvIlanlar_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvIlanlar.Rows[e.RowIndex];
				seciliIlanID = Convert.ToInt32(row.Cells["IlanID"].Value);
				txtBaslik.Text = row.Cells["Baslik"].Value.ToString();
				txtKonum.Text = row.Cells["Konum"].Value.ToString();
				txtAciklama.Text = row.Cells["Aciklama"].Value.ToString();
				txtFiyat.Text = row.Cells["Fiyat"].Value.ToString();
				dtpBaslangic.Value = Convert.ToDateTime(row.Cells["BaslangicTarihi"].Value);
				dtpBitis.Value = Convert.ToDateTime(row.Cells["BitisTarihi"].Value);
				cmbDurum.SelectedItem = row.Cells["Durum"].Value.ToString();
				cmbKapasite.SelectedItem = row.Cells["kapasite"].Value?.ToString();

				string resimYolu = row.Cells["ResimYolu"].Value?.ToString();
				seciliResimYolu = "";
				pbResim.Image = null;

				if (!string.IsNullOrWhiteSpace(resimYolu) && File.Exists(resimYolu))
				{
					try
					{
						string[] izinliUzantilar = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
						string uzanti = Path.GetExtension(resimYolu).ToLower();

						if (!izinliUzantilar.Contains(uzanti))
						{
							MessageBox.Show("Desteklenmeyen resim formatı.");
							return;
						}

						using (var fs = new FileStream(resimYolu, FileMode.Open, FileAccess.Read))
						using (var tempImage = Image.FromStream(fs))
						{
							pbResim.Image = new Bitmap(tempImage);
						}
						seciliResimYolu = resimYolu;
					}
					catch
					{
						MessageBox.Show("Resim yüklenemedi.");
					}
				}
			}
		}
	}
}