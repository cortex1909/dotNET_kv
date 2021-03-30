using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using DataAccessLayer;

namespace Knjiznica
{
    public partial class RazduziKnjigu : Form
    {
        private KnjiznicaRepo posudba = new KnjiznicaRepo();
        private MainForm _sourceForm;
        private int _posudbaId;
        public RazduziKnjigu(int posudbaId, MainForm source)
        {
            InitializeComponent();
            _sourceForm = source;
            _posudbaId = posudbaId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Posudba posudbe = posudba.DohvatiPosudbe().Where(u => u.IDPosudba == _posudbaId).FirstOrDefault();
            posudba.RazduziKnjigu(posudbe);
            _sourceForm.UpdateGrid();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
