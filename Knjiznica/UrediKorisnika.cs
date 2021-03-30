using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica
{
    public partial class UrediKorisnika : Form
    {
        private KnjiznicaRepo korisnici = new KnjiznicaRepo();
        private MainForm _sourceForm;
        public UrediKorisnika(int userId, MainForm source)
        {
            InitializeComponent();
            _sourceForm = source;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Korisnici korisnik = new Korisnici();
            korisnik.IDKorisnika = Int32.Parse(lblEditUserID.Text);
            korisnik.ImeKorisnika = textBox1.Text;
            korisnik.PrezimeKorisnika = textBox2.Text;

            korisnici.UpdateUsers(korisnik);
            _sourceForm.UpdateGrid();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEditUserID_Click(object sender, EventArgs e)
        {

        }
    }
}
