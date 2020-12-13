using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersBilgileriV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hafızaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HafizaForm form = new HafizaForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DosyaForm form = new DosyaForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void hafızaDosyaDependencyInjectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HafizaDosyaForm form = new HafizaDosyaForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}
