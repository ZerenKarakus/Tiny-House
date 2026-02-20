using System;
using System.Data;
using System.Windows.Forms;
using TinyHouseProjesi;

namespace TinyHouseProjesi
{
	public partial class AdminKullaniciYonetimi : Form
	{

		public AdminKullaniciYonetimi()
		{
			InitializeComponent();
			this.Load += new EventHandler(AdminKullaniciYonetimi_Load);
		}

		private void AdminKullaniciYonetimi_Load(object sender, EventArgs e)
		{
			try
			{
				VeritabaniYardimci db = new VeritabaniYardimci();
				DataTable tablo = db.VeriGetir("SELECT KullaniciID, Ad, Soyad, Eposta, Rol, Aktif FROM Kullanicilar");
				dgvKullanicilar.DataSource = tablo;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Kullanıcılar listelenirken hata oluştu: " + ex.Message);
			}
		}


		private void btnAra_Click(object sender, EventArgs e)
		{
			try
			{
				string aranan = txtAra.Text.Trim();

				if (string.IsNullOrEmpty(aranan))
				{
					MessageBox.Show("Lütfen aramak için bir metin giriniz.");
					return;
				}

				VeritabaniYardimci db = new VeritabaniYardimci();
				string sorgu = $@"
            SELECT KullaniciID, Ad, Soyad, Eposta, Rol, Aktif 
            FROM Kullanicilar 
            WHERE Ad LIKE '%{aranan}%' OR Eposta LIKE '%{aranan}%'";

				DataTable tablo = db.VeriGetir(sorgu);
				dgvKullanicilar.DataSource = tablo;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Arama sırasında hata oluştu: " + ex.Message);
			}
		}


		private void btnYeniEkle_Click(object sender, EventArgs e)
		{
			AdminYeniKullaniciEkle frm = new AdminYeniKullaniciEkle();
			frm.ShowDialog();

			// Form kapandıktan sonra listeyi yenile
			AdminKullaniciYonetimi_Load(null, null);
		}


		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (dgvKullanicilar.SelectedRows.Count == 0)
			{
				MessageBox.Show("Lütfen bir kullanıcı seçiniz.");
				return;
			}

			int secilenID = Convert.ToInt32(dgvKullanicilar.SelectedRows[0].Cells["KullaniciID"].Value);
			AdminKullaniciGuncelle frm = new AdminKullaniciGuncelle(secilenID);
			frm.ShowDialog();

			// Listeyi yenile
			AdminKullaniciYonetimi_Load(null, null);
		}



		private void btnPasifYap_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgvKullanicilar.SelectedRows.Count == 0)
				{
					MessageBox.Show("Lütfen pasif yapmak istediğiniz kullanıcıyı seçin.");
					return;
				}

				int secilenID = Convert.ToInt32(dgvKullanicilar.SelectedRows[0].Cells["KullaniciID"].Value);

				DialogResult sonuc = MessageBox.Show("Bu kullanıcıyı pasif yapmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
				if (sonuc == DialogResult.Yes)
				{
					VeritabaniYardimci db = new VeritabaniYardimci();
					string sorgu = $"UPDATE Kullanicilar SET Aktif = 0 WHERE KullaniciID = {secilenID}";
					db.VeriGetir(sorgu);

					MessageBox.Show("Kullanıcı başarıyla pasif yapıldı.");

					// Listeyi yenile
					AdminKullaniciYonetimi_Load(null, null);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Kullanıcı pasif yapılırken hata oluştu: " + ex.Message);
			}
		}

		private void btnAktifYap_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgvKullanicilar.SelectedRows.Count == 0)
				{
					MessageBox.Show("Lütfen aktif yapmak istediğiniz kullanıcıyı seçin.");
					return;
				}

				int secilenID = Convert.ToInt32(dgvKullanicilar.SelectedRows[0].Cells["KullaniciID"].Value);

				DialogResult sonuc = MessageBox.Show("Bu kullanıcıyı tekrar aktif yapmak istiyor musunuz?", "Onay", MessageBoxButtons.YesNo);
				if (sonuc == DialogResult.Yes)
				{
					VeritabaniYardimci db = new VeritabaniYardimci();
					string sorgu = $"UPDATE Kullanicilar SET Aktif = 1 WHERE KullaniciID = {secilenID}";
					db.VeriGetir(sorgu);

					MessageBox.Show("Kullanıcı başarıyla aktif hale getirildi.");
					AdminKullaniciYonetimi_Load(null, null);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Aktif yapma işlemi sırasında hata oluştu: " + ex.Message);
			}
		}


	}
}