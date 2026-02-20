using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using TinyHouseProjesi;

namespace TinyHouseProjesi
{
	public partial class AdminIlanGuncelle : Form
	{
		private int _ilanID;

		public AdminIlanGuncelle(int ilanID)
		{
			InitializeComponent();
			_ilanID = ilanID;
			this.Load += AdminIlanGuncelle_Load;
		}

		private void AdminIlanGuncelle_Load(object sender, EventArgs e)
		{
			try
			{
				VeritabaniYardimci db = new VeritabaniYardimci();
				string sql = "SELECT * FROM Ilanlar WHERE IlanID = @IlanID";
				SqlParameter[] parametreler = {
					new SqlParameter("@IlanID", _ilanID)
				};

				DataTable dt = db.ParametreliVeriGetir(sql, parametreler);

				if (dt.Rows.Count > 0)
				{
					txtBaslik.Text = dt.Rows[0]["Baslik"].ToString();
					txtAciklama.Text = dt.Rows[0]["Aciklama"].ToString();
					txtUcret.Text = dt.Rows[0]["Fiyat"].ToString();
					txtKonum.Text = dt.Rows[0]["Konum"].ToString();
					cmbDurum.SelectedItem = dt.Rows[0]["Durum"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Veri yüklenirken hata: " + ex.Message);
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			try
			{
				string baslik = txtBaslik.Text.Trim();
				string aciklama = txtAciklama.Text.Trim();
				string konum = txtKonum.Text.Trim();
				string durum = cmbDurum.SelectedItem?.ToString();

				if (!decimal.TryParse(txtUcret.Text.Trim().Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal fiyat))
				{
					MessageBox.Show("Lütfen geçerli bir fiyat giriniz.");
					return;
				}

				VeritabaniYardimci db = new VeritabaniYardimci();
				string sorgu = @"
                    UPDATE Ilanlar
                    SET Baslik = @Baslik, 
                        Aciklama = @Aciklama, 
                        Fiyat = @Fiyat, 
                        Konum = @Konum, 
                        Durum = @Durum
                    WHERE IlanID = @IlanID";

				SqlParameter[] parametreler = {
					new SqlParameter("@Baslik", baslik),
					new SqlParameter("@Aciklama", aciklama),
					new SqlParameter("@Fiyat", fiyat),
					new SqlParameter("@Konum", konum),
					new SqlParameter("@Durum", durum),
					new SqlParameter("@IlanID", _ilanID)
				};

				int sonuc = db.ParametreliKomut(sorgu, parametreler);

				if (sonuc > 0)
				{
					MessageBox.Show("İlan başarıyla güncellendi.");
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
	}
}
