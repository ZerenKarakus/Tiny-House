using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyHouseProjesi;

namespace TinyHouseProjesi
{
	public partial class SifremiUnuttum : Form
	{
		//kullanacagimiz veritabani baglantisi
		string baglantiMetni = "Data Source=LAPTOP-QCSD0KI9\\ZEREN;Initial Catalog=tinyHouse;Integrated Security=True";

		public SifremiUnuttum()
		{
			InitializeComponent();
		}

		private void btnGonder_Click(object sender, EventArgs e)
		{
			try
			{
				string eMail = txtEmail.Text.Trim();

				if (string.IsNullOrEmpty(eMail))
				{
					MessageBox.Show("E-Mail kısımını boş bırakmayınız!");
					return;
				}

				//var tabloBilgisiGoster = tabloBilgi();

				string rol = null;
				if (rbAdmin.Checked)
					rol = "Admin";
				else if (rbEvSahibi.Checked)
					rol = "EvSahibi";
				else if (rbKiraci.Checked)
					rol = "Kiraci";

				if (rol == null)
				{
					MessageBox.Show("Lütfen kullanıcı türünü (Admin, Ev Sahibi, Kiracı) seçiniz!");
					return;
				}

				if (!eMailKayitliMi(eMail, rol))
				{
					MessageBox.Show("Bu E-Mail adresi kayıtlı değildir!");
					return;
				}

				string yeniSifre = yeniSifreOlustur();
				string hashliYeniSire = SifreHelper.sifreHash(yeniSifre);

				bool islem = sifreGuncelle(eMail, hashliYeniSire, rol);

				if (islem)
				{
					bool mailGonderildi = mailGonderme(yeniSifre, eMail);

					if (mailGonderildi)
						MessageBox.Show("Yeni şifreniz E-Mail adresinize gönderildi.");
					else
						MessageBox.Show("Mail gönderilemedi");
				}
				else
				{
					MessageBox.Show("Şifre güncellenemedi tekrar deneyiniz.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz.", ex.Message);
			}
		}

		//yeni sifreyi olusturacak islemleri yapar
		private string yeniSifreOlustur(int uzunluk = 8)
		{
			try
			{
				const string harfler = "abcçdefgğhıijklmnoöprsştuüyzABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜYZ0123456789";
				Random random = new Random();//ustteki harflerden rastgele secim yapabilmek icin random fonksiyonunu kullanacagiz

				char[] kelime = new char[uzunluk]; //sifreyi depolayacagim dizi

				//for dongusu ile istenilen uzunlukta kelime(sifre) olusturma
				for (int baslangic = 0; baslangic < uzunluk; baslangic++)
					kelime[baslangic] = harfler[random.Next(harfler.Length)];

				return new string(kelime); //dizideki her bir karakteri birlestirip yeni bir string olusturur
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!", ex.Message);
				return null;
			}
		}

		//e-mailin kayitli olup olmadigini kontrol eden fonksiyon
		private bool eMailKayitliMi(string eMail, string rol)
		{
			try
			{
				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					baglanti.Open();

					//e-mailin daha once kayili olup olmadigini kontrol edecek sorgu
					string query = "SELECT COUNT(*) FROM Kullanicilar WHERE Eposta = @email AND Rol = @rol";

					using (SqlCommand komut = new SqlCommand(query, baglanti))
					{
						//sorguya degerleri ekliyorum
						komut.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = eMail;
						komut.Parameters.Add("@rol", SqlDbType.NVarChar, 20).Value = rol;

						int kullanici = (int)komut.ExecuteScalar();

						return kullanici > 0;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!", ex.Message);
				return false;
			}
		}

		private bool sifreGuncelle(string eMail, string hashliYeniSifre, string rol)
		{
			try
			{
				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					baglanti.Open();

					//sifreyi guncelleme sorgusu
					string query = "UPDATE Kullanicilar SET SifreHash = @sifre WHERE Eposta = @email AND Rol = @rol";

					using (SqlCommand komut = new SqlCommand(query, baglanti))
					{
						//sorguya degerleri ekliyoruz
						komut.Parameters.Add("@sifre", SqlDbType.NVarChar, -1).Value = hashliYeniSifre;
						komut.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = eMail;
						komut.Parameters.Add("@rol", SqlDbType.NVarChar, 20).Value = rol;

						int eklenenSatir = komut.ExecuteNonQuery();

						return eklenenSatir > 0;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bir hata oluştu tekrar deneyiniz!", ex.Message);
				return false;
			}
		}

		//mail gonderecej fonksiyonuzmuz
		private bool mailGonderme(string yeniSifre, string email)
		{
			try
			{
				string smtpServer = "smtp.gmail.com";
				int smtpPort = 587; //port numaramız
				string smtpUser = "zueproje@gmail.com"; //mesaji gonderecek eMail
				string smtpPass = "ehws knlc mobj zbka";

				MailMessage mail = new MailMessage();
				SmtpClient smtpClient = new SmtpClient(); //smtp basit mail gonderici aciyoruz

				mail.From = new MailAddress(smtpUser); //mailin kimden gelecegini alir
				mail.To.Add(txtEmail.Text); //mail kime gidecek
				mail.Subject = "Yeni sifreniz"; //konusu
				mail.Body = $"Kullanabileceginiz yeni gecici sifreniz: {yeniSifre}\n Güvenliginiz için şifrenizi kimseyle paylaşmayınız"; //mesaj içerigi

				smtpClient.Host = smtpServer;
				smtpClient.Port = smtpPort;
				smtpClient.Credentials = new NetworkCredential(smtpUser, smtpPass); //kimlik dogrulama yapar
				smtpClient.EnableSsl = true; //guvenlik sertifikasını istiyor ssl kullaniyoruz

				smtpClient.Send(mail); //mail gonderir
				MessageBox.Show("E-Mailinize yeni şifreniz gönderildi.");
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!", ex.Message);
				return false;
			}
		}
	}
}
