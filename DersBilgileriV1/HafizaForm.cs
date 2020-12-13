using DersBilgileriV1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DersBilgileriV1
{
    public partial class HafizaForm : Form
    {
        private static List<Ders> dersler = new List<Ders>()
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

        private static List<Kategori> kategoriler = new List<Kategori>()
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

        public HafizaForm()
        {
            InitializeComponent();
        }

        private void HafizaForm_Load(object sender, EventArgs e)
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
            return kategoriler.ToList();
        }

        void FillGrid()
        {
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
            return dersler.ToList();
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
            var dersListesi = GetDersler();
            int yeniDersId = dersListesi.LastOrDefault().Id + 1;
            Ders ders = new Ders()
            {
                Id = yeniDersId,
                Adi = tbAdi.Text.Trim(),
                //KategoriId = cbKategori.SelectedIndex == 1 ? (int)KategoriEnum.Sayısal : (int)KategoriEnum.Sosyal,
                KategoriId = (int)cbKategori.SelectedValue,
                Kredi = Convert.ToByte(nudKredi.Value),
                Icerik = tbIcerik.Text.Trim()
            };
            dersler.Add(ders);
        }
    }
}
