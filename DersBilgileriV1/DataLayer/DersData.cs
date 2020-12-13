using DersBilgileriV1.Classes;
using System.Collections.Generic;

namespace DersBilgileriV1.DataLayer
{
    static class DersData
    {
        public static List<Ders> Dersler { get; set; } = new List<Ders>()
        {
            new Ders()
            {
                Id = 1,
                Adi = "Matematik",
                KategoriId = (int)KategoriEnum.Sayısal,
                Icerik = "Calculus",
                Kredi = 5
            },
            new Ders()
            {
                Id = 2,
                Adi = "Biyoloji",
                KategoriId = (int)KategoriEnum.Sayısal,
                Icerik = "Virüsler",
                Kredi = 3
            },
            new Ders()
            {
                Id = 3,
                Adi = "Coğrafya",
                KategoriId = (int)KategoriEnum.Sosyal,
                Icerik = "Türkiye Coğrafyası",
                Kredi = 1
            }
        };
    }
}
