using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkladisteData;
namespace Skladiste
{
    public partial class SkladisteForm : Form
    {
        IArtikl trenutniArtikl;
        SkladisteMain skladiste = new SkladisteMain();
        public SkladisteForm()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += (s, a) =>
            {
                trenutniArtikl = dataGridView1.CurrentRow.DataBoundItem as IArtikl;
            };
            
        }

        public void Osvjezi()
        {
            //BindingSource bs = new BindingSource();
            //bs = skladiste.DohvatiArtikle();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = skladiste.DohvatiARtikle();
        }

        private void SkladisteForm_Load(object sender, EventArgs e)
        {
            this.Osvjezi();
            this.radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                skladiste.DodajDomaci(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            }
            else
            {
                skladiste.DodajUvezeno(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            }
            Osvjezi();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            trenutniArtikl.DodajKolicinu();
            Osvjezi();
        }

        private void oduzmiButton_Click(object sender, EventArgs e)
        {
            trenutniArtikl.MakniKolicinu();
            Osvjezi();
        }
    }
}
