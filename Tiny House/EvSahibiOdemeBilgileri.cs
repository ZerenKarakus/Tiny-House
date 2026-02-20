using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Printing;
using System.Drawing;
using System.Xml.Linq;
using TinyHouseProjesi;


namespace TinyHouseProjesi
{
	public partial class EvSahibiOdemeBilgileri : Form
	{
		private const int V = 18;
		private int evSahibiID;

		public EvSahibiOdemeBilgileri()
		{
			InitializeComponent();
			evSahibiID = EvSahibiGiris.KullaniciBilgileri.EvSahibiID;
		}

		private void EvSahibiOdemeBilgileri_Load(object sender, EventArgs e)
		{
			dtpBaslangic.Value = DateTime.Today.AddMonths(-1);
			dtpBitis.Value = DateTime.Today;
			OdemeleriYukle();
		}

		private void OdemeleriYukle()
		{
			string connectionString = "Server=LAPTOP-QCSD0KI9\\ZEREN;Database=tinyHouse;Trusted_Connection=True;";
			string query = @"
                SELECT 
                    i.Baslik AS [Ilan],
                    k.Ad + ' ' + k.Soyad AS [Kiraci],
                    o.Tutar,
                    o.OdemeTarihi,
                    o.OdemeYontemi,
                    o.IslemKodu,
                    r.RezervasyonTarihi,
                    r.OdemeDurumu
                FROM Odemeler o
                INNER JOIN Rezervasyonlar r ON o.RezervasyonID = r.RezervasyonID
                INNER JOIN Ilanlar i ON r.IlanID = i.IlanID
                INNER JOIN Kullanicilar k ON r.KiraciID = k.KullaniciID
                WHERE i.EvSahibiID = @EvSahibiID
                AND o.OdemeTarihi BETWEEN @Baslangic AND @Bitis
                ORDER BY o.OdemeTarihi DESC";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@EvSahibiID", evSahibiID);
				cmd.Parameters.AddWithValue("@Baslangic", dtpBaslangic.Value.Date);
				cmd.Parameters.AddWithValue("@Bitis", dtpBitis.Value.Date.AddDays(1).AddSeconds(-1));

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				dgvOdemeGecmisi.DataSource = dt;

				decimal toplam = 0;
				foreach (DataRow row in dt.Rows)
				{
					toplam += Convert.ToDecimal(row["Tutar"]);
				}
				lblToplamGelir.Text = $"Toplam Gelir: {toplam:C2}";
			}
		}

		private void btnFiltrele_Click(object sender, EventArgs e)
		{
			OdemeleriYukle();
		}

		private void btnPDFOlustur_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgvOdemeGecmisi.Rows.Count == 0)
				{
					MessageBox.Show("Tabloda veri yok.");
					return;
				}

				// Masaüstüne PDF dosyasını oluşturacak yol
				string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				string dosyaAdi = $"OdemeRaporu_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
				string dosyaYolu = Path.Combine(masaustuYolu, dosyaAdi);

				// PDF belgesi ayarları
				Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
				PdfWriter.GetInstance(pdfDoc, new FileStream(dosyaYolu, FileMode.Create));
				pdfDoc.Open();

				// Başlık (Arial yerine Helvetica kullanılıyor)
				iTextSharp.text.Font baslikFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 18);
				iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("Ödeme Raporu", baslikFont)
				{
					Alignment = iTextSharp.text.Element.ALIGN_CENTER,
					SpacingAfter = 20f
				};

				pdfDoc.Add(title);

				// PDF tablo (DataGridView'deki sütun sayısı kadar)
				PdfPTable pdfTable = new PdfPTable(dgvOdemeGecmisi.Columns.Count);
				pdfTable.WidthPercentage = 100;

				// Sütun başlıkları
				foreach (DataGridViewColumn column in dgvOdemeGecmisi.Columns)
				{
					PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
					{
						BackgroundColor = BaseColor.LIGHT_GRAY
					};
					pdfTable.AddCell(cell);
				}

				// Satır verileri
				foreach (DataGridViewRow row in dgvOdemeGecmisi.Rows)
				{
					if (row.IsNewRow) continue;

					foreach (DataGridViewCell cell in row.Cells)
					{
						pdfTable.AddCell(cell.Value?.ToString() ?? "");
					}
				}

				pdfDoc.Add(pdfTable);
				pdfDoc.Close();

				MessageBox.Show($"PDF başarıyla oluşturuldu:\n{dosyaYolu}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("PDF oluşturulurken hata oluştu:\n" + ex.Message);
			}
		}
	}
}
