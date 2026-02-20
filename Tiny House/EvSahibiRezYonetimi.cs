using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHouseProjesi;

namespace TinyHouseProjesi
{
	public partial class EvSahibiRezYonetimi : Form
	{
		private int evSahibiID;
		private string connectionString = "Server=LAPTOP-QCSD0KI9\\ZEREN;Database=tinyHouse;Trusted_Connection=True;";

		public EvSahibiRezYonetimi()
		{
			InitializeComponent();
			evSahibiID = EvSahibiGiris.KullaniciBilgileri.EvSahibiID;
		}

		private void EvSahibiRezYonetimi_Load(object sender, EventArgs e)
		{
			cmbDurum.Items.Clear();
			cmbDurum.Items.AddRange(new string[] { "Onaylandi", "Reddedildi" });
			cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbDurum.SelectedIndex = -1; // Başlangıçta seçim yok
			RezervasyonlariYukle();
		}


		private void RezervasyonlariYukle()
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand("sp_EvSahibiRezervasyonlariGetir", conn))
			{
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@EvSahibiID", evSahibiID);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dgvRezervasyonlar.DataSource = dt;
			}
		}

		private void dgvRezervasyonlar_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvRezervasyonlar.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dgvRezervasyonlar.SelectedRows[0];
				txtRezID.Text = row.Cells["RezervasyonID"].Value.ToString();
				txtKiraci.Text = row.Cells["Kiraci"].Value.ToString();
				txtIlan.Text = row.Cells["Ilan"].Value.ToString();
				txtTarih.Text = $"{Convert.ToDateTime(row.Cells["BaslangicTarihi"].Value):dd.MM.yyyy} - {Convert.ToDateTime(row.Cells["BitisTarihi"].Value):dd.MM.yyyy}";
				txtOdemeDurumu.Text = row.Cells["OdemeDurumu"].Value.ToString();

				string mevcutDurum = row.Cells["Durum"].Value.ToString();
				if (cmbDurum.Items.Contains(mevcutDurum))
					cmbDurum.SelectedItem = mevcutDurum;
				else
					cmbDurum.SelectedIndex = -1;
			}
		}


		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtRezID.Text) || cmbDurum.SelectedItem == null)
			{
				MessageBox.Show("Lütfen bir rezervasyon seçin ve durum seçin.");
				return;
			}

			string query = "UPDATE Rezervasyonlar SET Durum = @Durum WHERE RezervasyonID = @ID";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@Durum", cmbDurum.SelectedItem.ToString());
				cmd.Parameters.AddWithValue("@ID", txtRezID.Text);
				conn.Open();
				cmd.ExecuteNonQuery();
				MessageBox.Show("Rezervasyon durumu güncellendi.");
				RezervasyonlariYukle();
			}
		}
	}
}
