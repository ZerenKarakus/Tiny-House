using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
	public partial class KayitOl : Form
	{
		//kullanacagimiz veritabani baglantisi
		string baglantiMetni = "Data Source=LAPTOP-QCSD0KI9\\ZEREN;Initial Catalog=tinyHouse;Integrated Security=True";
		public KayitOl()
		{
			InitializeComponent();
		}


		private void btnKayitOl_Click(object sender, EventArgs e)
		{
			try
			{
				//kutuların bos olup olmadigini ve sifrelerin ayni olup olmadigini kontrol eder
				if (kutuBosMu() || sifreKontrol())
				{
					MessageBox.Show("Geçerli şartlar sağlanmıyor. Tekrar deneyiniz.");
					return;
				}

				//radio buttonlarin secilip secilmedigini kontrolm eder
				if (!rbEvSahibi.Checked && !rbKiraci.Checked)
				{
					MessageBox.Show("Lütfen kullanıcı türünü seçiniz.");
					return;
				}

				//secilen radio buttona gore tablo ismi atıyor
				string rol = rbEvSahibi.Checked ? "EvSahibi" : "Kiraci";
				string kullaniciAdi = txtKullaniciAdi.Text.Trim();
				string eposta = txtKullaniciEMail.Text.Trim();
				string ad = txtAd.Text.Trim();
				string soyad = txtSoyad.Text.Trim();

				//ayni kullanici adi veya e-mail var mi kontrol ediyor
				if (kullaniciMailKontrol(kullaniciAdi, eposta))
				{
					return;
				}



				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					baglanti.Open();

					//ana tabloya kayit ekleme sorgusu
					string anaKayit = @"INSERT INTO Kullanicilar (KullaniciAdi, Ad, Soyad, Eposta, SifreHash, Rol, Aktif, KayitTarihi)
                                        VALUES (@KullaniciAdi, @Ad, @Soyad, @Eposta, @SifreHash, @Rol, @Aktif, @KayitTarihi)";
					int yeniKullaniciID;

					//yeni eklenen kullanicinin id si alinir
					using (SqlCommand komut = new SqlCommand(anaKayit, baglanti))
					{
						komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
						komut.Parameters.AddWithValue("@Ad", ad);
						komut.Parameters.AddWithValue("@Soyad", soyad);
						komut.Parameters.AddWithValue("@Eposta", eposta);
						komut.Parameters.AddWithValue("@SifreHash", SifreHelper.sifreHash(txtKullaniciSifre.Text));
						komut.Parameters.AddWithValue("@Rol", rol);
						komut.Parameters.AddWithValue("@Aktif", true);
						komut.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);

						// yeniKullaniciID = Convert.ToInt32(komut.ExecuteScalar());

						int eklenen = komut.ExecuteNonQuery();

						if (eklenen > 0)
						{
							MessageBox.Show("Kayıt başarılı.");
						}
						else
						{
							MessageBox.Show("Kayıt başarısız.");
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz.", ex.Message);
			}
		}

		//kutunun bos olup olmadigini anlamamiz icin fonksiyon
		private bool kutuBosMu()
		{
			try
			{
				//text boxları kontrol eder
				if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
					string.IsNullOrWhiteSpace(txtAd.Text) ||
					string.IsNullOrWhiteSpace(txtSoyad.Text) ||
					string.IsNullOrWhiteSpace(txtKullaniciEMail.Text) ||
					string.IsNullOrWhiteSpace(txtKullaniciSifre.Text) ||
					string.IsNullOrWhiteSpace(txtSifreTekrar.Text))
				{
					MessageBox.Show("Lütfen tüm alanları doldurunuz.");
					return true;
				}

				return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu! Tekrar deneyiniz.", ex.Message);
				return true;
			}
		}

		//sifre ve sifre tekrar ayni mi kontrol eder
		private bool sifreKontrol()
		{
			try
			{
				if (!(txtKullaniciSifre.Text.Equals(txtSifreTekrar.Text)))
				{
					MessageBox.Show("Şifreler aynı değil!");
					return true;
				}

				return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!", ex.Message);
				return false;
			}
		}

		// kullanici ayni maili ayni tipte kullanmis mi kullanmamis mi kontrol eder
		private bool kullaniciMailKontrol(string kullaniciAdi, string eposta)
		{
			try
			{
				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					baglanti.Open();

					string queryKullaniciAdi = "SELECT 1 FROM Kullanicilar WHERE KullaniciAdi = @kullaniciAdi";

					using (SqlCommand komut = new SqlCommand(queryKullaniciAdi, baglanti))
					{
						komut.Parameters.Add("@kullaniciAdi", SqlDbType.NVarChar, 50).Value = kullaniciAdi;

						using (SqlDataReader okuyucu = komut.ExecuteReader())
						{
							if (okuyucu.HasRows)
							{
								MessageBox.Show("Bu kullanıcı adı zaten kayıtlı.");
								return true;
							}
						}
					}

					string queryEposta = "SELECT 1 FROM Kullanicilar WHERE Eposta = @eposta";

					using (SqlCommand komut = new SqlCommand(queryEposta, baglanti))
					{
						komut.Parameters.Add("@eposta", SqlDbType.NVarChar, 100).Value = eposta;

						using (SqlDataReader okuyucu = komut.ExecuteReader())
						{
							if (okuyucu.HasRows)
							{
								MessageBox.Show("Bu e-posta adresi zaten kayıtlı.");
								return true;
							}
						}
					}
					return false;
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!", ex.Message);
				return true;
			}
		}
	}
}
