using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.DAL;
using Kutuphane.Entities;

namespace Kutuphane.BLL
{
    public class KitapYonetimi
    {
        private readonly KitapDAL _kitapDal;
        public KitapYonetimi()
        {
            _kitapDal = new KitapDAL();
        }
       public List<Kitap> KitapAra(string kitapAdi) //çalışıyor
        {
            if(string.IsNullOrWhiteSpace(kitapAdi))
            {
                return new List<Kitap>();
            }
            return _kitapDal.KitapAra(kitapAdi.Trim());
        }
        public List<Kitap> TumKitaplariGetir()
        {
            return _kitapDal.TumKitaplariGetir();
        }
    }
}
