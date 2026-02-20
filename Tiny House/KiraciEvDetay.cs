using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyHouseProjesi;

namespace TinyHouseProjesi
{
	public partial class KiraciEvDetay : Form
	{
		//kullanacagimiz veritabani baglantisi
		string baglantiMetni = "Data Source=LAPTOP-QCSD0KI9\\ZEREN;Initial Catalog=tinyHouse;Integrated Security=True";

		private int aktifEvID;
		public KiraciEvDetay(int IlanID)
		{
			InitializeComponent();
			aktifEvID = IlanID;
			bilgiGetir(IlanID);
			yorumVePuan(IlanID);
		}

		private void btnRevize_Click(object sender, EventArgs e)
		{
			DateTime baslangic = dtpGiriş.Value.Date;
			DateTime bitis = dtpCikis.Value.Date;

			if (baslangic < DateTime.Today)
			{
				MessageBox.Show("Geçmiş tarihlere rezervasyon yapılamaz.");
				return;
			}

			if (bitis <= baslangic)
			{
				MessageBox.Show("Çıkış tarihi giriş tarihinden sonra olmalıdır.");
				return;
			}

			int kiraciID = KullaniciBilgileri.KiraciID;

			bool uygunluk = tarihUygunMu(aktifEvID, baslangic, bitis);

			if (uygunluk)
				rezervasyonYapma(aktifEvID, kiraciID, baslangic, bitis);
			else
				MessageBox.Show("Bu tarihlerde ev zaten revize edilmiştir.");
		}

