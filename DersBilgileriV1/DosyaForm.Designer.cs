
namespace DersBilgileriV1
{
    partial class DosyaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lSonuc = new System.Windows.Forms.Label();
            this.gbYeni = new System.Windows.Forms.GroupBox();
            this.bTemizle = new System.Windows.Forms.Button();
            this.bKaydet = new System.Windows.Forms.Button();
            this.tbIcerik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudKredi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bYeni = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDersListesi = new System.Windows.Forms.DataGridView();
            this.gbYeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKredi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // lSonuc
            // 
            this.lSonuc.AutoSize = true;
            this.lSonuc.ForeColor = System.Drawing.Color.Red;
            this.lSonuc.Location = new System.Drawing.Point(127, 238);
            this.lSonuc.Name = "lSonuc";
            this.lSonuc.Size = new System.Drawing.Size(0, 13);
            this.lSonuc.TabIndex = 7;
            // 
            // gbYeni
            // 
            this.gbYeni.Controls.Add(this.bTemizle);
            this.gbYeni.Controls.Add(this.bKaydet);
            this.gbYeni.Controls.Add(this.tbIcerik);
            this.gbYeni.Controls.Add(this.label4);
            this.gbYeni.Controls.Add(this.nudKredi);
            this.gbYeni.Controls.Add(this.label3);
            this.gbYeni.Controls.Add(this.cbKategori);
            this.gbYeni.Controls.Add(this.label2);
            this.gbYeni.Controls.Add(this.tbAdi);
            this.gbYeni.Controls.Add(this.label1);
            this.gbYeni.Location = new System.Drawing.Point(16, 263);
            this.gbYeni.Name = "gbYeni";
            this.gbYeni.Size = new System.Drawing.Size(769, 175);
            this.gbYeni.TabIndex = 6;
            this.gbYeni.TabStop = false;
            this.gbYeni.Text = "Yeni Ders Ekleme";
            this.gbYeni.Visible = false;
            // 
            // bTemizle
            // 
            this.bTemizle.Location = new System.Drawing.Point(141, 101);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(75, 23);
            this.bTemizle.TabIndex = 9;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = true;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // bKaydet
            // 
            this.bKaydet.Location = new System.Drawing.Point(59, 101);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(75, 23);
            this.bKaydet.TabIndex = 8;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.UseVisualStyleBackColor = true;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // tbIcerik
            // 
            this.tbIcerik.Location = new System.Drawing.Point(296, 19);
            this.tbIcerik.Multiline = true;
            this.tbIcerik.Name = "tbIcerik";
            this.tbIcerik.Size = new System.Drawing.Size(467, 75);
            this.tbIcerik.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "İçerik";
            // 
            // nudKredi
            // 
            this.nudKredi.Location = new System.Drawing.Point(59, 74);
            this.nudKredi.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudKredi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKredi.Name = "nudKredi";
            this.nudKredi.Size = new System.Drawing.Size(190, 20);
            this.nudKredi.TabIndex = 5;
            this.nudKredi.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kredi";
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(59, 46);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(190, 21);
            this.cbKategori.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori";
            // 
            // tbAdi
            // 
            this.tbAdi.Location = new System.Drawing.Point(59, 19);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(190, 20);
            this.tbAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // bYeni
            // 
            this.bYeni.Location = new System.Drawing.Point(16, 233);
            this.bYeni.Name = "bYeni";
            this.bYeni.Size = new System.Drawing.Size(105, 23);
            this.bYeni.TabIndex = 5;
            this.bYeni.Text = "Yeni Ders";
            this.bYeni.UseVisualStyleBackColor = true;
            this.bYeni.Click += new System.EventHandler(this.bYeni_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDersListesi);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 213);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Listesi";
            // 
            // dgvDersListesi
            // 
            this.dgvDersListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDersListesi.Location = new System.Drawing.Point(3, 16);
            this.dgvDersListesi.Name = "dgvDersListesi";
            this.dgvDersListesi.Size = new System.Drawing.Size(769, 194);
            this.dgvDersListesi.TabIndex = 0;
            // 
            // DosyaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lSonuc);
            this.Controls.Add(this.gbYeni);
            this.Controls.Add(this.bYeni);
            this.Controls.Add(this.groupBox1);
            this.Name = "DosyaForm";
            this.Text = "Dosya";
            this.Load += new System.EventHandler(this.DosyaForm_Load);
            this.gbYeni.ResumeLayout(false);
            this.gbYeni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKredi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lSonuc;
        private System.Windows.Forms.GroupBox gbYeni;
        private System.Windows.Forms.Button bTemizle;
        private System.Windows.Forms.Button bKaydet;
        private System.Windows.Forms.TextBox tbIcerik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudKredi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bYeni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDersListesi;
    }
}