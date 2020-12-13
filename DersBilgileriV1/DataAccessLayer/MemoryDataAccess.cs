using DersBilgileriV1.Classes;
using DersBilgileriV1.DataLayer;
using System.Collections.Generic;
using System.Linq;

namespace DersBilgileriV1.DataAccessLayer
{
    class MemoryDataAccess
    {
        public List<Kategori> GetKategoriler()
        {
            return KategoriData.Kategoriler.ToList();
        }

        public List<Ders> GetDersler()
        {
            return DersData.Dersler.ToList();
        }

        public void AddDers(Ders ders)
        {
            var dersListesi = GetDersler();
            int yeniDersId = dersListesi.LastOrDefault().Id + 1;
            ders.Id = yeniDersId;
            DersData.Dersler.Add(ders);
        }

    }
}
