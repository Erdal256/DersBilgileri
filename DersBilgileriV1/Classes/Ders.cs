namespace DersBilgileriV1.Classes
{
    class Ders
    {
        #region Ders class'ında olması gereken tüm özellikler
        public int Id { get; set; }
        public string Adi { get; set; }
        public int KategoriId { get; set; }
        public string Icerik { get; set; }
        public byte Kredi { get; set; }
        #endregion

        #region Ders class'ında bizim ihtiyacımız olan tüm özellikler
        public string KategoriAdi { get; set; }
        #endregion
    }
}
