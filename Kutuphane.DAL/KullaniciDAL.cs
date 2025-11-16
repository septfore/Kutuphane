using Kutuphane.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DAL
{
    public class KullaniciDAL
    {
  

        private readonly string _baglanti = "Server=172.21.54.253;Database=26_132430048;Uid=26_132430048;Pwd=İnif123.;";
        public Kullanici KullaniciAdiVeSifreAl(string kullaniciAdi, string sifre)
        {
            Kullanici kullanici = null;
            using (MySqlConnection baglanti = new MySqlConnection(_baglanti))
            using (MySqlCommand komut = new MySqlCommand(@"SELECT Id, KullaniciAdi, Sifre, Rol 
                FROM Kullanicilar 
                WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre", baglanti))
            {
                komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@Sifre", sifre);
                try { baglanti.Open(); }
                catch (Exception ex) { throw new Exception("Veritabanı bağlantı hatası: " + ex.Message); }


                using (MySqlDataReader oku = komut.ExecuteReader())
                {
                    if(oku.Read())
                    {
                        kullanici = new Kullanici
                        {
                            Id = Convert.ToInt32(oku["Id"]),
                            KullaniciAdi = oku["KullaniciAdi"].ToString(),
                            Sifre = oku["Sifre"].ToString(),
                            Rol = oku["Rol"].ToString()
                        };
                    }
                }
            }
            return kullanici; //bulunamazsa null döner.
        }
      
    }
}
