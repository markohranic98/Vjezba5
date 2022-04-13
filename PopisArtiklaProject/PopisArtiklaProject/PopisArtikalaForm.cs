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
    public partial class PopisArtikalaForm : Form
    {
        RepozitorijArtikala repozitorij = new RepozitorijArtikala();
        Artikl odabranArtikl = null;
        public PopisArtikalaForm()
        {
            InitializeComponent();
            obrisiBtn.Click += (s, e) =>
            {
                if (dataGridView1.DataSource != null)
                {
                    odabranArtikl = dataGridView1.CurrentRow.DataBoundItem as Artikl;
                    repozitorij.ObrisiArtikl(odabranArtikl);
                    Osvjezi();
                    this.Close();
                }
            };
        }

        private void obrisiBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            repozitorij.DodajArtikl(nazivTextBox.Text, Convert.ToInt32(cijenaTbox.Text), Convert.ToInt32(kolicinaTbox.Text));
            Osvjezi();
            this.Close();
        }

        private void Osvjezi()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = RepozitorijArtikala.Artikli;
        }

        private void PopisArtikalaForm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
    }
}
