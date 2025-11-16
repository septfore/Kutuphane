using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Kutuphane.Entities;

namespace Kutuphane.DAL
{
    public class OgrenciDAL
    {
        public void OgrenciEkle(Ogrenci ogrenci)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO Ogrenciler (Ad, Soyad, Telefon, Eposta, KayitTarihi, Bolum) " +
                               "VALUES (@Ad, @Soyad, @Telefon, @Eposta, @KayitTarihi, @Bolum)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ad", ogrenci.Ad);
                    cmd.Parameters.AddWithValue("@Soyad", ogrenci.Soyad);
                    cmd.Parameters.AddWithValue("@Telefon", ogrenci.Telefon);
                    cmd.Parameters.AddWithValue("@Eposta", ogrenci.Eposta);
                    cmd.Parameters.AddWithValue("@KayitTarihi", ogrenci.KayitTarihi);
                    cmd.Parameters.AddWithValue("@Bolum", ogrenci.Bolum);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Ogrenci> OgrencileriGetir()
        {
            List<Ogrenci> liste = new List<Ogrenci>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM Ogrenciler";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    liste.Add(new Ogrenci
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Ad = dr["Ad"].ToString(),
                        Soyad = dr["Soyad"].ToString(),
                        Telefon = dr["Telefon"].ToString(),
                        Eposta = dr["Eposta"].ToString(),
                        KayitTarihi = Convert.ToDateTime(dr["KayitTarihi"])
                    });
                }
            }
            return liste;
        }
        public void OgrenciGuncelle(Ogrenci ogr)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE Ogrenciler SET Ad=@Ad, Soyad=@Soyad, Telefon=@Telefon, " +
                               "Eposta=@Eposta, KayitTarihi=@KayitTarihi WHERE Id=@Id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", ogr.Id);
                cmd.Parameters.AddWithValue("@Ad", ogr.Ad);
                cmd.Parameters.AddWithValue("@Soyad", ogr.Soyad);
                cmd.Parameters.AddWithValue("@Telefon", ogr.Telefon);
                cmd.Parameters.AddWithValue("@Eposta", ogr.Eposta);
                cmd.Parameters.AddWithValue("@KayitTarihi", ogr.KayitTarihi);
                cmd.ExecuteNonQuery();
            }
        }
        public void OgrenciSil(int id)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM Ogrenciler WHERE Id=@Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}