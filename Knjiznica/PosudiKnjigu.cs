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
    public partial class PosudiKnjigu : Form
    {
        private KnjiznicaRepo _knjigeRepo = new KnjiznicaRepo();
        private BindingSource _korisniciBindingSource = new BindingSource();
        private MainForm _sourceForm;
        public PosudiKnjigu(string nazivKnjige, MainForm source)
        {
            InitializeComponent();
            _korisniciBindingSource.DataSource = _knjigeRepo.DohvatiKorisnike();
            _sourceForm = source;
            dataGridView1.DataSource = _korisniciBindingSource;

            DataGridViewImageColumn posudiButton = new DataGridViewImageColumn();
            posudiButton.Image = Image.FromFile("C:/Users/Hrvoje/Desktop/DotNETKV/Knjiznica/Knjiznica/Resources/posudi.png");
            posudiButton.Width = 20;
            posudiButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns.Add(posudiButton);
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

            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void PosudiKnjigu_Load_1(object sender, EventArgs e)
        {
            
        }

        private void lblNazivKnjige_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string _imekorisnika = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string _prezimekorisnika = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            Posudba posudba = new Posudba();
            posudba.NazivKnjige = lblNazivKnjige.Text;
            posudba.NazivKorisnika = _imekorisnika + " " + _prezimekorisnika;
            posudba.DatumPosudjivanja = DateTime.Now.ToString("dd/MM/yyyy");
            posudba.DatumVracanja = DateTime.Now.AddMonths(1).ToString("dd/MM/yyyy");

            _knjigeRepo.PousdiKnjigu(posudba);          
            _sourceForm.UpdateGrid();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
