using DersBilgileriV1.Classes;
using System.Collections.Generic;
namespace DersBilgileriV1.DataLayer
{
    class KategoriData
    {
        public static List<Kategori> Kategoriler { get; set; } = new List<Kategori>()
        {
            new Kategori()
            {
                Id = (int)KategoriEnum.Sayısal,
                Adi = "Sayısal Kategori"
            },
            new Kategori()
            {
                Id = (int)KategoriEnum.Sosyal,
                Adi = "Sosyal Kategori"
            }
        };
    }
}
