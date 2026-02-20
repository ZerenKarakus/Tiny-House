using System;
using System.Data;
using System.Data.SqlClient;

namespace TinyHouseProjesi
{
	public class VeritabaniYardimci
	{
		private string baglantiCumlesi = "Data Source=LAPTOP-QCSD0KI9\\ZEREN;Initial Catalog=tinyHouse;Integrated Security=True";

		public SqlConnection BaglantiOlustur()
		{
			return new SqlConnection(baglantiCumlesi);
		}

		// Parametresiz SELECT
		public DataTable VeriGetir(string sqlSorgu)
		{
			DataTable tablo = new DataTable();
			using (SqlConnection conn = BaglantiOlustur())
			{
				try
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand(sqlSorgu, conn);
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					adapter.Fill(tablo);
				}
				catch (Exception ex)
				{
					throw new Exception("Veri çekme hatası: " + ex.Message);
				}
			}
			return tablo;
		}

		// Parametreli SELECT
		public DataTable ParametreliVeriGetir(string sqlSorgu, SqlParameter[] parametreler)
		{
			DataTable tablo = new DataTable();
			using (SqlConnection conn = BaglantiOlustur())
			{
				try
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand(sqlSorgu, conn);
					cmd.Parameters.AddRange(parametreler);
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					adapter.Fill(tablo);
				}
				catch (Exception ex)
				{
					throw new Exception("Parametreli veri çekme hatası: " + ex.Message);
				}
			}
			return tablo;
		}

		// Parametreli INSERT / UPDATE / DELETE
		public int ParametreliKomut(string sqlSorgu, SqlParameter[] parametreler)
		{
			int sonuc = 0;
			using (SqlConnection conn = BaglantiOlustur())
			{
				try
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand(sqlSorgu, conn);
					cmd.Parameters.AddRange(parametreler);
					sonuc = cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					throw new Exception("Komut çalıştırma hatası: " + ex.Message);
				}
			}
			return sonuc;
		}
	}
}
