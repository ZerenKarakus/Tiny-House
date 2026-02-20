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
	public partial class KiraciYorumVePuan : Form
	{
		private int rezervasyonID;
		private int ilanID;

		//kullanacagimiz veritabani baglantisi
		string baglantiMetni = "Data Source=LAPTOP-QCSD0KI9\\ZEREN;Initial Catalog=tinyHouse;Integrated Security=True";

		public KiraciYorumVePuan(int rezervasyonID, int ilanID)
		{
			InitializeComponent();
			this.rezervasyonID = rezervasyonID;
			this.ilanID = ilanID;

			nupPuan.Minimum = 1;
			nupPuan.Maximum = 5;
		}


		private void btnEkle_Click(object sender, EventArgs e)
		{
			try
			{
				string yorum = rtxtYorum.Text.Trim();
				int puan = (int)nupPuan.Value;
				int kiraciID = KullaniciBilgileri.KiraciID;

				if (string.IsNullOrWhiteSpace(yorum))
				{
					MessageBox.Show("Yorum alanını boş bırakmayınız.");
					return;
				}

				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					baglanti.Open();

					string kontrolQuery = "SELECT COUNT(*) FROM Yorumlar WHERE KiraciID = @kiraciID AND IlanID = @ilanId";

					using (SqlCommand kontrolKomut = new SqlCommand(kontrolQuery, baglanti))
					{
						kontrolKomut.Parameters.AddWithValue("@kiraciID", kiraciID);
						kontrolKomut.Parameters.AddWithValue("@ilanID", ilanID);

						int mevcutYorum = (int)kontrolKomut.ExecuteScalar();

						if (mevcutYorum > 0)
						{
							MessageBox.Show("Bu eve önceden bir yorum yapılmış. Birden fazla yorum yapamazsınız.");
							return;
						}
					}

					string query = @"INSERT INTO Yorumlar (KiraciID, IlanID, Yorum, Puan, YorumTarihi)
                                        VALUES (@kiraciID, @evID, @yorum, @puan, @yorumTarihi)";

					using (SqlCommand komut = new SqlCommand(query, baglanti))
					{
						komut.Parameters.AddWithValue("@KiraciID", kiraciID);
						komut.Parameters.AddWithValue("@evID", ilanID);
						komut.Parameters.AddWithValue("@Yorum", yorum);
						komut.Parameters.AddWithValue("@Puan", puan);
						komut.Parameters.AddWithValue("@YorumTarihi", DateTime.Now);

						komut.ExecuteNonQuery();
					}
				}

				MessageBox.Show("Yorum ve puanınız eklenmiştir.");
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz!", ex.Message);
			}
		}


		private void btnGeri_Click(object sender, EventArgs e)
		{
			// Daha önce açılmış bir KiraciAnaSayfa formu var mı?
			foreach (Form form in Application.OpenForms)
			{
				if (form is KiraciAnaSayfa)
				{
					form.Show();
					this.Close();
					return;
				}
			}

			// Yoksa yeni oluştur
			KiraciAnaSayfa yeniForm = new KiraciAnaSayfa();
			yeniForm.Show();
			this.Close();
		}


		private void btnCikis_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
