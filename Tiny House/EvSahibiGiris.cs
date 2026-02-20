using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyHouseProjesi;

namespace TinyHouseProjesi
{
	public partial class EvSahibiGiris : Form
	{
		public EvSahibiGiris()
		{
			InitializeComponent();
		}

		private void btnGirisYap_Click(object sender, EventArgs e)
		{
			try
			{
				// kullanici adi ve sifreyi aliyor
				string evSahibiVeyaMail = txtMailVeyaKullanici.Text.Trim();
				string evSahibiSifre = txtEvSahibiSifre.Text.Trim();

				// ev sahibi E-mail/kullanici adi olup olamdigina bakiyor
				if (string.IsNullOrEmpty(evSahibiVeyaMail) || string.IsNullOrEmpty(evSahibiSifre))
				{
					MessageBox.Show("E-Mail/kullanıcı adi ve şifreyi giriniz!");
					return;
				}

				if (giris(evSahibiVeyaMail, evSahibiSifre)) //giris matodunu cagiriyor ve verdigi degere gore sonuc donduruyor
				{
					MessageBox.Show("Giriş başarılı.");
					this.Hide(); // Bu formu gizle

					using (EvSahibiAnaSayfa evSahibiEkrani = new EvSahibiAnaSayfa())
					{
						evSahibiEkrani.ShowDialog(); // MODAL OLARAK AÇ
					}

					//this.Show(); // KiraciAnaSayfa kapanınca tekrar göster
				}
				else
				{
					MessageBox.Show("E-Mail/kullaıcı adı veya şifre hatalı!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata olustu tekrar deneyiniz!");
			}
		}

		private void btnKayitOl_Click(object sender, EventArgs e) //kayıt ol butonu
		{
			try
			{
				this.Hide(); //ana formu gizliyor

				using (KayitOl kayıtOl = new KayitOl()) //kayit formu acıyor
					kayıtOl.ShowDialog();//actigi formu gosteriyor

				//this.Show();//actıgı form(kayıtOl) kapandiktan sonra ana formu geri gosteriyor
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!");
			}
		}

		private bool giris(string evSahibiAdVeyaMail, string evSahibiSifre)
		{
			try
			{
				string baglantiMetni = "Data Source=LAPTOP-QCSD0KI9\\ZEREN;Initial Catalog=tinyHouse;Integrated Security=True";

				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					baglanti.Open();

					string query = "SELECT KullaniciID FROM Kullanicilar WHERE (Eposta = @evSahibiAdVeyaMail OR KullaniciAdi = @evSahibiAdVeyaMail) AND SifreHash = @evSahibiSifre AND Rol = 'EvSahibi' AND Aktif = '1'";

					using (SqlCommand komut = new SqlCommand(query, baglanti))
					{
						komut.Parameters.Add("@evSahibiAdVeyaMail", SqlDbType.NVarChar, 50).Value = evSahibiAdVeyaMail;
						komut.Parameters.Add("@evSahibiSifre", SqlDbType.NVarChar, -1).Value = SifreHelper.sifreHash(evSahibiSifre);

						object kullaniciID = komut.ExecuteScalar();

						if (kullaniciID != null)
						{
							KullaniciBilgileri.EvSahibiID = Convert.ToInt32(kullaniciID);
							return true;
						}
						return false;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!");
				return false;
			}
		}


		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				this.Hide(); //ana formu gizliyor

				using (SifremiUnuttum sifre = new SifremiUnuttum()) //kayit formu acıyor
					sifre.ShowDialog();//actigi formu gosteriyor

				//this.Show();//actıgı form(kayıtOl) kapandiktan sonra ana formu geri gosteriyor
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!");
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

		public static class KullaniciBilgileri
		{
			public static int EvSahibiID { get; set; }
		}
	}
}
