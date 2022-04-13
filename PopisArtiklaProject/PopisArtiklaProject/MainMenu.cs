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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopisArtikalaForm form1 = new PopisArtikalaForm();
            form1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PopisForm form2 = new PopisForm();
            form2.ShowDialog();
        }
    }
}
