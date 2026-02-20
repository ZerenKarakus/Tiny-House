using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHouseProjesi;

namespace TinyHouseProjesi
{
	public partial class AdminKullaniciGuncelle : Form
	{
		private int _kullaniciID;

		public AdminKullaniciGuncelle(int kullaniciID)
		{
			InitializeComponent();
			_kullaniciID = kullaniciID;
			this.Load += AdminKullaniciGuncelle_Load;
		}

		private void AdminKullaniciGuncelle_Load(object sender, EventArgs e)
		{
			try
			{
				VeritabaniYardimci db = new VeritabaniYardimci();
				string sql = "SELECT * FROM Kullanicilar WHERE KullaniciID = @KullaniciID";
				SqlParameter[] parametreler = {
					new SqlParameter("@KullaniciID", _kullaniciID)
				};

				DataTable dt = db.ParametreliVeriGetir(sql, parametreler);

				if (dt.Rows.Count > 0)
				{
					txtAd.Text = dt.Rows[0]["Ad"].ToString();
					txtSoyad.Text = dt.Rows[0]["Soyad"].ToString();
					txtEposta.Text = dt.Rows[0]["Eposta"].ToString();
					txtSifre.Text = dt.Rows[0]["SifreHash"].ToString();
					cmbRol.SelectedItem = dt.Rows[0]["Rol"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Veri yükleme hatası: " + ex.Message);
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			try
			{
				string ad = txtAd.Text.Trim();
				string soyad = txtSoyad.Text.Trim();
				string mail = txtEposta.Text.Trim();
				string sifre = txtSifre.Text.Trim();
				string rol = cmbRol.SelectedItem?.ToString();

				VeritabaniYardimci db = new VeritabaniYardimci();

				string sorgu = @"
                    UPDATE Kullanicilar
                    SET Ad = @Ad, Soyad = @Soyad, Eposta = @Eposta, SifreHash = @SifreHash, Rol = @Rol
                    WHERE KullaniciID = @KullaniciID";

				SqlParameter[] parametreler = {
					new SqlParameter("@Ad", ad),
					new SqlParameter("@Soyad", soyad),
					new SqlParameter("@Eposta", mail),
					new SqlParameter("@SifreHash", sifre),
					new SqlParameter("@Rol", rol),
					new SqlParameter("@KullaniciID", _kullaniciID)
				};

				int sonuc = db.ParametreliKomut(sorgu, parametreler);

				if (sonuc > 0)
				{
					MessageBox.Show("Kullanıcı başarıyla güncellendi.");
					this.Close();
				}
				else
				{
					MessageBox.Show("Güncelleme başarısız.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex.Message);
			}
		}

		private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
		{
			txtSifre.PasswordChar = chkSifreGoster.Checked ? '\0' : '*';
		}
	}
}
