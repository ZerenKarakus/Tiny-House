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
	public partial class KiraciOdeme : Form
	{
		//kullanacagimiz veritabani baglantisi
		string baglantiMetni = "Data Source=LAPTOP-QCSD0KI9\\ZEREN;Initial Catalog=tinyHouse;Integrated Security=True";

		private int secilenRezervasyonID;
		private decimal secilenTutar;
		public KiraciOdeme()
		{
			InitializeComponent();
			listele();
		}

		private void rezervasyonDetayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult sonuc = MessageBox.Show($"Toplam tutar: {secilenTutar}\n Ödeme yapmak istiyor musunuz?", "Ödeme Onayı", MessageBoxButtons.YesNo);

				if (sonuc == DialogResult.Yes)
				{
					using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
					{
						baglanti.Open();

						SqlTransaction trans = baglanti.BeginTransaction();

						try
						{
							string odemeQuery = @"INSERT INTO Odemeler (RezervasyonID, Tutar, OdemeTarihi, IslemKodu)
                                                  VALUES (@rezervasyonID, @tutar, @odemeTarihi, @durum)";

							using (SqlCommand komut = new SqlCommand(odemeQuery, baglanti, trans))
							{
								komut.Parameters.AddWithValue("@rezervasyonID", secilenRezervasyonID);
								komut.Parameters.AddWithValue("@tutar", secilenTutar);
								komut.Parameters.AddWithValue("@odemeTarihi", DateTime.Now);
								komut.Parameters.AddWithValue("@durum", "Odendi");

								komut.ExecuteNonQuery();
							}

							string rezervasyonQuery = @"UPDATE Rezervasyonlar
                                                    SET OdemeDurumu = 'Odendi'
                                                    WHERE RezervasyonID = @rezervasyonID";

							using (SqlCommand komut2 = new SqlCommand(rezervasyonQuery, baglanti, trans))
							{
								komut2.Parameters.AddWithValue("@rezervasyonID", secilenRezervasyonID);
								komut2.ExecuteNonQuery();
							}

							trans.Commit();
							MessageBox.Show("Ödeme yapıldı.");
							listele();

							string emailQuery = @"SELECT K.Eposta FROM Rezervasyonlar R
                                                    JOIN Kullanicilar K ON R.KiraciID = K.KullaniciID 
                                                    WHERE R.RezervasyonID = @rezervasyonID";

							using (SqlCommand emailKomut = new SqlCommand(emailQuery, baglanti))
							{
								emailKomut.Parameters.AddWithValue("@rezervasyonID", secilenRezervasyonID);
								string email = emailKomut.ExecuteScalar()?.ToString();

								if (!string.IsNullOrEmpty(email))
									mailGonder(email, secilenTutar);
							}
						}
						catch (Exception ex)
						{
							trans.Rollback();
							MessageBox.Show("Ödeme yapılamadı.", ex.Message);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bir hata oluştu tekrar deneyiniz.", ex.Message);
			}
		}

		private void listele()
		{
			try
			{
				dgvOdeme.AutoGenerateColumns = true;

				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					string query = @"SELECT R.IlanID, R.RezervasyonID, R.BaslangicTarihi, R.BitisTarihi, R.OdemeDurumu, DATEDIFF(DAY, R.BaslangicTarihi, R.BitisTarihi) * E.Fiyat AS tutar
                                     FROM Rezervasyonlar R JOIN Ilanlar E ON R.IlanID = E.IlanId 
                                     WHERE R.OdemeDurumu = 'Bekleniyor'"; // bunu ekle tabloyu düzelttikten sonra JOIN tblKiraci K ON R.kiraciID = K.kiraciID 

					using (SqlCommand komut = new SqlCommand(query, baglanti))
					{
						SqlDataAdapter da = new SqlDataAdapter(komut);
						DataTable dt = new DataTable();
						da.Fill(dt);
						dgvOdeme.DataSource = null;
						dgvOdeme.DataSource = dt;

						dgvOdeme.Columns["RezervasyonID"].Visible = false;
						dgvOdeme.Columns["IlanID"].Visible = false;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz.", ex.Message);
			}
		}


		private void dgvOdeme_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
				{
					dgvOdeme.ClearSelection();
					dgvOdeme.Rows[e.RowIndex].Selected = true;

					DataGridViewRow satir = dgvOdeme.Rows[e.RowIndex];
					string durum = satir.Cells["OdemeDurumu"].Value.ToString();

					if (durum == "Bekleniyor")
					{
						secilenRezervasyonID = Convert.ToInt32(satir.Cells["RezervasyonID"].Value);
						secilenTutar = Convert.ToDecimal(satir.Cells["Tutar"].Value);

						contextMenuStrip1.Tag = dgvOdeme;

						contextMenuStrip1.Show(Cursor.Position);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz.", ex.Message);
			}
		}

		private void rezervasyonDetayToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				if (contextMenuStrip1.Tag is DataGridView aktifGrid)
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

		private void mailGonder(string aliciEmail, decimal tutar)
		{
			try
			{
				string smtpServer = "smtp.gmail.com";
				int smtpPort = 587;
				string smtpUser = "zueproje@gmail.com";
				string smtpPass = "ehws knlc mobj zbka";

				MailMessage mail = new MailMessage();
				SmtpClient smtpClient = new SmtpClient();

				mail.From = new MailAddress(smtpUser);
				mail.To.Add(aliciEmail);
				mail.Subject = "TinyHouse Ödeme Onayı";
				mail.Body = $"{tutar}₺ tutarındaki ödemeniz başarıyla alınmıştır.";

				smtpClient.Host = smtpServer;
				smtpClient.Port = smtpPort;
				smtpClient.Credentials = new NetworkCredential(smtpUser, smtpPass);
				smtpClient.EnableSsl = true;

				smtpClient.Send(mail);
				MessageBox.Show("Ödeme onay e-postası gönderildi.");
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