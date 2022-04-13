using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaci
{
    public partial class Form1 : Form
    {
        GeneratorZadataka generator = new GeneratorZadataka();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generator.DodajZadatak(textBox1.Text,dateTimePicker1.Value);
            Osvjezi();
        }

        private void Osvjezi()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = generator.Zadaci;
            foreach (DataGridViewRow row in dataGridView1.Rows )
            {
                Zadatak zadatak = row.DataBoundItem as Zadatak;
                if (zadatak.Rok.Day < generator.DohvatiVrijeme().Day+1)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        
    }
}