		private void bilgiGetir(int IlanID)
		{
			try
			{
				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					// İlan bilgilerini getir
					string query = @"SELECT Baslik, Aciklama, Konum, kapasite, Fiyat 
                           FROM Ilanlar WHERE IlanID = @id";

					using (SqlCommand komut = new SqlCommand(query, baglanti))
					{
						komut.Parameters.AddWithValue("@id", IlanID);
						baglanti.Open();

						using (SqlDataReader dr = komut.ExecuteReader())
						{
							if (dr.Read())
							{
								lblBaslik.Text = dr["Baslik"].ToString();
								lblAciklama.Text = dr["Aciklama"].ToString();
								lblKonum.Text = dr["Konum"].ToString();
								lblKapasite.Text = dr["kapasite"].ToString();
								lblFiyat.Text = Convert.ToDecimal(dr["Fiyat"]).ToString("C");
							}
							else
							{
								MessageBox.Show("Detay bulunamadi.");
							}
						}
					}

					// İlan resimlerini getir
					string resimQuery = "SELECT ResimYolu FROM IlanResimleri WHERE IlanID = @ilanId";
					using (SqlCommand resimKomut = new SqlCommand(resimQuery, baglanti))
					{
						resimKomut.Parameters.AddWithValue("@ilanId", IlanID);

						using (SqlDataReader resimDr = resimKomut.ExecuteReader())
						{
							if (resimDr.HasRows)
							{
								resimDr.Read();
								string resimYolu = resimDr["ResimYolu"].ToString();
								ResimYukle(resimYolu);
							}
							else
							{
								// Resim yoksa PictureBox'ı temizle
								pbResim.Image = null;
								pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz: " + ex.Message);
				pbResim.Image = null;
			}
		}

		private void ResimYukle(string resimYolu)
		{
			try
			{
				if (File.Exists(resimYolu))
				{
					pbResim.Image = Image.FromFile(resimYolu);
					pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
				}
				else
				{
					pbResim.Image = null;
					MessageBox.Show("Resim dosyası bulunamadı: " + resimYolu);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Resim yüklenirken hata oluştu: " + ex.Message);
				pbResim.Image = null;
			}
		}


		private bool tarihUygunMu(int IlanID, DateTime baslangic, DateTime bitis)
		{
			try
			{
				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					string query = @"
                SELECT COUNT(*) FROM Rezervasyonlar
                WHERE IlanID = @evID
                AND Durum IN ('Onaylandi', 'Beklemede')
                AND (
                    (@baslangic BETWEEN baslangicTarihi AND bitisTarihi)
                    OR (@bitis BETWEEN baslangicTarihi AND bitisTarihi)
                    OR (baslangicTarihi BETWEEN @baslangic AND @bitis)
                    OR (bitisTarihi BETWEEN @baslangic AND @bitis)
                )";

					using (SqlCommand komut = new SqlCommand(query, baglanti))
					{
						komut.Parameters.AddWithValue("@evID", IlanID);
						komut.Parameters.AddWithValue("@baslangic", baslangic);
						komut.Parameters.AddWithValue("@bitis", bitis);

						baglanti.Open();
						int sonuc = (int)komut.ExecuteScalar();
						return sonuc == 0;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz." + ex.Message);
				return false;
			}
		}

		private void rezervasyonYapma(int IlanID, int kiraciID, DateTime baslangic, DateTime bitis)
		{
			try
			{
				decimal gunlukFiyat = 0;

				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					// Günlük fiyatı çek
					string fiyatQuery = "SELECT Fiyat FROM Ilanlar WHERE IlanID = @evID";
					using (SqlCommand komut = new SqlCommand(fiyatQuery, baglanti))
					{
						komut.Parameters.AddWithValue("@evID", IlanID);
						baglanti.Open();
						object sonuc = komut.ExecuteScalar();

						if (sonuc != null)
							gunlukFiyat = Convert.ToDecimal(sonuc);
						else
						{
							MessageBox.Show("Ev bilgisi bulunamadı.");
							return;
						}
					}
				}

				int gun = (bitis - baslangic).Days;
				if (gun <= 0)
				{
					MessageBox.Show("Geçersiz tarih aralığı.");
					return;
				}

				decimal topUcret = gun * gunlukFiyat;

				DialogResult odemeOnayi = MessageBox.Show($"Toplam ücret: {topUcret}\n\nÖdeme yapmak istiyor musunuz?", "Ödeme Onayı", MessageBoxButtons.YesNoCancel);

				if (odemeOnayi == DialogResult.Cancel)
				{
					MessageBox.Show("İşlem iptal edildi.");
					return;
				}

				string odemeDurumu = (odemeOnayi == DialogResult.Yes) ? "Odendi" : "Bekleniyor";
				string ıslemKodu = (odemeOnayi == DialogResult.Yes) ? "Odendi" : "Beklemede";
				string rezervasyonDurumu = "Beklemede";

				int rezervasyonId;

				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					baglanti.Open();

					SqlTransaction transaction = baglanti.BeginTransaction();

					try
					{
						// Rezervasyon Ekle
						string rezervasyonQuery = @"INSERT INTO Rezervasyonlar (IlanID, KiraciID, BaslangicTarihi, BitisTarihi, Durum, OdemeDurumu, RezervasyonTarihi)
                                            VALUES (@evID, @kiraciID, @baslangic, @bitis, @durum, @odemeDurumu, @rezervasyonTarihi);
                                            SELECT SCOPE_IDENTITY();";

						using (SqlCommand rezervasyonCmd = new SqlCommand(rezervasyonQuery, baglanti, transaction))
						{
							rezervasyonCmd.Parameters.AddWithValue("@evID", IlanID);
							rezervasyonCmd.Parameters.AddWithValue("@kiraciID", kiraciID);
							rezervasyonCmd.Parameters.AddWithValue("@baslangic", baslangic);
							rezervasyonCmd.Parameters.AddWithValue("@bitis", bitis);
							rezervasyonCmd.Parameters.AddWithValue("@durum", rezervasyonDurumu);
							rezervasyonCmd.Parameters.AddWithValue("@odemeDurumu", odemeDurumu);
							rezervasyonCmd.Parameters.AddWithValue("@rezervasyonTarihi", DateTime.Now);

							rezervasyonId = Convert.ToInt32(rezervasyonCmd.ExecuteScalar());
						}

						// Ödeme Ekle
						string odemeQuery = @"INSERT INTO Odemeler (RezervasyonID, Tutar, OdemeTarihi, IslemKodu)
                                      VALUES (@rezID, @tutar, @odemeTarihi, @durum)";

						using (SqlCommand odemeCmd = new SqlCommand(odemeQuery, baglanti, transaction))
						{
							odemeCmd.Parameters.AddWithValue("@rezID", rezervasyonId);
							odemeCmd.Parameters.AddWithValue("@tutar", topUcret);
							odemeCmd.Parameters.AddWithValue("@odemeTarihi", (odemeDurumu == "Odendi") ? DateTime.Now : (object)DBNull.Value);
							odemeCmd.Parameters.AddWithValue("@durum", ıslemKodu);
							odemeCmd.ExecuteNonQuery();
						}

						transaction.Commit();

						string mesaj = (odemeDurumu == "Odendi") ? "Ödeme yapıldı. Rezervasyon talebiniz oluşturuldu." :
																	"Ödeme yapılmadı. Rezervasyon talebiniz oluşturuldu.";
						MessageBox.Show($"{mesaj}\nEv sahibi onayı bekleniyor.");
					}
					catch (Exception ex)
					{
						transaction.Rollback();
						MessageBox.Show("Hata oluştu. İşlem geri alındı: " + ex.Message);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz.\n" + ex.Message);
			}
		}



		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void yorumVePuan(int IlanID)
		{
			try
			{
				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					string query = @"SELECT DISTINCT Y.Yorum, Y.YorumID, Y.IlanID, K.KullaniciID, K.KullaniciAdi, Y.Puan, Y.YorumTarihi
                                     FROM Yorumlar Y INNER JOIN Kullanicilar K ON Y.KiraciID = K.KullaniciID
                                     WHERE Y.IlanID = @evID
                                     ORDER BY Y.YorumTarihi DESC";

					using (SqlCommand komut = new SqlCommand(query, baglanti))
					{
						komut.Parameters.AddWithValue("@evID", IlanID);

						SqlDataAdapter da = new SqlDataAdapter(komut);
						DataTable dt = new DataTable();
						da.Fill(dt);

						dgvYorumlar.DataSource = null;
						dgvYorumlar.Rows.Clear();
						dgvYorumlar.DataSource = dt;

						dgvYorumlar.Columns["KullaniciAdi"].HeaderText = "Kullanıcı Adı";
						dgvYorumlar.Columns["YorumID"].Visible = false;
						dgvYorumlar.Columns["IlanID"].Visible = false;
						dgvYorumlar.Columns["YorumTarihi"].HeaderText = "Yorum Tarihi";
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz.", ex.Message);
			}
		}

		private void btnGeri_Click(object sender, EventArgs e)
		{
			// Daha önce açılmış bir KiraciAnaSayfa formu var mı?
			foreach (Form form in Application.OpenForms)
			{
				if (form is KiraciAnaSayfa)
				{
					form.Show();
					this.Close();
					return;
				}
			}

			// Yoksa yeni oluştur
			KiraciAnaSayfa yeniForm = new KiraciAnaSayfa();
			yeniForm.Show();
			this.Close();
		}


		private void btnCikis_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
