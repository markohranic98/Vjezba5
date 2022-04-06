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
        SkladisteMain skladiste = new SkladisteMain();
        public SkladisteForm()
        {
            InitializeComponent();
            
        }

        public void Osvjezi()
        {
            //BindingSource bs = new BindingSource();
            //bs = skladiste.DohvatiArtikle();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = skladiste.DohvatiArtikle();
        }

        private void SkladisteForm_Load(object sender, EventArgs e)
        {
            this.Osvjezi();
        }
    }
}
