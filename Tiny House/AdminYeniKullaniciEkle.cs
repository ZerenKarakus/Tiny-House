using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHouseProjesi;

namespace TinyHouseProjesi
{
	public partial class AdminYeniKullaniciEkle : Form
	{
		public AdminYeniKullaniciEkle()
		{
			InitializeComponent();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				string ad = txtAd.Text.Trim();
				string soyad = txtSoyad.Text.Trim();
				string eposta = txtEposta.Text.Trim();
				string sifre = txtSifre.Text.Trim();
				string rol = cmbRol.SelectedItem?.ToString();

				if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(eposta) || string.IsNullOrWhiteSpace(sifre) || string.IsNullOrWhiteSpace(rol))
				{
					MessageBox.Show("Lütfen tüm alanları doldurunuz.");
					return;
				}

				VeritabaniYardimci db = new VeritabaniYardimci();

				string sorgu = @"
					INSERT INTO Kullanicilar (Ad, Soyad, Eposta, SifreHash, Rol)
					VALUES (@Ad, @Soyad, @Eposta, @SifreHash, @Rol)";

				SqlParameter[] parametreler = new SqlParameter[]
				{
					new SqlParameter("@Ad", ad),
					new SqlParameter("@Soyad", soyad),
					new SqlParameter("@Eposta", eposta),
					new SqlParameter("@SifreHash", sifre),
					new SqlParameter("@Rol", rol)
				};

				int sonuc = db.ParametreliKomut(sorgu, parametreler);

				if (sonuc > 0)
				{
					MessageBox.Show("Yeni kullanıcı başarıyla eklendi.");
					this.Close();
				}
				else
				{
					MessageBox.Show("Kullanıcı eklenemedi.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex.Message);
			}
		}
	}
}
