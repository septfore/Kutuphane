using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.DAL;
using Kutuphane.Entities;

namespace Kutuphane.BLL
{
    public class OgrenciYonetimi
    {
        private readonly OgrenciDAL ogrenciDal = new OgrenciDAL();
        public void OgrenciEkle(Ogrenci ogrenci)
        {
            if (string.IsNullOrWhiteSpace(ogrenci.Ad) || string.IsNullOrWhiteSpace(ogrenci.Soyad))
                throw new Exception("Öğrenci adı ve soyadı boş olamaz!");
           
            ogrenciDal.OgrenciEkle(ogrenci);
        }
        public List<Ogrenci> OgrencileriGetir()
        {
            return ogrenciDal.OgrencileriGetir();
        }
        public void OgrenciGuncelle(Ogrenci ogrenci)
        {
            if (ogrenci.Id <= 0)
                throw new Exception("Geçersiz öğrenci ID'si!");                     
            ogrenciDal.OgrenciGuncelle(ogrenci);
        }   
        public void OgrenciSil(int ogrenciId)
        {
            if (ogrenciId <= 0)
                throw new Exception("Geçersiz öğrenci ID'si!");
            ogrenciDal.OgrenciSil(ogrenciId);
        }
    }
}
