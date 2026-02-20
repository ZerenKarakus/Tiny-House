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
	public partial class KiraciGiris : Form
	{
		public KiraciGiris()
		{
			InitializeComponent();
		}

		private void btnGirisYap_Click(object sender, EventArgs e)
		{
			try
			{
				string kiraciVeyaMail = txtMailVeyaKullanici.Text.Trim();
				string kiraciSifre = txtKiraciSifre.Text.Trim();

				if (string.IsNullOrEmpty(kiraciVeyaMail) || string.IsNullOrEmpty(kiraciSifre))
				{
					MessageBox.Show("E-Mail/kullanıcı adi ve şifreyi giriniz!");
					return;
				}

				if (giris(kiraciVeyaMail, kiraciSifre))
				{
					MessageBox.Show("Giriş başarılı.");

					this.Hide(); // Bu formu gizle

					using (KiraciAnaSayfa kiraciEkrani = new KiraciAnaSayfa())
					{
						kiraciEkrani.ShowDialog(); // MODAL OLARAK AÇ
					}

					this.Show(); // KiraciAnaSayfa kapanınca tekrar göster
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

				this.Show();//actıgı form(kayıtOl) kapandiktan sonra ana formu geri gosteriyor
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!");
			}
		}

		private bool giris(string kiraciVeyaMail, string kiraciSifre)
		{
			try
			{
				//kullanacagimiz veritabani baglantisi
				string baglantiMetni = "Data Source=LAPTOP-QCSD0KI9\\ZEREN;Initial Catalog=tinyHouse;Integrated Security=True";

				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					baglanti.Open();

					// kiraci adi/Maili ve sifre sorgusu eslemeye gore kontrol ediyor
					string query = "SELECT KullaniciID FROM Kullanicilar WHERE Rol = 'Kiraci' AND (KullaniciAdi = @kiraciVeyaMail OR Eposta = @kiraciVeyaMail) AND SifreHash = @kiraciSifre AND Aktif = '1'";

					using (SqlCommand komut = new SqlCommand(query, baglanti))
					{
						// degerleri sorguya ekliyor
						komut.Parameters.Add("@kiraciVeyaMail", SqlDbType.NVarChar, 50).Value = kiraciVeyaMail;
						komut.Parameters.Add("@kiraciSifre", SqlDbType.NVarChar, -1).Value = SifreHelper.sifreHash(kiraciSifre);

						object kullanici = komut.ExecuteScalar(); // eslesen kayit sayisini buluyor

						//return kullanici > 0; // eslesen kayit sayisina gore deger donduruyor

						if (kullanici != null)
						{
							KullaniciBilgileri.KiraciID = Convert.ToInt32(kullanici);
							return true;
						}
						return false;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!", ex.Message);
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

				this.Show();//actıgı form(kayıtOl) kapandiktan sonra ana formu geri gosteriyor
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
	}

	public static class KullaniciBilgileri
	{
		public static int KiraciID { get; set; }
	}
}
