using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace Knjiznica
{
    public partial class MainForm : Form
    {
        private KnjiznicaRepo _knjigeRepo = new KnjiznicaRepo();
        private BindingSource _tableBindingSource = new BindingSource();
        private BindingSource _userBindingSource = new BindingSource();
        private BindingSource _posudbaBindingSource = new BindingSource();
        private BindingSource _comboKorisnici = new BindingSource();
        public MainForm()
        {
            InitializeComponent();
            UpdateGrid();

            DataGridViewImageColumn posudiButton = new DataGridViewImageColumn();
            posudiButton.Image = Image.FromFile("C:/Users/Hrvoje/Desktop/DotNETKV/Knjiznica/Knjiznica/Resources/add.png");
            posudiButton.Width = 20;
            posudiButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns.Add(posudiButton);

            DataGridViewImageColumn updateButton = new DataGridViewImageColumn();
            updateButton.Image = Image.FromFile("C:/Users/Hrvoje/Desktop/DotNETKV/Knjiznica/Knjiznica/Resources/update.png");
            updateButton.Width = 20;
            updateButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns.Add(updateButton);

            DataGridViewImageColumn deleteButton = new DataGridViewImageColumn();
            deleteButton.Image = Image.FromFile("C:/Users/Hrvoje/Desktop/DotNETKV/Knjiznica/Knjiznica/Resources/delete.png");
            deleteButton.Width = 20;
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns.Add(deleteButton);

            DataGridViewImageColumn razduziButton = new DataGridViewImageColumn();
            razduziButton.Image = Image.FromFile("C:/Users/Hrvoje/Desktop/DotNETKV/Knjiznica/Knjiznica/Resources/delete.png");
            razduziButton.Width = 20;
            razduziButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView3.Columns.Add(razduziButton);


            dataGridView2.AutoGenerateColumns = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        public void UpdateGrid()
        {
            
            dataGridView1.DataSource = _tableBindingSource;
            _userBindingSource.DataSource = _knjigeRepo.DohvatiKorisnike();
            dataGridView2.DataSource = _userBindingSource;
            _posudbaBindingSource.DataSource = _knjigeRepo.DohvatiPosudbe();
            dataGridView3.DataSource = _posudbaBindingSource;
            _comboKorisnici.DataSource = _knjigeRepo.DohvatiKorisnikeCombo();
            comboBox1.DataSource = _comboKorisnici;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Filtriraj_Click(object sender, EventArgs e)
        {
            _tableBindingSource.DataSource = _knjigeRepo.Filter(naslovBox.Text);
            _tableBindingSource.DataSource = _knjigeRepo.DohvatiKnjige(naslovBox.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows[e.RowIndex].Selected = true;
            if (dataGridView2.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {

                UrediKorisnika formEditUser = new UrediKorisnika(Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString()), this);
                formEditUser.lblEditUserID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                formEditUser.textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                formEditUser.textBox2.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                formEditUser.Show();
            }

            if (dataGridView2.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {

                ObrisiKorisnika formDeleteUser = new ObrisiKorisnika(Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString()), this);
                formDeleteUser.Show();
            }
        }

        private void popisKorisnika_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //naziv, podnaziv, isbn, cijena
        {
            dataGridView1.Rows[e.RowIndex].Selected = true;
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                PosudiKnjigu formPosudiKnjigu = new PosudiKnjigu(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), this);
                formPosudiKnjigu.lblNazivKnjige.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                formPosudiKnjigu.label4.Text = DateTime.Now.AddMonths(1).ToString("dd/MM/yyyy");
                formPosudiKnjigu.Show();
            }
        }

        private void DodajKorisnika_Click(object sender, EventArgs e)
        {
            DodajKorisnika formDodajKorisnika = new DodajKorisnika(this);
            formDodajKorisnika.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.Rows[e.RowIndex].Selected = true;

            if (dataGridView3.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {

                RazduziKnjigu formRazduziKnjigu = new RazduziKnjigu(Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString()), this);
                formRazduziKnjigu.Show();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _posudbaBindingSource.DataSource = _knjigeRepo.ComboFilter(comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _knjigeRepo.SpremiKnjigeTXT();
        }
    }
}
// 