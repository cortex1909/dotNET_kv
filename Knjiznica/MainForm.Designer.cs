namespace Knjiznica
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pretrazivanjeKnjiga = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NazivKnjige = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Podnaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPretrazivanja = new System.Windows.Forms.GroupBox();
            this.Filtriraj = new System.Windows.Forms.Button();
            this.naslovBox = new System.Windows.Forms.TextBox();
            this.Naslov = new System.Windows.Forms.Label();
            this.posudeneKnjige = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.knjiznicaRepoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.popisKorisnika = new System.Windows.Forms.TabPage();
            this.DodajKorisnika = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idposudba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nkor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.pretrazivanjeKnjiga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.formaPretrazivanja.SuspendLayout();
            this.posudeneKnjige.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaRepoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.popisKorisnika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.pretrazivanjeKnjiga);
            this.tabControl1.Controls.Add(this.posudeneKnjige);
            this.tabControl1.Controls.Add(this.popisKorisnika);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // pretrazivanjeKnjiga
            // 
            this.pretrazivanjeKnjiga.Controls.Add(this.dataGridView1);
            this.pretrazivanjeKnjiga.Controls.Add(this.formaPretrazivanja);
            this.pretrazivanjeKnjiga.Location = new System.Drawing.Point(4, 22);
            this.pretrazivanjeKnjiga.Name = "pretrazivanjeKnjiga";
            this.pretrazivanjeKnjiga.Padding = new System.Windows.Forms.Padding(3);
            this.pretrazivanjeKnjiga.Size = new System.Drawing.Size(792, 424);
            this.pretrazivanjeKnjiga.TabIndex = 0;
            this.pretrazivanjeKnjiga.Text = "Pretraživanje knjiga";
            this.pretrazivanjeKnjiga.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivKnjige,
            this.Podnaziv,
            this.ISBN,
            this.Cijen});
            this.dataGridView1.Location = new System.Drawing.Point(8, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 337);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NazivKnjige
            // 
            this.NazivKnjige.DataPropertyName = "NazivKnjige";
            this.NazivKnjige.HeaderText = "Naziv knjige";
            this.NazivKnjige.Name = "NazivKnjige";
            // 
            // Podnaziv
            // 
            this.Podnaziv.DataPropertyName = "Podnaziv";
            this.Podnaziv.HeaderText = "Podnaziv knjige";
            this.Podnaziv.Name = "Podnaziv";
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN13";
            this.ISBN.HeaderText = "ISBN13";
            this.ISBN.Name = "ISBN";
            // 
            // Cijen
            // 
            this.Cijen.DataPropertyName = "Cijena";
            this.Cijen.HeaderText = "Cijena";
            this.Cijen.Name = "Cijen";
            // 
            // formaPretrazivanja
            // 
            this.formaPretrazivanja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formaPretrazivanja.Controls.Add(this.Filtriraj);
            this.formaPretrazivanja.Controls.Add(this.naslovBox);
            this.formaPretrazivanja.Controls.Add(this.Naslov);
            this.formaPretrazivanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formaPretrazivanja.Location = new System.Drawing.Point(8, 6);
            this.formaPretrazivanja.Name = "formaPretrazivanja";
            this.formaPretrazivanja.Size = new System.Drawing.Size(778, 69);
            this.formaPretrazivanja.TabIndex = 0;
            this.formaPretrazivanja.TabStop = false;
            this.formaPretrazivanja.Text = "Forma pretraživanja";
            this.formaPretrazivanja.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Filtriraj
            // 
            this.Filtriraj.Location = new System.Drawing.Point(537, 18);
            this.Filtriraj.Name = "Filtriraj";
            this.Filtriraj.Size = new System.Drawing.Size(111, 35);
            this.Filtriraj.TabIndex = 8;
            this.Filtriraj.Text = "PRETRAŽI";
            this.Filtriraj.UseVisualStyleBackColor = true;
            this.Filtriraj.Click += new System.EventHandler(this.Filtriraj_Click);
            // 
            // naslovBox
            // 
            this.naslovBox.Location = new System.Drawing.Point(72, 23);
            this.naslovBox.Name = "naslovBox";
            this.naslovBox.Size = new System.Drawing.Size(459, 24);
            this.naslovBox.TabIndex = 4;
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naslov.Location = new System.Drawing.Point(15, 28);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(51, 17);
            this.Naslov.TabIndex = 0;
            this.Naslov.Text = "Naslov";
            // 
            // posudeneKnjige
            // 
            this.posudeneKnjige.Controls.Add(this.button2);
            this.posudeneKnjige.Controls.Add(this.button1);
            this.posudeneKnjige.Controls.Add(this.comboBox1);
            this.posudeneKnjige.Controls.Add(this.label1);
            this.posudeneKnjige.Controls.Add(this.dataGridView3);
            this.posudeneKnjige.Location = new System.Drawing.Point(4, 22);
            this.posudeneKnjige.Name = "posudeneKnjige";
            this.posudeneKnjige.Padding = new System.Windows.Forms.Padding(3);
            this.posudeneKnjige.Size = new System.Drawing.Size(792, 424);
            this.posudeneKnjige.TabIndex = 1;
            this.posudeneKnjige.Text = "Posuđene knjige";
            this.posudeneKnjige.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(630, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "SPREMI POSUDBE U TXT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "FILTRIRAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.knjiznicaRepoBindingSource;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // knjiznicaRepoBindingSource
            // 
            this.knjiznicaRepoBindingSource.DataSource = typeof(DataAccessLayer.KnjiznicaRepo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite korisnika: ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idposudba,
            this.nk,
            this.nkor,
            this.dp,
            this.dv});
            this.dataGridView3.Location = new System.Drawing.Point(3, 30);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(786, 394);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // popisKorisnika
            // 
            this.popisKorisnika.Controls.Add(this.DodajKorisnika);
            this.popisKorisnika.Controls.Add(this.dataGridView2);
            this.popisKorisnika.Location = new System.Drawing.Point(4, 22);
            this.popisKorisnika.Name = "popisKorisnika";
            this.popisKorisnika.Size = new System.Drawing.Size(792, 424);
            this.popisKorisnika.TabIndex = 2;
            this.popisKorisnika.Text = "Popis korisnika";
            this.popisKorisnika.UseVisualStyleBackColor = true;
            this.popisKorisnika.Click += new System.EventHandler(this.popisKorisnika_Click);
            // 
            // DodajKorisnika
            // 
            this.DodajKorisnika.Dock = System.Windows.Forms.DockStyle.Right;
            this.DodajKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DodajKorisnika.Location = new System.Drawing.Point(690, 0);
            this.DodajKorisnika.Name = "DodajKorisnika";
            this.DodajKorisnika.Size = new System.Drawing.Size(102, 424);
            this.DodajKorisnika.TabIndex = 1;
            this.DodajKorisnika.Text = "Dodaj korisnika";
            this.DodajKorisnika.UseVisualStyleBackColor = true;
            this.DodajKorisnika.Click += new System.EventHandler(this.DodajKorisnika_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ime,
            this.Prezime});
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(681, 421);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IDKorisnika";
            this.ID.HeaderText = "ID korisnika";
            this.ID.Name = "ID";
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "ImeKorisnika";
            this.Ime.HeaderText = "Ime korisnika";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "PrezimeKorisnika";
            this.Prezime.HeaderText = "Prezime korisnika";
            this.Prezime.Name = "Prezime";
            // 
            // idposudba
            // 
            this.idposudba.DataPropertyName = "IDPosudba";
            this.idposudba.HeaderText = "ID posudba";
            this.idposudba.Name = "idposudba";
            // 
            // nk
            // 
            this.nk.DataPropertyName = "NazivKnjige";
            this.nk.HeaderText = "Naziv knjige";
            this.nk.Name = "nk";
            // 
            // nkor
            // 
            this.nkor.DataPropertyName = "NazivKorisnika";
            this.nkor.HeaderText = "Naziv korisnika";
            this.nkor.Name = "nkor";
            // 
            // dp
            // 
            this.dp.DataPropertyName = "DatumPosudjivanja";
            this.dp.HeaderText = "Datum posudbe";
            this.dp.Name = "dp";
            // 
            // dv
            // 
            this.dv.DataPropertyName = "DatumVracanja";
            this.dv.HeaderText = "Datum vracanja";
            this.dv.Name = "dv";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Knjižnica © Hrvoje Đaković 2020";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.pretrazivanjeKnjiga.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.formaPretrazivanja.ResumeLayout(false);
            this.formaPretrazivanja.PerformLayout();
            this.posudeneKnjige.ResumeLayout(false);
            this.posudeneKnjige.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaRepoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.popisKorisnika.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pretrazivanjeKnjiga;
        private System.Windows.Forms.TabPage posudeneKnjige;
        private System.Windows.Forms.GroupBox formaPretrazivanja;
        private System.Windows.Forms.TabPage popisKorisnika;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Filtriraj;
        private System.Windows.Forms.TextBox naslovBox;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Button DodajKorisnika;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivKnjige;
        private System.Windows.Forms.DataGridViewTextBoxColumn Podnaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijen;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource knjiznicaRepoBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idposudba;
        private System.Windows.Forms.DataGridViewTextBoxColumn nk;
        private System.Windows.Forms.DataGridViewTextBoxColumn nkor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv;
    }
}

