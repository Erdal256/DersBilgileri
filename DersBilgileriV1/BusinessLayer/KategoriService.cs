using DersBilgileriV1.Classes;
using DersBilgileriV1.DataAccessLayer;
using System.Collections.Generic;

namespace DersBilgileriV1.BusinessLayer
{
    class KategoriService
    {
        MemoryDataAccess dataAcces = new MemoryDataAccess();

        public List<Kategori> Get()
        {
            return dataAcces.GetKategoriler();
        }
    }
}
