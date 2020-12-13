using DersBilgileriV1.BusinessLayer;
using DersBilgileriV1.Classes;
using System;
using System.Windows.Forms;

namespace DersBilgileriV1
{
    public partial class HafizaDosyaForm : Form
    {
        private readonly string _derslerPath;
        private readonly string _kategorilerPath;

        private DersService dersService;
        private KategoriService kategoriService;       
        public HafizaDosyaForm()
        {
            InitializeComponent();
            _derslerPath = Application.StartupPath.Replace(@"\bin\Debug", @"\DataLayer") + @"\Dersler.txt";
            _kategorilerPath = Application.StartupPath.Replace(@"\bin\Debug", @"\DataLayer") + @"\Kategoriler.txt";
            
        }

        private void HafizaDosyaForm_Load(object sender, EventArgs e)
        {
            FillGrid();
            FillKategoriler();
        }

        void FillKategoriler()
        {
            var kategoriler = kategoriService.Get();
            kategoriler.Insert(0, new Kategori()
            {
                Id = 0,
                Adi = "-- Seçiniz--"
            });
            cbKategori.ValueMember = "Id";
            cbKategori.DisplayMember = "Adi";

        }
        void FillGrid()
        {
            dgvDersListesi.DataSource = dersService.Get();
            dgvDersListesi.Columns["KategoriId"].Visible = false;
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
            Ders ders = new Ders()
            {
                Adi = tbAdi.Text.Trim(),
                KategoriId = (int) cbKategori.SelectedValue,
                Icerik = tbIcerik.Text.Trim(),
                Kredi = Convert.ToByte(nudKredi.Value)
            };
            dersService.Add(ders);
        }
    }
}
