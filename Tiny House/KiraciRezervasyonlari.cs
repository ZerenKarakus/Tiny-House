using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyHouseProjesi;

namespace TinyHouseProjesi
{
	public partial class KiraciRezervasyonlari : Form
	{
		//kullanacagimiz veritabani baglantisi
		string baglantiMetni = "Data Source=LAPTOP-QCSD0KI9\\ZEREN;Initial Catalog=tinyHouse;Integrated Security=True";

		public KiraciRezervasyonlari()
		{
			InitializeComponent();
			rezervasyonGoster();
		}

		private void rezervasyonGoster()
		{
			try
			{

				int kiraciID = KullaniciBilgileri.KiraciID;
				string bugunTarihi = DateTime.Now.ToString("yyyy-MM-dd");

				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					baglanti.Open();

					SqlDataAdapter daOnaylanmis = new SqlDataAdapter(
						@"SELECT R.RezervasyonID, R.IlanID, E.Baslik, R.BaslangicTarihi, R.BitisTarihi, R.Durum
                      FROM Rezervasyonlar R INNER JOIN Ilanlar E ON R.IlanID = E.IlanID
                      WHERE R.kiraciID = @kiraciID AND R.durum = 'Onaylandi' AND R.BitisTarihi >= @bugunTarihi", baglanti);

					daOnaylanmis.SelectCommand.Parameters.AddWithValue("@kiraciID", kiraciID);
					daOnaylanmis.SelectCommand.Parameters.AddWithValue("@bugunTarihi", bugunTarihi);

					DataTable dtOnaylanmiş = new DataTable();
					daOnaylanmis.Fill(dtOnaylanmiş);
					dgvOnaylanmis.DataSource = dtOnaylanmiş;

					SqlDataAdapter daOnaylanmamis = new SqlDataAdapter(
						@"SELECT R.RezervasyonID, R.IlanID, E.Baslik, R.BaslangicTarihi, R.BitisTarihi, R.Durum
                      FROM Rezervasyonlar R INNER JOIN Ilanlar E ON R.IlanID = E.IlanID
                      WHERE R.kiraciId = @kiraciID AND R.Durum = 'Beklemede'", baglanti);

					daOnaylanmamis.SelectCommand.Parameters.AddWithValue("@kiraciID", kiraciID);

					DataTable dtOnaylanmamis = new DataTable();
					daOnaylanmamis.Fill(dtOnaylanmamis);
					dgvOnayBekleyen.DataSource = dtOnaylanmamis;

					SqlDataAdapter daEski = new SqlDataAdapter(
						@"SELECT R.RezervasyonID, R.IlanID, E.Baslik, R.BaslangicTarihi, R.BitisTarihi, R.Durum
                      FROM Rezervasyonlar R INNER JOIN Ilanlar E ON R.IlanID = E.IlanID
                      WHERE R.kiraciID = @kiraciID AND R.durum = 'Onaylandi' AND R.BitisTarihi < @bugun", baglanti);

					daEski.SelectCommand.Parameters.AddWithValue("@kiraciID", kiraciID);
					daEski.SelectCommand.Parameters.AddWithValue("@bugun", bugunTarihi);

					DataTable dtEski = new DataTable();
					daEski.Fill(dtEski);
					dgvGecmis.DataSource = dtEski;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz.", ex.Message);
			}
		}

		private void dgvOnaylanmis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
			{
				dgvOnaylanmis.ClearSelection();
				dgvOnaylanmis.Rows[e.RowIndex].Selected = true;
				ctxtMenuRezervasyon.Show(Cursor.Position);
				ctxtMenuRezervasyon.Tag = dgvOnaylanmis;
			}
		}

		private void detayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (ctxtMenuRezervasyon.Tag is DataGridView aktifGrid)
				{
					var satir = aktifGrid.SelectedRows[0];
					int evID = Convert.ToInt32(satir.Cells["IlanID"].Value);

					this.Hide();
					using (KiraciEvDetay detay = new KiraciEvDetay(evID))
						detay.ShowDialog();
					this.Show();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz.", ex.Message);
			}
		}

		private void iPTALToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (ctxtMenuRezervasyon.Tag is DataGridView aktifGrid)
				{
					var satir = aktifGrid.SelectedRows[0];
					int rezervasyonID = Convert.ToInt32(satir.Cells["RezervasyonID"].Value);
					string durum = satir.Cells["Durum"].Value.ToString();

					if (durum == "Onaylandi" || durum == "Beklemede")
					{
						DialogResult sonuc = MessageBox.Show("Rezervasyonu iptal etmek istiyor musunuz?", "İptal onayı.", MessageBoxButtons.YesNo);
						if (sonuc == DialogResult.Yes)
						{
							iptalEt(rezervasyonID);
							rezervasyonGoster();
						}

					}
					else
					{
						MessageBox.Show("Geçmiş rezervasyonlar iptal edilemez.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz.", ex.Message);
			}
		}

		private void dgvOnayBekleyen_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
				{
					dgvOnayBekleyen.ClearSelection();
					dgvOnayBekleyen.Rows[e.RowIndex].Selected = true;
					ctxtMenuRezervasyon.Show(Cursor.Position);
					ctxtMenuRezervasyon.Tag = dgvOnayBekleyen;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz.", ex.Message);
			}
		}

		private void dgvGecmis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
				{
					dgvGecmis.ClearSelection();
					dgvGecmis.Rows[e.RowIndex].Selected = true;
					ctxtMenuRezervasyon.Show(Cursor.Position);
					ctxtMenuRezervasyon.Tag = dgvGecmis;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz.", ex.Message);
			}
		}

		private void iptalEt(int rezervasyonID)
		{
			try
			{
				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					string query = "UPDATE Rezervasyonlar SET durum = 'Iptal' WHERE RezervasyonID = @rezervasyonID";

					using (SqlCommand komut = new SqlCommand(query, baglanti))
					{
						komut.Parameters.AddWithValue("@rezervasyonID", rezervasyonID);

						baglanti.Open();

						komut.ExecuteNonQuery();
						MessageBox.Show("Rezervasyon iptal edildi.");
					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz.", ex.Message);
			}
		}


		private void yorumYapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (ctxtMenuRezervasyon.Tag is DataGridView aktifGrid)
				{
					if (aktifGrid == dgvGecmis)
					{
						var satir = aktifGrid.SelectedRows[0];
						int rezervasyonID = Convert.ToInt32(satir.Cells["RezervasyonID"].Value);
						int evID = Convert.ToInt32(satir.Cells["IlanID"].Value);

						this.Hide();
						using (KiraciYorumVePuan yorum = new KiraciYorumVePuan(rezervasyonID, evID))
							yorum.ShowDialog();
						this.Show();
					}
					else
					{
						MessageBox.Show("Sadece geçmiş rezervasyonlara yorum yapılabilir.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz.", ex.Message);
			}
		}

		private void btnGeri_Click(object sender, EventArgs e)
		{
			this.Hide(); // Formu gizle
			using (KiraciAnaSayfa yeniForm = new KiraciAnaSayfa())
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
}
