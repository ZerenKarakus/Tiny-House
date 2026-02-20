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
	public partial class EvSahibiYorumVePuan : Form
	{
		private int evSahibiID;

		public EvSahibiYorumVePuan()
		{
			InitializeComponent();
			evSahibiID = EvSahibiGiris.KullaniciBilgileri.EvSahibiID;
		}

		private void EvSahibiYorumVePuan_Load(object sender, EventArgs e)
		{
			cmbPuanFiltre.Items.Add("Tümü");
			for (int i = 1; i <= 5; i++)
				cmbPuanFiltre.Items.Add(i);

			cmbPuanFiltre.SelectedIndex = 0;

			dtpBaslangic.Value = DateTime.Now.AddMonths(-6);
			dtpBitis.Value = DateTime.Now;

			YorumlariYukle();
			OrtalamaPuaniGoster();
		}

		private void YorumlariYukle(string filtreQuery = "", DateTime? baslangic = null, DateTime? bitis = null)
		{
			string connectionString = "Server=LAPTOP-QCSD0KI9\\ZEREN ;Database=tinyHouse;Trusted_Connection=True;";
			string query = $@"
			SELECT 
			Y.YorumID,
			K.Ad + ' ' + K.Soyad AS KiraciAdi,
			I.Baslik AS IlanBaslik,
			Y.Puan,
			Y.Yorum,
			Y.YorumTarihi
			FROM Yorumlar Y
			JOIN Ilanlar I ON Y.IlanID = I.IlanID
			JOIN Kullanicilar K ON Y.KiraciID = K.KullaniciID
			WHERE I.EvSahibiID = @EvSahibiID
			{filtreQuery}
			ORDER BY Y.YorumTarihi DESC";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@EvSahibiID", evSahibiID);

				// Tarih parametrelerini ekle
				if (baslangic.HasValue && bitis.HasValue)
				{
					cmd.Parameters.AddWithValue("@Baslangic", baslangic.Value);
					cmd.Parameters.AddWithValue("@Bitis", bitis.Value);
				}

				conn.Open();

				DataTable dt = new DataTable();
				dt.Load(cmd.ExecuteReader());

				dgvYorumlar.DataSource = dt;
			}
		}


		private void OrtalamaPuaniGoster()
		{
			string query = @"SELECT ISNULL(AVG(CAST(Y.Puan AS FLOAT)), 0) 
                             FROM Yorumlar Y
                             JOIN Ilanlar I ON Y.IlanID = I.IlanID
                             WHERE I.EvSahibiID = @EvSahibiID";

			using (SqlConnection conn = new SqlConnection("Server=LAPTOP-QCSD0KI9\\ZEREN ;Database=tinyHouse;Trusted_Connection=True;"))
			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@EvSahibiID", evSahibiID);
				conn.Open();

				double ortalama = Convert.ToDouble(cmd.ExecuteScalar());
				lblOrtalamaPuan.Text = "Ortalama Puan: " + ortalama.ToString("0.00");
			}
		}

		private void btnFiltrele_Click(object sender, EventArgs e)
		{
			string filtre = "";

			if (cmbPuanFiltre.SelectedIndex > 0)
			{
				int puan = cmbPuanFiltre.SelectedIndex;
				filtre += " AND Y.Puan = " + puan;
			}

			DateTime baslangic = dtpBaslangic.Value.Date;
			DateTime bitis = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);

			filtre += " AND Y.YorumTarihi BETWEEN @Baslangic AND @Bitis";

			// Tarihleri de parametre olarak gönder
			YorumlariYukle(filtreQuery: filtre, baslangic: baslangic, bitis: bitis);

			// Görüntü filtreleme (isteğe bağlı)
			foreach (DataGridViewRow row in dgvYorumlar.Rows)
			{
				if (row.DataBoundItem is DataRowView drv)
				{
					DateTime yorumTarihi = Convert.ToDateTime(drv["YorumTarihi"]);
					if (yorumTarihi < baslangic || yorumTarihi > bitis)
						row.Visible = false;
				}
			}
		}


		private void btnTumunuGoster_Click(object sender, EventArgs e)
		{
			YorumlariYukle();
		}
	}
}
