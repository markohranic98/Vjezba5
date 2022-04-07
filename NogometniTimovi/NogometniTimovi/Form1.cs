using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlubLib;
namespace NogometniTimovi
{
    public partial class NogometniTimoviForm : Form
    {
        Klub klub = new Klub();
        Tim trenutniTim;
        Nogometas trenutniNogometas;
        public NogometniTimoviForm()
        {
            InitializeComponent();
            dataGridView2.SelectionChanged += (s, e) =>
            {
                trenutniTim = dataGridView2.CurrentRow.DataBoundItem as Tim;
                dataGridView3.DataSource = klub.DohvatiNogometaseTima(trenutniTim);
            };
        }

        private void NogometniTimoviForm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        public void Osvjezi()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = klub.DohvatiTimove();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = klub.DostupniNogometasi();
            dataGridView3.DataSource = null;
            trenutniTim = dataGridView2.CurrentRow.DataBoundItem as Tim;
            dataGridView3.DataSource = klub.DohvatiNogometaseTima(trenutniTim);
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            trenutniNogometas = dataGridView1.CurrentRow.DataBoundItem as Nogometas;
            trenutniTim.DodajIgracaTimu(trenutniNogometas);
            Osvjezi();
        }
    }
}
