using DersBilgileriV1.Classes;
using DersBilgileriV1.DataAccessLayer;
using System.Collections.Generic;

namespace DersBilgileriV1.BusinessLayer
{
    class DersService
    {
        //private MemoryDataAccess dataAccess;
        private FileDataAccess dataAccess;
        public DersService(string derslerPath, string kategorilerPath)
        {
            dataAccess = new FileDataAccess(derslerPath, kategorilerPath);
        }
        public DersService()
        {
            //dataAccess = new MemoryDataAccess();
        }

        public List<Ders> Get()
        {
            var dersler = dataAccess.GetDersler();
            var kategoriler = dataAccess.GetKategoriler();
            foreach(var ders in dersler)
            {
                foreach(var kategori in kategoriler)
                {
                    if(ders.KategoriId == kategori.Id)
                    {
                        ders.KategoriAdi = kategori.Adi;
                        break;
                    }
                }
            }
            return dersler;
        }

        public void Add(Ders ders)
        {
            dataAccess.AddDers(ders);
        }
    }
}
