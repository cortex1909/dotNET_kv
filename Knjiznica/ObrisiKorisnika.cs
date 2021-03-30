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
    public partial class ObrisiKorisnika : Form
    {
        private KnjiznicaRepo korisnici = new KnjiznicaRepo();
        private MainForm _sourceForm;
        private int _userId;
        public ObrisiKorisnika(int userId, MainForm source)
        {
            InitializeComponent();
            _sourceForm = source;
            _userId = userId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Korisnici korisnik = korisnici.DohvatiKorisnike().Where(u => u.IDKorisnika == _userId).FirstOrDefault();
            korisnici.DeleteUsers(korisnik);
            _sourceForm.UpdateGrid();
            this.Hide();
        }
    }
}
