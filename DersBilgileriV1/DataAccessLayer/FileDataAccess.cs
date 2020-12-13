using DersBilgileriV1.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DersBilgileriV1.DataAccessLayer
{
    class FileDataAccess
    {
        private readonly string _derslerPath;
        private readonly string _kategorilerPath;

        public FileDataAccess(string derslerPath, string kategorilerPath)
        {
            _derslerPath = derslerPath;
            _kategorilerPath = kategorilerPath;
        }

        public List<Kategori> GetKategoriler()
        {
            List<Kategori> kategoriler = new List<Kategori>();
            string line;
            string[] values;
            Kategori kategori;
            StreamReader reader = new StreamReader(_kategorilerPath, Encoding.UTF8);
            while ((line = reader.ReadLine()) != null)
            {
                values = line.Split(';');
                kategori = new Kategori()
                {
                    Id = Convert.ToInt32(values[0]),
                    Adi = values[1]
                };
                kategoriler.Add(kategori);
            }
            reader.Close();
            return kategoriler;
        }

        public List<Ders> GetDersler()
        {
            List<Ders> dersler = new List<Ders>();
            Ders ders;
            string[] values;
            FileInfo info = new FileInfo(_derslerPath);
            StreamReader reader = info.OpenText(); // opens with UTF8
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                values = line.Split(';');
                ders = new Ders()
                {
                    Id = Convert.ToInt32(values[0]),
                    Adi = values[1],
                    KategoriId = Convert.ToInt32(values[2]),
                    Icerik = values[3],
                    Kredi = Convert.ToByte(values[4])
                };
                dersler.Add(ders);
            }
            reader.Close();
            return dersler;
        }
        public void AddDers(Ders ders)
        {
            var yeniDersId = GetDersler().LastOrDefault().Id + 1;
            ders.Id = yeniDersId;
            string line = "\n" + ders.Id + ";" + ders.Adi + ";" + ders.KategoriId + ";" + ders.Icerik + ";" + ders.Kredi;
            StreamWriter writer = new StreamWriter(_derslerPath, true, Encoding.UTF8);
            writer.Write(line);
            writer.Close();
        }
    }
}
