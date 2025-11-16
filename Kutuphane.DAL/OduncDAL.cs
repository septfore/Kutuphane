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
    public class OduncDAL
    {
        public void OduncEkle(Odunc odunc)
        {
            using (MySqlConnection conn = new MySqlConnection("your_connection_string"))
            {
                conn.Open();
                string query = "INSERT INTO Odunc (OgrenciId, KitapId, OduncTarihi, TeslimTarihi IadeTarihi) VALUES (@OgrenciId, @KitapId, @OduncTarihi, @TeslimTarihi @IadeTarihi)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UyeID", odunc.OgrenciId);
                    cmd.Parameters.AddWithValue("@KitapID", odunc.KitapId);
                    cmd.Parameters.AddWithValue("@OduncTarihi", odunc.OduncTarihi);
                    cmd.Parameters.AddWithValue("@IadeTarihi", odunc.IadeTarihi);
                    cmd.Parameters.AddWithValue("@TeslimTarihi", odunc.TeslimTarihi);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Odunc> OduncListele()
        {
            List<Odunc> oduncListesi = new List<Odunc>();
            using (MySqlConnection conn = new MySqlConnection("your_connection_string"))
            {
                conn.Open();
                string query = "SELECT * FROM Odunc";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Odunc odunc = new Odunc
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                OgrenciId = Convert.ToInt32(reader["OgrenciId"]),
                                KitapId = Convert.ToInt32(reader["KitapId"]),
                                OduncTarihi = Convert.ToDateTime(reader["OduncTarihi"]),
                                IadeTarihi = Convert.ToDateTime(reader["IadeTarihi"]),
                                TeslimTarihi = reader["TeslimTarihi"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["TeslimTarihi"])
                            };
                            oduncListesi.Add(odunc);
                        }
                    }
                }
            }
            return oduncListesi;
        }
        public void IadeEt(int id, DateTime iadeTarihi)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE Oduncler SET IadeTarihi=@IadeTarihi WHERE Id=@Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IadeTarihi", iadeTarihi);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
        
    }
}