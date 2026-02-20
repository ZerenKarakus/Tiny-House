using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
	public partial class KiraciAnaSayfa : Form
	{
		//kullanacagimiz veritabani baglantisi
		string baglantiMetni = "Data Source=LAPTOP-QCSD0KI9\\ZEREN;Initial Catalog=tinyHouse;Integrated Security=True";

		public KiraciAnaSayfa()
		{
			InitializeComponent();
		}

		private void KiraciAnaSayfa_Load(object sender, EventArgs e)
		{
			enYuksekPuanliEv();
			this.dgvEnYuksekPuan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnYuksekPuan_CellContentClick);

		}

		//Ara butonuna bastiginda fitreler
		private void btnAra_Click(object sender, EventArgs e)
		{
			decimal minFiyat = 0;
			decimal maxFiyat = 999999;

			if (!decimal.TryParse(txtMinFiyat.Text, out minFiyat))
				minFiyat = 0;
			if (!decimal.TryParse(txtMaxFiyat.Text, out maxFiyat))
				maxFiyat = 999999;

			string query = @"SELECT IlanID, Baslik, Aciklama, Konum, kapasite, Fiyat
                            FROM Ilanlar    
                            WHERE Durum = 'Aktif'
                            AND ((Baslik LIKE @arama OR Aciklama LIKE @arama)
                            AND Fiyat BETWEEN @minFiyat AND @maxFiyat)
                            AND (@konum IS NULL OR Konum LIKE @konum)
                            AND (@kapasite IS NULL OR kapasite = @kapasite)
                            ORDER BY
                            Fiyat ASC;";

			try
			{
				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					using (SqlCommand komut = new SqlCommand(query, baglanti))
					{
						komut.Parameters.AddWithValue("@arama", "%" + txtArama.Text.Trim() + "%");
						komut.Parameters.AddWithValue("@minFiyat", minFiyat);
						komut.Parameters.AddWithValue("@maxFiyat", maxFiyat);
						komut.Parameters.AddWithValue("@kapasite", string.IsNullOrEmpty(cmbKapasite.Text) ? (object)DBNull.Value : cmbKapasite.Text);
						komut.Parameters.AddWithValue("@konum", string.IsNullOrEmpty(cmbIl.Text) ? (object)DBNull.Value : "%" + cmbIl.Text + "%");


						SqlDataAdapter da = new SqlDataAdapter(komut);
						DataTable dt = new DataTable();
						da.Fill(dt);

						dataGridViewEvListele.DataSource = dt;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz.", ex.Message);
			}

			dataGridViewEvListele.Columns["IlanID"].Visible = false;
		}


		private void dataGridViewEvListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow satir = dataGridViewEvListele.Rows[e.RowIndex];
				int IlanID = Convert.ToInt32(satir.Cells["IlanID"].Value);

				KiraciEvDetay detayFormu = new KiraciEvDetay(IlanID);
				detayFormu.ShowDialog();
			}
		}

		private void btnRezervasyon_Click(object sender, EventArgs e)
		{
			try
			{
				this.Hide(); // ana formu gizledik

				using (KiraciRezervasyonlari rezervasyon = new KiraciRezervasyonlari()) //yeni form olusturduk
					rezervasyon.ShowDialog(); // yeni formu actik

				this.Close(); // yeni form acildiktan sonra eski formu kapattik
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata olustu tekrar deneyizni!");
			}
		}

		private void btnOdeme_Click(object sender, EventArgs e)
		{
			try
			{
				this.Hide(); // ana formu gizledik

				using (KiraciOdeme odemelerim = new KiraciOdeme()) //yeni form olusturduk
					odemelerim.ShowDialog(); // yeni formu actik

				this.Close(); // yeni form acildiktan sonra eski formu kapattik
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata olustu tekrar deneyizni!");
			}
		}

		private void dgvEnYuksekPuan_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow satir = dgvEnYuksekPuan.Rows[e.RowIndex];
				int IlanID = Convert.ToInt32(satir.Cells["IlanID"].Value);

				this.Hide();
				using (KiraciEvDetay detayFormu = new KiraciEvDetay(IlanID))
					detayFormu.ShowDialog();

				this.Close();
			}
		}

		private void enYuksekPuanliEv()
		{
			try
			{
				string query = @"SELECT TOP 1 i.IlanID, i.Baslik, i.Aciklama, i.Konum, i.kapasite, i.Fiyat,
								ISNULL(AVG(CAST(y.Puan AS FLOAT)), 0) AS OrtalamaPuan
								FROM Ilanlar i
								LEFT JOIN Yorumlar y ON i.IlanID = y.IlanID
								WHERE i.Durum = 'Aktif'
								GROUP BY i.IlanID, i.Baslik, i.Aciklama, i.Konum, i.kapasite, i.Fiyat
								ORDER BY OrtalamaPuan DESC;";

				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					using (SqlCommand komut = new SqlCommand(query, baglanti))
					{
						SqlDataAdapter da = new SqlDataAdapter(komut);
						DataTable dt = new DataTable();
						da.Fill(dt);

						dgvEnYuksekPuan.AutoGenerateColumns = true;
						dgvEnYuksekPuan.DataSource = dt;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu: " + ex.Message);
			}
		}
	}
}
