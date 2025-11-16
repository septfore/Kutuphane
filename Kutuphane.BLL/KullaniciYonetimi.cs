using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.DAL;
using Kutuphane.Entities;
using System.Data;


namespace Kutuphane.BLL
{
    public class GirisSonucu
    {
        public bool Basarili { get; set; }
        public string Mesaj { get; set; }
        public Kullanici Kullanici { get; set; }
    }
    public class KullaniciYonetimi
    {
        private readonly KullaniciDAL _kullaniciDal;
        public KullaniciYonetimi()
        {
            _kullaniciDal = new KullaniciDAL();
        }   
            
            public GirisSonucu GirisYap(string kullaniciAdi, string sifre)
            {
                var sonuc = new GirisSonucu();
                if(string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
                {
                    sonuc.Basarili = false;
                    sonuc.Mesaj = "Kullanıcı adı ve şifre boş olamaz.";
                    return sonuc;
                }
                var kullanici = _kullaniciDal.KullaniciAdiVeSifreAl(kullaniciAdi, sifre);
                if(kullanici == null)
                {
                    sonuc.Basarili = false;
                    sonuc.Mesaj = "Kullanıcı adı veya şifre yanlış.";
                    return sonuc;
                }
                sonuc.Basarili = true;
                sonuc.Kullanici = kullanici;
                sonuc.Mesaj = "Giriş başarılı.";
                return sonuc;
            }         
    }
}