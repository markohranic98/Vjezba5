using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopisArtiklaProject
{
    public partial class PopisForm : Form
    {
        RepozitorijArtikala repozitorij = new RepozitorijArtikala();
        public PopisForm()
        {
            InitializeComponent();
        }

        private void PopisForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = RepozitorijArtikala.Artikli;
            textBox1.Text = repozitorij.NapraviSumu().ToString();
        }
    }
}
