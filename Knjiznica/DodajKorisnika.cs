using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace Knjiznica
{
    public partial class DodajKorisnika : Form
    {
        private KnjiznicaRepo korisnici = new KnjiznicaRepo();
        private MainForm _sourceForm;
        public DodajKorisnika(MainForm source)
        {
            InitializeComponent();
            _sourceForm = source;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Korisnici korisnik = new Korisnici();
            korisnik.ImeKorisnika = textBox1.Text;
            korisnik.PrezimeKorisnika = textBox2.Text;

            korisnici.DodajKorisnika(korisnik);
            _sourceForm.UpdateGrid();
            this.Hide();
        }
    }
}
