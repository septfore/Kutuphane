using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Kutuphane.Entities;
using System.Data;

namespace Kutuphane.DAL
{
    public class KitapDAL
    {
        public List<Kitap> KitapAra(string kitapAdi) //çalışıyor
        {
            List<Kitap> kitaplar = new List<Kitap>();
            using(var baglanti = DatabaseHelper.GetConnection())
            {
                //baglanti.Open();
                string sorgu = @"SELECT Id, KitapAdi, Yazar, Yayinevi, BasimYili, StokAdedi, Turu, OduncDurumu FROM Kitaplar WHERE KitapAdi LIKE @KitapAdi";
                using(var komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@KitapAdi", "%" + kitapAdi + "%");
                    using (var oku = komut.ExecuteReader())
                    {
                        while(oku.Read())
                        {
                            Kitap k = new Kitap
                            {
                                Id = oku.GetInt32("Id"),
                                KitapAdi = oku.GetString("KitapAdi"),
                                Yazar = oku.IsDBNull(oku.GetOrdinal("Yazar")) ? "" : oku.GetString("Yazar"),
                                YayinEvi = oku.IsDBNull(oku.GetOrdinal("YayinEvi")) ? "" : oku.GetString("YayinEvi"),
                                BasimYili = oku.IsDBNull(oku.GetOrdinal("BasimYili")) ? 0 : oku.GetInt32("BasimYili"),
                                StokAdedi = oku.IsDBNull(oku.GetOrdinal("StokAdedi")) ? 0 : oku.GetInt32("StokAdedi"),
                                Turu = oku.IsDBNull(oku.GetOrdinal("Turu")) ? "" : oku.GetString("Turu"),
                                OduncDurumu = oku.GetBoolean("OduncDurumu")
                            };
                            kitaplar.Add(k);
                        }
                    }
                }
            }
            return kitaplar;
        }
        public List<Kitap> TumKitaplariGetir() //çalışıyor
        {
            List<Kitap> kitaplar = new List<Kitap>();
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = "SELECT Id, KitapAdi, Yazar, Yayinevi, BasimYili, StokAdedi, Turu, OduncDurumu FROM Kitaplar";
                using (var komut = new MySqlCommand(sorgu, baglanti))
                {
                    using (var oku = komut.ExecuteReader())
                    {
                        while (oku.Read())
                        {
                            Kitap k = new Kitap
                            {
                                Id = oku.GetInt32("Id"),
                                KitapAdi = oku.GetString("KitapAdi"),
                                Yazar = oku.IsDBNull(oku.GetOrdinal("Yazar")) ? "" : oku.GetString("Yazar"),
                                YayinEvi = oku.IsDBNull(oku.GetOrdinal("YayinEvi")) ? "" : oku.GetString("YayinEvi"),
                                BasimYili = oku.IsDBNull(oku.GetOrdinal("BasimYili")) ? 0 : oku.GetInt32("BasimYili"),
                                StokAdedi = oku.IsDBNull(oku.GetOrdinal("StokAdedi")) ? 0 : oku.GetInt32("StokAdedi"),
                                Turu = oku.IsDBNull(oku.GetOrdinal("Turu")) ? "" : oku.GetString("Turu"),
                                OduncDurumu = oku.GetBoolean("OduncDurumu")
                            };
                            kitaplar.Add(k);
                        }
                    }
                }
            }
            return kitaplar;
        }
        public void KitapEkle(Kitap kitap)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO Kitaplar (ISBN, Ad, Yazar, YayinEvi, BasimYili, StokAdedi, Turu) " +
                               "VALUES (@ISBN, @Ad, @Yazar, @YayinEvi, @BasimYili, @StokAdedi, @Turu)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@KitapAdi", kitap.KitapAdi);
                    cmd.Parameters.AddWithValue("@Yazar", kitap.Yazar);
                    cmd.Parameters.AddWithValue("@YayinEvi", kitap.YayinEvi);
                    cmd.Parameters.AddWithValue("@BasimYili", kitap.BasimYili);
                    cmd.Parameters.AddWithValue("@StokAdedi", kitap.StokAdedi);
                    cmd.Parameters.AddWithValue("@Turu", kitap.Turu);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }      
}