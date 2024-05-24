using System.Windows.Forms;

namespace Klijent.UserControls
{
    partial class UCPrikazRecepata
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPrikazRecepata));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretragaNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkLak = new System.Windows.Forms.CheckBox();
            this.chkSrednji = new System.Windows.Forms.CheckBox();
            this.chkTezak = new System.Windows.Forms.CheckBox();
            this.checkedListNamirnice = new System.Windows.Forms.CheckedListBox();
            this.btnNazad = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNamirnicaFilter = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbDetalji = new System.Windows.Forms.GroupBox();
            this.lblAlergeni = new System.Windows.Forms.Label();
            this.txtJelo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUkupneKalorije = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTezina = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVreme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtProfilIshrane = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPrikazRecepata = new System.Windows.Forms.DataGridView();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbDetalji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazRecepata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pretrazite recept po nazivu, ";
            // 
            // txtPretragaNaziv
            // 
            this.txtPretragaNaziv.BackColor = System.Drawing.Color.Khaki;
            this.txtPretragaNaziv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPretragaNaziv.Location = new System.Drawing.Point(51, 79);
            this.txtPretragaNaziv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPretragaNaziv.Name = "txtPretragaNaziv";
            this.txtPretragaNaziv.Size = new System.Drawing.Size(164, 20);
            this.txtPretragaNaziv.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Odaberite tezinu recepta";
            // 
            // chkLak
            // 
            this.chkLak.AutoSize = true;
            this.chkLak.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkLak.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkLak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkLak.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLak.Location = new System.Drawing.Point(51, 159);
            this.chkLak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkLak.Name = "chkLak";
            this.chkLak.Size = new System.Drawing.Size(50, 24);
            this.chkLak.TabIndex = 9;
            this.chkLak.Text = "Lak";
            this.chkLak.UseVisualStyleBackColor = true;
            // 
            // chkSrednji
            // 
            this.chkSrednji.AutoSize = true;
            this.chkSrednji.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkSrednji.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkSrednji.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkSrednji.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSrednji.Location = new System.Drawing.Point(108, 159);
            this.chkSrednji.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSrednji.Name = "chkSrednji";
            this.chkSrednji.Size = new System.Drawing.Size(74, 24);
            this.chkSrednji.TabIndex = 10;
            this.chkSrednji.Text = "Srednji";
            this.chkSrednji.UseVisualStyleBackColor = true;
            // 
            // chkTezak
            // 
            this.chkTezak.AutoSize = true;
            this.chkTezak.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkTezak.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkTezak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkTezak.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTezak.Location = new System.Drawing.Point(185, 159);
            this.chkTezak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkTezak.Name = "chkTezak";
            this.chkTezak.Size = new System.Drawing.Size(64, 24);
            this.chkTezak.TabIndex = 11;
            this.chkTezak.Text = "Tezak";
            this.chkTezak.UseVisualStyleBackColor = true;
            // 
            // checkedListNamirnice
            // 
            this.checkedListNamirnice.BackColor = System.Drawing.Color.White;
            this.checkedListNamirnice.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListNamirnice.FormattingEnabled = true;
            this.checkedListNamirnice.HorizontalScrollbar = true;
            this.checkedListNamirnice.Location = new System.Drawing.Point(559, 56);
            this.checkedListNamirnice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListNamirnice.Name = "checkedListNamirnice";
            this.checkedListNamirnice.Size = new System.Drawing.Size(320, 158);
            this.checkedListNamirnice.TabIndex = 12;
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNazad.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.ForeColor = System.Drawing.Color.White;
            this.btnNazad.Location = new System.Drawing.Point(566, 679);
            this.btnNazad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(322, 49);
            this.btnNazad.TabIndex = 31;
            this.btnNazad.Text = "POGLEDAJ DETALJE DRUGOG RECEPTA";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(48, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "profilu ili jelu";
            // 
            // txtNamirnicaFilter
            // 
            this.txtNamirnicaFilter.BackColor = System.Drawing.Color.Khaki;
            this.txtNamirnicaFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamirnicaFilter.Location = new System.Drawing.Point(699, 21);
            this.txtNamirnicaFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamirnicaFilter.Name = "txtNamirnicaFilter";
            this.txtNamirnicaFilter.Size = new System.Drawing.Size(180, 20);
            this.txtNamirnicaFilter.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(556, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "Pretrazite namirnice";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Klijent.Properties.Resources._10823229__1_;
            this.pictureBox1.Location = new System.Drawing.Point(342, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // gbDetalji
            // 
            this.gbDetalji.BackgroundImage = global::Klijent.Properties.Resources.geometric_cute_citrus_fruit_seamless_pattern_isolated_fruits_endless_wallpaper_97843_4107;
            this.gbDetalji.Controls.Add(this.label19);
            this.gbDetalji.Controls.Add(this.lblAlergeni);
            this.gbDetalji.Controls.Add(this.txtJelo);
            this.gbDetalji.Controls.Add(this.label13);
            this.gbDetalji.Controls.Add(this.label12);
            this.gbDetalji.Controls.Add(this.txtUkupneKalorije);
            this.gbDetalji.Controls.Add(this.label11);
            this.gbDetalji.Controls.Add(this.label10);
            this.gbDetalji.Controls.Add(this.txtKorisnik);
            this.gbDetalji.Controls.Add(this.label9);
            this.gbDetalji.Controls.Add(this.txtTezina);
            this.gbDetalji.Controls.Add(this.label8);
            this.gbDetalji.Controls.Add(this.label7);
            this.gbDetalji.Controls.Add(this.txtVreme);
            this.gbDetalji.Controls.Add(this.label6);
            this.gbDetalji.Controls.Add(this.txtNaziv);
            this.gbDetalji.Controls.Add(this.label5);
            this.gbDetalji.Controls.Add(this.txtOpis);
            this.gbDetalji.Controls.Add(this.txtProfilIshrane);
            this.gbDetalji.Controls.Add(this.label4);
            this.gbDetalji.Controls.Add(this.label3);
            this.gbDetalji.Controls.Add(this.dgvStavke);
            this.gbDetalji.Enabled = false;
            this.gbDetalji.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalji.Location = new System.Drawing.Point(54, 222);
            this.gbDetalji.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetalji.Name = "gbDetalji";
            this.gbDetalji.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetalji.Size = new System.Drawing.Size(831, 449);
            this.gbDetalji.TabIndex = 13;
            this.gbDetalji.TabStop = false;
            this.gbDetalji.Text = "Detalji recepta";
            this.gbDetalji.Visible = false;
            // 
            // lblAlergeni
            // 
            this.lblAlergeni.AutoSize = true;
            this.lblAlergeni.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlergeni.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblAlergeni.Location = new System.Drawing.Point(103, 408);
            this.lblAlergeni.Name = "lblAlergeni";
            this.lblAlergeni.Size = new System.Drawing.Size(93, 23);
            this.lblAlergeni.TabIndex = 41;
            this.lblAlergeni.Text = "Alergeni : ";
            // 
            // txtJelo
            // 
            this.txtJelo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtJelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJelo.Enabled = false;
            this.txtJelo.Location = new System.Drawing.Point(198, 66);
            this.txtJelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJelo.Name = "txtJelo";
            this.txtJelo.Size = new System.Drawing.Size(164, 20);
            this.txtJelo.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(198, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Jelo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(334, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "kcal";
            // 
            // txtUkupneKalorije
            // 
            this.txtUkupneKalorije.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtUkupneKalorije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUkupneKalorije.Enabled = false;
            this.txtUkupneKalorije.Location = new System.Drawing.Point(268, 258);
            this.txtUkupneKalorije.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUkupneKalorije.Name = "txtUkupneKalorije";
            this.txtUkupneKalorije.Size = new System.Drawing.Size(63, 20);
            this.txtUkupneKalorije.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(234, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Ukupne kalorije";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Opis";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtKorisnik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKorisnik.Enabled = false;
            this.txtKorisnik.Location = new System.Drawing.Point(6, 202);
            this.txtKorisnik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.Size = new System.Drawing.Size(164, 20);
            this.txtKorisnik.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Korisnik";
            // 
            // txtTezina
            // 
            this.txtTezina.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtTezina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTezina.Enabled = false;
            this.txtTezina.Location = new System.Drawing.Point(9, 134);
            this.txtTezina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTezina.Name = "txtTezina";
            this.txtTezina.Size = new System.Drawing.Size(164, 20);
            this.txtTezina.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tezina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "min";
            // 
            // txtVreme
            // 
            this.txtVreme.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtVreme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVreme.Enabled = false;
            this.txtVreme.Location = new System.Drawing.Point(288, 202);
            this.txtVreme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVreme.Name = "txtVreme";
            this.txtVreme.Size = new System.Drawing.Size(43, 20);
            this.txtVreme.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Vreme kuvanja";
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtNaziv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNaziv.Enabled = false;
            this.txtNaziv.Location = new System.Drawing.Point(6, 66);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(164, 20);
            this.txtNaziv.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Naziv";
            // 
            // txtOpis
            // 
            this.txtOpis.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtOpis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpis.Enabled = false;
            this.txtOpis.Location = new System.Drawing.Point(9, 326);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(426, 76);
            this.txtOpis.TabIndex = 16;
            // 
            // txtProfilIshrane
            // 
            this.txtProfilIshrane.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtProfilIshrane.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProfilIshrane.Enabled = false;
            this.txtProfilIshrane.Location = new System.Drawing.Point(9, 258);
            this.txtProfilIshrane.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProfilIshrane.Name = "txtProfilIshrane";
            this.txtProfilIshrane.Size = new System.Drawing.Size(164, 20);
            this.txtProfilIshrane.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Profil Ishrane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Stavke recepta";
            // 
            // dgvStavke
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvStavke.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStavke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavke.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStavke.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStavke.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStavke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStavke.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStavke.EnableHeadersVisualStyles = false;
            this.dgvStavke.Location = new System.Drawing.Point(481, 66);
            this.dgvStavke.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.RowTemplate.Height = 24;
            this.dgvStavke.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStavke.Size = new System.Drawing.Size(344, 256);
            this.dgvStavke.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPrikazRecepata);
            this.panel1.Controls.Add(this.btnDetalji);
            this.panel1.Location = new System.Drawing.Point(52, 222);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 364);
            this.panel1.TabIndex = 33;
            // 
            // dgvPrikazRecepata
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvPrikazRecepata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPrikazRecepata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPrikazRecepata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrikazRecepata.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPrikazRecepata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPrikazRecepata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrikazRecepata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPrikazRecepata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrikazRecepata.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPrikazRecepata.EnableHeadersVisualStyles = false;
            this.dgvPrikazRecepata.Location = new System.Drawing.Point(128, 21);
            this.dgvPrikazRecepata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPrikazRecepata.Name = "dgvPrikazRecepata";
            this.dgvPrikazRecepata.RowHeadersWidth = 51;
            this.dgvPrikazRecepata.RowTemplate.Height = 24;
            this.dgvPrikazRecepata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPrikazRecepata.Size = new System.Drawing.Size(583, 236);
            this.dgvPrikazRecepata.TabIndex = 4;
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDetalji.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalji.ForeColor = System.Drawing.Color.White;
            this.btnDetalji.Location = new System.Drawing.Point(280, 281);
            this.btnDetalji.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(285, 40);
            this.btnDetalji.TabIndex = 32;
            this.btnDetalji.Text = "DETALJI RECEPTA";
            this.btnDetalji.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label16.Location = new System.Drawing.Point(-4, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1389, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = resources.GetString("label16.Text");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label17.Location = new System.Drawing.Point(-188, 187);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1749, 20);
            this.label17.TabIndex = 39;
            this.label17.Text = resources.GetString("label17.Text");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label18.Location = new System.Drawing.Point(-198, 655);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(1923, 20);
            this.label18.TabIndex = 40;
            this.label18.Text = resources.GetString("label18.Text");
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.ForestGreen;
            this.label19.Location = new System.Drawing.Point(12, 408);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 23);
            this.label19.TabIndex = 42;
            this.label19.Text = "Alergeni : ";
            // 
            // UCPrikazRecepata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label18);
            this.Controls.Add(this.checkedListNamirnice);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtNamirnicaFilter);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.gbDetalji);
            this.Controls.Add(this.chkTezak);
            this.Controls.Add(this.chkSrednji);
            this.Controls.Add(this.chkLak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPretragaNaziv);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCPrikazRecepata";
            this.Size = new System.Drawing.Size(1000, 744);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbDetalji.ResumeLayout(false);
            this.gbDetalji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazRecepata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikazRecepata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretragaNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkLak;
        private System.Windows.Forms.CheckBox chkSrednji;
        private System.Windows.Forms.CheckBox chkTezak;
        private System.Windows.Forms.CheckedListBox checkedListNamirnice;
        private System.Windows.Forms.GroupBox gbDetalji;
        private System.Windows.Forms.TextBox txtProfilIshrane;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.TextBox txtJelo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUkupneKalorije;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTezina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVreme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNamirnicaFilter;
        private System.Windows.Forms.Label label15;
        private PictureBox pictureBox1;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label lblAlergeni;
        private Label label19;

        public DataGridView DgvPrikazRecepata { get => dgvPrikazRecepata; set => dgvPrikazRecepata = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtPretragaNaziv { get => txtPretragaNaziv; set => txtPretragaNaziv = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public CheckBox ChkLak { get => chkLak; set => chkLak = value; }
        public CheckBox ChkSrednji { get => chkSrednji; set => chkSrednji = value; }
        public CheckBox ChkTezak { get => chkTezak; set => chkTezak = value; }
        public CheckedListBox CheckedListNamirnice { get => checkedListNamirnice; set => checkedListNamirnice = value; }
        public GroupBox GbDetalji { get => gbDetalji; set => gbDetalji = value; }
        public TextBox TxtProfilIshrane { get => txtProfilIshrane; set => txtProfilIshrane = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public DataGridView DgvStavke { get => dgvStavke; set => dgvStavke = value; }
        public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
        public TextBox TxtJelo { get => txtJelo; set => txtJelo = value; }
        public Label Label13 { get => label13; set => label13 = value; }
        public Label Label12 { get => label12; set => label12 = value; }
        public TextBox TxtUkupneKalorije { get => txtUkupneKalorije; set => txtUkupneKalorije = value; }
        public Label Label11 { get => label11; set => label11 = value; }
        public Label Label10 { get => label10; set => label10 = value; }
        public TextBox TxtKorisnik { get => txtKorisnik; set => txtKorisnik = value; }
        public Label Label9 { get => label9; set => label9 = value; }
        public TextBox TxtTezina { get => txtTezina; set => txtTezina = value; }
        public Label Label8 { get => label8; set => label8 = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public TextBox TxtVreme { get => txtVreme; set => txtVreme = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public TextBox TxtOpis { get => txtOpis; set => txtOpis = value; }
        public Button BtnDetalji { get => btnDetalji; set => btnDetalji = value; }
        public Panel Panel1 { get => panel1; set => panel1 = value; }
        public Label Label14 { get => label14; set => label14 = value; }
        public TextBox TxtNamirnicaFilter { get => txtNamirnicaFilter; set => txtNamirnicaFilter = value; }
        public Label Label15 { get => label15; set => label15 = value; }
        public Label LblAlergeni { get => lblAlergeni; set => lblAlergeni = value; }
    }
}
