using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyHouseProjesi;

namespace TinyHouseProjesi
{
	public partial class AdminGiris : Form
	{
		public AdminGiris()
		{
			InitializeComponent();
		}



		private void btnGirisYap_Click(object sender, EventArgs e)
		{
			try
			{
				// kullanici adi ve sifreyi aliyor
				string adminMail = txtEMail.Text.Trim();
				string adminSifre = txtSifre.Text.Trim();

				// admin email ve sifre degerleri olup olmadigina bakiyor
				if (string.IsNullOrEmpty(adminMail) || string.IsNullOrEmpty(adminSifre))
				{
					MessageBox.Show("E-Mail ve şifreyi giriniz!");
					return;
				}

				if (giris(adminMail, adminSifre)) //giris matodunu cagiriyor ve verdigi degere gore sonuc donduruyor
				{
					MessageBox.Show("Giriş başarılı.");
					this.Hide(); // Bu formu gizle

					using (AdminAnaSayfa evSahibiEkrani = new AdminAnaSayfa())
					{
						evSahibiEkrani.ShowDialog(); // MODAL OLARAK AÇ
					}

					this.Show(); // KiraciAnaSayfa kapanınca tekrar göster
				}
				else
				{
					MessageBox.Show("E-Mail veya şifre hatalı!");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!");
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				this.Hide(); //ana formu gizliyor

				using (SifremiUnuttum sifre = new SifremiUnuttum()) //kayit formu acıyor
					sifre.ShowDialog();//actigi formu gosteriyor

				this.Show();//actıgı form(kayıtOl) kapandiktan sonra ana formu geri gosteriyor
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!");
			}
		}


		private bool giris(string adminMail, string adminSifre)
		{
			//kullanacagimiz veritabani baglantisi
			string baglantiMetni = "Data Source=LAPTOP-QCSD0KI9\\ZEREN;Initial Catalog=tinyHouse;Integrated Security=True";

			try
			{
				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					baglanti.Open();

					// adminin email ve sifresi icin eslesme sorgusu
					string query = "SELECT COUNT(*) FROM Kullanicilar WHERE Eposta = @adminEMail AND SifreHash = @adminSifre AND Rol = 'Admin' AND Aktif = '1'";

					using (SqlCommand komut = new SqlCommand(query, baglanti))
					{
						// degerleri sorguya ekliyorum
						komut.Parameters.Add("@adminEMail", SqlDbType.NVarChar, 50).Value = adminMail;
						komut.Parameters.Add("@adminSifre", SqlDbType.NVarChar, 50).Value = adminSifre;

						int kullanici = (int)komut.ExecuteScalar(); //eslesen kayit sayisini buluyor

						return kullanici > 0; // eslesen kayit sayisina gore deger donduruyor
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!");
				return false;
			}
		}

		private void btnGeri_Click(object sender, EventArgs e)
		{
			this.Hide(); // Formu gizle
			using (GirisTuruSecme yeniForm = new GirisTuruSecme())
			{
				yeniForm.ShowDialog(); // Bu kapanınca program devam eder
			}
			this.Close(); // Bu satır formdan çıkınca kapanmasını sağlar
		}


		private void btnCikis_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}

	//sifreleri guvenli hale getirebilmek icin hash sinifi kullanarak hashlerim
	public static class SifreHelper
	{
		public static string sifreHash(string sifre)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(sifre));  //hashi hesaplar ve sifreyi byte dizisine donusturur 
				StringBuilder builder = new StringBuilder();//sonucu icin stringbuilder olusturur

				foreach (byte b in bytes)
					builder.Append(b.ToString("x2"));//her byt i 2 karakterlik onaltilik formata cevirir

				return builder.ToString();
			}
		}
	}
}
