using DersBilgileriV1.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DersBilgileriV1
{
    public partial class DosyaForm : Form
    {
        private readonly string _derslerPath;
        private readonly string _kategorilerPath;

        public DosyaForm()
        {
            InitializeComponent();
            _derslerPath = Application.StartupPath.Replace(@"\bin\Debug", @"\Files") + @"\Dersler.txt";
            _kategorilerPath = Application.StartupPath.Replace(@"\bin\Debug", @"\Files") + @"\Kategoriler.txt";
        }

        private void DosyaForm_Load(object sender, EventArgs e)
        {
            FillGrid();
            FillKategori();
        }

        void FillKategori()
        {
            //cbKategori.Items.Add("-- Seçiniz --"); // 0
            //cbKategori.Items.Add("Sayısal"); // 1
            //cbKategori.Items.Add("Sosyal"); // 2
            //cbKategori.SelectedIndex = 0;
            List<Kategori> tmpKategoriler = GetKategoriler();
            tmpKategoriler.Insert(0, new Kategori()
            {
                Id = 0,
                Adi = "-- Seçiniz --"
            });
            cbKategori.DataSource = tmpKategoriler;
            cbKategori.ValueMember = "Id";
            cbKategori.DisplayMember = "Adi";
        }

        List<Kategori> GetKategoriler()
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

        void FillGrid()
        {
            dgvDersListesi.DataSource = null;
            var dersListesi = GetDersler();
            var kategoriListesi = GetKategoriler();
            foreach (var ders in dersListesi)
            {
                foreach (var kategori in kategoriListesi)
                {
                    if (ders.KategoriId == kategori.Id)
                    {
                        ders.KategoriAdi = kategori.Adi;
                        break;
                    }
                }
            }
            dgvDersListesi.DataSource = dersListesi;
            //dgvDersListesi.Columns["Id"].Visible = false;
            dgvDersListesi.Columns["KategoriId"].Visible = false;
        }

        List<Ders> GetDersler()
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

        private void bYeni_Click(object sender, EventArgs e)
        {
            gbYeni.Visible = !gbYeni.Visible;
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {
            tbAdi.Text = "";
            cbKategori.SelectedIndex = 0;
            nudKredi.Value = 3;
            tbIcerik.Clear();
            lSonuc.Text = "";
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            lSonuc.Text = "";
            //if (string.IsNullOrWhiteSpace(tbAdi.Text))
            //{
            //    lSonuc.Text = "Adı girilmelidir!";
            //}
            //else
            //{
            //    if (cbKategori.SelectedIndex == 0)
            //    {
            //        lSonuc.Text = "Kategori seçilmelidir!";
            //    }
            //    else
            //    {
            //        if (string.IsNullOrWhiteSpace(tbIcerik.Text))
            //        {
            //            lSonuc.Text = "İçerik girilmelidir!";
            //        }
            //        else
            //        {
            //            // ders kayıt işlemi
            //        }
            //    }
            //}
            if (string.IsNullOrWhiteSpace(tbAdi.Text))
            {
                lSonuc.Text = "Adı girilmelidir!";
                return;
            }
            if (cbKategori.SelectedIndex == 0)
            {
                lSonuc.Text = "Kategori seçilmelidir!";
                return;
            }
            if (string.IsNullOrWhiteSpace(tbIcerik.Text))
            {
                lSonuc.Text = "İçerik girilmelidir!";
                return;
            }
            // ders kayıt işlemi
            AddDers();
            lSonuc.Text = "Yeni ders başarıyla eklendi.";
            FillGrid();
        }

        void AddDers()
        {
            var yeniDersId = GetDersler().LastOrDefault().Id + 1;
            Ders ders = new Ders()
            {
                Id = yeniDersId,
                Adi = tbAdi.Text.Trim(),
                //KategoriId = cbKategori.SelectedIndex == 1 ? (int)KategoriEnum.Sayısal : (int)KategoriEnum.Sosyal,
                KategoriId = (int)cbKategori.SelectedValue,
                Kredi = Convert.ToByte(nudKredi.Value),
                Icerik = tbIcerik.Text.Trim()
            };
            string line = "\n" + ders.Id + ";" + ders.Adi + ";" + ders.KategoriId + ";" + ders.Icerik + ";" + ders.Kredi; 
            StreamWriter writer = new StreamWriter(_derslerPath, true, Encoding.UTF8);
            writer.Write(line); 
            writer.Close();
        }
    }
}
