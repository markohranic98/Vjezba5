using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnjiznicaLib;
namespace Knjiznica
{
    public partial class KnjiznicaForm : Form
    {
        public List<IPretraga> KnjiznicaList = new List<IPretraga>();
        public static List<Autor> SviAutori = new List<Autor>();
        public string returnMe = "";
        public Autor oznacenAutor = null;
        public Knjiga oznacenaKnjiga = null;

        public KnjiznicaForm()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += (s, e) =>
            { 
                oznacenAutor = dataGridView1.CurrentRow.DataBoundItem as Autor;
            };
            dataGridView2.SelectionChanged += (s, e) =>
            {
                oznacenaKnjiga = dataGridView2.CurrentRow.DataBoundItem as Knjiga;
            };

            //SviAutori.Add(new Autor("Marko", "Hranic", "mail"));
            //SviAutori.Add(new Autor("Ivan", "Hranic", "mail"));
            //SviAutori.Add(new Autor("Petar", "Hranic", "mail"));
            //SviAutori.Add(new Autor("Branko", "Hranic", "mail"));
            //SviAutori.Add(new Autor("Milivoj", "Hranic", "mail"));
            //SviAutori.Add(new Autor("Saša", "Hranic", "mail"));
            //SviAutori.Add(new Autor("Filip", "Hranic", "mail"));
            //SviAutori.Add(new Autor("Josjedanmarko", "Hranic", "mail"));
            KnjiznicaList.Add(new Autor("Marko", "Hranic", "mail"));
            KnjiznicaList.Add(new Autor("Ivan", "Hranic", "mail"));
            KnjiznicaList.Add(new Autor("Petar", "Hranic", "mail"));
            KnjiznicaList.Add(new Autor("Mirko", "Hranic", "mail"));
            KnjiznicaList.Add(new Autor("Branimir", "Hranic", "mail"));
            KnjiznicaList.Add(new Autor("Marko", "Hranic", "mail"));
            KnjiznicaList.Add(new Autor("Marko", "Hranic", "mail"));
            

            
            

        }

        public void UnesiKnjigu(string naziv)
        {
            Knjiga novaKnjiga = new Knjiga();
            novaKnjiga.Naziv = naziv;
            KnjiznicaList.Add(novaKnjiga);
            Osvjezi();
        }

        private void KnjiznicaForm_Load(object sender, EventArgs e)
        {

            Osvjezi();
        }

        private void Osvjezi()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = KnjiznicaList.Where(x=>x.GetType() == typeof(Autor));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bs;
            BindingSource bs2 = new BindingSource();
            bs2.DataSource = KnjiznicaList.Where(x => x.GetType() == typeof(Knjiga));
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = bs2;
            
        }

        public List<IPretraga> GetKnjiznica()
        {
            return KnjiznicaList;
        }

        //  public void DodajAutora()

        public void Pretrazi(string rijec)
        {
            foreach(var item in KnjiznicaList)
            {
                if(item.Usporedi(rijec)== true && item.GetType() == typeof(Knjiga))
                {
                    Knjiga ispisAutora = new Knjiga();
                    ispisAutora = item as Knjiga;
                    foreach(var item2 in ispisAutora.Autori)
                    {
                        returnMe += item2.Ispis();
                    }
                   
                }
            }
        }

        private void unesiKnjiguBtn_Click(object sender, EventArgs e)
        {
            UnesiKnjigu(knjigaNazivTextBox.Text);
            Osvjezi();
        }

        private void pretraziButton_Click(object sender, EventArgs e)
        {
            returnMe = "";
            Pretrazi(pretraziTextBox.Text);
            ispisTextBox.Text=returnMe;
        }

        public void DodajAutora(Knjiga knjiga, Autor autor)
        {
            knjiga.DodajAutora(autor);
        }

        private void dodajAutoraButton_Click(object sender, EventArgs e)
        {
            DodajAutora(oznacenaKnjiga, oznacenAutor);
        }
    }
}
