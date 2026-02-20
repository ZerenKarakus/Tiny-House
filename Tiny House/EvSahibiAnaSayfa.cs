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
	public partial class EvSahibiAnaSayfa : Form
	{

		private int evSahibiID;


		public EvSahibiAnaSayfa()
		{
			InitializeComponent();
			evSahibiID = EvSahibiGiris.KullaniciBilgileri.EvSahibiID;

		}

		private void EvSahibiAnaSayfa_Load(object sender, EventArgs e)
		{

			using (SqlConnection conn = new SqlConnection("Server=LAPTOP-QCSD0KI9\\ZEREN ;Database=tinyHouse;Trusted_Connection=True;"))
			{
				conn.Open();
				string query = @"
                SELECT 
				(SELECT COUNT(*) FROM Ilanlar WHERE EvSahibiID = @ID) AS ToplamIlan,
				(SELECT COUNT(*) FROM Rezervasyonlar R JOIN Ilanlar I ON R.IlanID = I.IlanID WHERE I.EvSahibiID = @ID) AS ToplamRezervasyon,
				(SELECT ISNULL(SUM(O.Tutar),0) 
				 FROM Odemeler O 
				 JOIN Rezervasyonlar R ON O.RezervasyonID = R.RezervasyonID 
				 JOIN Ilanlar I ON R.IlanID = I.IlanID 
				 WHERE I.EvSahibiID = @ID AND O.IslemKodu = 'Odendi') AS ToplamGelir,
				(SELECT ISNULL(AVG(CAST(Y.Puan AS FLOAT)), 0) 
				 FROM Yorumlar Y 
				 JOIN Ilanlar I ON Y.IlanID = I.IlanID 
				 WHERE I.EvSahibiID = @ID) AS OrtalamaPuan";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@ID", evSahibiID);
				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					lblToplamIlan.Text = reader["ToplamIlan"].ToString();
					lblToplamRezervasyon.Text = reader["ToplamRezervasyon"].ToString();
					lblToplamGelir.Text = reader["ToplamGelir"].ToString() + " ₺";
					lblOrtalamaPuan.Text = reader["OrtalamaPuan"].ToString();
				}
			}
		}

		private void btnIlan_Click(object sender, EventArgs e)
		{
			try
			{
				//this.Hide(); // Form1'i gizle
				EvSahibiIlanYonetimi ilanForm = new EvSahibiIlanYonetimi();
				ilanForm.ShowDialog();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
			}
		}

		private void btnRezervasyon_Click(object sender, EventArgs e)
		{
			try
			{
				//this.Hide();
				EvSahibiRezYonetimi rezForm = new EvSahibiRezYonetimi();
				rezForm.ShowDialog();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
			}
		}

		private void btnYorumPuan_Click(object sender, EventArgs e)
		{
			try
			{
				//this.Hide();
				EvSahibiYorumVePuan yorumForm = new EvSahibiYorumVePuan();
				yorumForm.ShowDialog();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
			}
		}

		private void btnOdeme_Click(object sender, EventArgs e)
		{
			try
			{
				//this.Hide();
				EvSahibiOdemeBilgileri odemeForm = new EvSahibiOdemeBilgileri();
				odemeForm.ShowDialog();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
			}
		}
	}
}
