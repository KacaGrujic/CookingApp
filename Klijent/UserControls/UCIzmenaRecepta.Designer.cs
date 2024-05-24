using System.Windows.Forms;

namespace Klijent.UserControls
{
    partial class UCIzmenaRecepta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chkTezak = new System.Windows.Forms.CheckBox();
            this.chkSrednji = new System.Windows.Forms.CheckBox();
            this.chkLak = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.txtVremeKuvanja = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtTezina = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.numericKolicina = new System.Windows.Forms.NumericUpDown();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtProfilIshrane = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUkupneKalorije = new System.Windows.Forms.TextBox();
            this.cbNamirnice = new System.Windows.Forms.ComboBox();
            this.cbMJe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbJela = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbMJ = new Klijent.UserControls.MockUpComboBox();
            this.cbNamirnica = new Klijent.UserControls.MockUpComboBox();
            this.cbJelo = new Klijent.UserControls.MockUpComboBox();
            this.btnIzmeniStavku = new System.Windows.Forms.Button();
            this.btnSacuvajIzmenuStavke = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbTezak = new System.Windows.Forms.RadioButton();
            this.rbSrednji = new System.Windows.Forms.RadioButton();
            this.rbLak = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkTezak
            // 
            this.chkTezak.AutoSize = true;
            this.chkTezak.Location = new System.Drawing.Point(214, 226);
            this.chkTezak.Name = "chkTezak";
            this.chkTezak.Size = new System.Drawing.Size(67, 20);
            this.chkTezak.TabIndex = 63;
            this.chkTezak.Text = "Tezak";
            this.chkTezak.UseVisualStyleBackColor = true;
            this.chkTezak.Visible = false;
            // 
            // chkSrednji
            // 
            this.chkSrednji.AutoSize = true;
            this.chkSrednji.Location = new System.Drawing.Point(214, 200);
            this.chkSrednji.Name = "chkSrednji";
            this.chkSrednji.Size = new System.Drawing.Size(71, 20);
            this.chkSrednji.TabIndex = 62;
            this.chkSrednji.Text = "Srednji";
            this.chkSrednji.UseVisualStyleBackColor = true;
            this.chkSrednji.Visible = false;
            // 
            // chkLak
            // 
            this.chkLak.AutoSize = true;
            this.chkLak.Location = new System.Drawing.Point(214, 174);
            this.chkLak.Name = "chkLak";
            this.chkLak.Size = new System.Drawing.Size(51, 20);
            this.chkLak.TabIndex = 61;
            this.chkLak.Text = "Lak";
            this.chkLak.UseVisualStyleBackColor = true;
            this.chkLak.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(403, 324);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(380, 163);
            this.dataGridView1.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label12.Location = new System.Drawing.Point(26, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(251, 38);
            this.label12.TabIndex = 55;
            this.label12.Text = "IZMENA RECEPTA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(87, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 43;
            this.label11.Text = "u min";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnIzmeni.FlatAppearance.BorderSize = 0;
            this.btnIzmeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeni.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(563, 655);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(379, 43);
            this.btnIzmeni.TabIndex = 54;
            this.btnIzmeni.Text = "Izmeni recept";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            // 
            // txtVremeKuvanja
            // 
            this.txtVremeKuvanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(167)))), ((int)(((byte)(98)))));
            this.txtVremeKuvanja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVremeKuvanja.Location = new System.Drawing.Point(39, 421);
            this.txtVremeKuvanja.Name = "txtVremeKuvanja";
            this.txtVremeKuvanja.Size = new System.Drawing.Size(42, 15);
            this.txtVremeKuvanja.TabIndex = 41;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(726, 155);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(170, 40);
            this.btnObrisi.TabIndex = 53;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Vreme Kuvanja";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(521, 155);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(161, 40);
            this.btnDodaj.TabIndex = 52;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // txtTezina
            // 
            this.txtTezina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(167)))), ((int)(((byte)(98)))));
            this.txtTezina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTezina.Location = new System.Drawing.Point(863, 50);
            this.txtTezina.Name = "txtTezina";
            this.txtTezina.Size = new System.Drawing.Size(166, 15);
            this.txtTezina.TabIndex = 38;
            this.txtTezina.Visible = false;
            // 
            // txtOpis
            // 
            this.txtOpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(167)))), ((int)(((byte)(98)))));
            this.txtOpis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpis.Location = new System.Drawing.Point(183, 274);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(151, 287);
            this.txtOpis.TabIndex = 37;
            // 
            // numericKolicina
            // 
            this.numericKolicina.BackColor = System.Drawing.Color.DarkKhaki;
            this.numericKolicina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericKolicina.ForeColor = System.Drawing.Color.SaddleBrown;
            this.numericKolicina.Location = new System.Drawing.Point(752, 99);
            this.numericKolicina.Name = "numericKolicina";
            this.numericKolicina.Size = new System.Drawing.Size(51, 22);
            this.numericKolicina.TabIndex = 51;
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(167)))), ((int)(((byte)(98)))));
            this.txtNaziv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNaziv.Location = new System.Drawing.Point(36, 205);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(166, 15);
            this.txtNaziv.TabIndex = 36;
            // 
            // txtProfilIshrane
            // 
            this.txtProfilIshrane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(167)))), ((int)(((byte)(98)))));
            this.txtProfilIshrane.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProfilIshrane.Location = new System.Drawing.Point(128, 577);
            this.txtProfilIshrane.Name = "txtProfilIshrane";
            this.txtProfilIshrane.Size = new System.Drawing.Size(206, 15);
            this.txtProfilIshrane.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tezina";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 574);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Profil Ishrane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Opis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(813, 613);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "UKUPNE KALORIJE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Naziv";
            // 
            // txtUkupneKalorije
            // 
            this.txtUkupneKalorije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(167)))), ((int)(((byte)(98)))));
            this.txtUkupneKalorije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUkupneKalorije.Enabled = false;
            this.txtUkupneKalorije.Location = new System.Drawing.Point(897, 636);
            this.txtUkupneKalorije.Name = "txtUkupneKalorije";
            this.txtUkupneKalorije.ReadOnly = true;
            this.txtUkupneKalorije.Size = new System.Drawing.Size(45, 15);
            this.txtUkupneKalorije.TabIndex = 47;
            // 
            // cbNamirnice
            // 
            this.cbNamirnice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbNamirnice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbNamirnice.FormattingEnabled = true;
            this.cbNamirnice.Location = new System.Drawing.Point(863, 17);
            this.cbNamirnice.Name = "cbNamirnice";
            this.cbNamirnice.Size = new System.Drawing.Size(200, 24);
            this.cbNamirnice.TabIndex = 46;
            this.cbNamirnice.Text = "ODABERITE NAMIRNICU";
            this.cbNamirnice.Visible = false;
            // 
            // cbMJe
            // 
            this.cbMJe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbMJe.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbMJe.FormattingEnabled = true;
            this.cbMJe.Location = new System.Drawing.Point(898, 67);
            this.cbMJe.Name = "cbMJe";
            this.cbMJe.Size = new System.Drawing.Size(86, 24);
            this.cbMJe.TabIndex = 45;
            this.cbMJe.Text = " ";
            this.cbMJe.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(748, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Kolicina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(517, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Merna Jedinica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Namirnica";
            // 
            // cbJela
            // 
            this.cbJela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbJela.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbJela.FormattingEnabled = true;
            this.cbJela.Location = new System.Drawing.Point(72, 79);
            this.cbJela.Name = "cbJela";
            this.cbJela.Size = new System.Drawing.Size(213, 24);
            this.cbJela.TabIndex = 32;
            this.cbJela.Text = "ODABERITE JELO";
            this.cbJela.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Jelo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Klijent.Properties.Resources._10823283;
            this.pictureBox1.Location = new System.Drawing.Point(332, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // cbMJ
            // 
            this.cbMJ.BackColor = System.Drawing.Color.DarkKhaki;
            this.cbMJ.BorderColor = System.Drawing.Color.SaddleBrown;
            this.cbMJ.BorderSize = 1;
            this.cbMJ.DataSource = null;
            this.cbMJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbMJ.ForeColor = System.Drawing.Color.DimGray;
            this.cbMJ.IconColor = System.Drawing.Color.SaddleBrown;
            this.cbMJ.ListBackColor = System.Drawing.Color.Khaki;
            this.cbMJ.ListTextColor = System.Drawing.Color.SaddleBrown;
            this.cbMJ.Location = new System.Drawing.Point(520, 94);
            this.cbMJ.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbMJ.Name = "cbMJ";
            this.cbMJ.Padding = new System.Windows.Forms.Padding(1);
            this.cbMJ.SelectedIndex = -1;
            this.cbMJ.SelectedItem = null;
            this.cbMJ.Size = new System.Drawing.Size(200, 31);
            this.cbMJ.TabIndex = 60;
            this.cbMJ.Texts = "";
            // 
            // cbNamirnica
            // 
            this.cbNamirnica.BackColor = System.Drawing.Color.DarkKhaki;
            this.cbNamirnica.BorderColor = System.Drawing.Color.SaddleBrown;
            this.cbNamirnica.BorderSize = 1;
            this.cbNamirnica.DataSource = null;
            this.cbNamirnica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbNamirnica.ForeColor = System.Drawing.Color.DimGray;
            this.cbNamirnica.IconColor = System.Drawing.Color.SaddleBrown;
            this.cbNamirnica.ListBackColor = System.Drawing.Color.Khaki;
            this.cbNamirnica.ListTextColor = System.Drawing.Color.SaddleBrown;
            this.cbNamirnica.Location = new System.Drawing.Point(601, 11);
            this.cbNamirnica.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbNamirnica.Name = "cbNamirnica";
            this.cbNamirnica.Padding = new System.Windows.Forms.Padding(1);
            this.cbNamirnica.SelectedIndex = -1;
            this.cbNamirnica.SelectedItem = null;
            this.cbNamirnica.Size = new System.Drawing.Size(200, 30);
            this.cbNamirnica.TabIndex = 59;
            this.cbNamirnica.Texts = "";
            // 
            // cbJelo
            // 
            this.cbJelo.BackColor = System.Drawing.Color.DarkKhaki;
            this.cbJelo.BorderColor = System.Drawing.Color.SaddleBrown;
            this.cbJelo.BorderSize = 1;
            this.cbJelo.DataSource = null;
            this.cbJelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbJelo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbJelo.IconColor = System.Drawing.Color.SaddleBrown;
            this.cbJelo.ListBackColor = System.Drawing.Color.Khaki;
            this.cbJelo.ListTextColor = System.Drawing.Color.SaddleBrown;
            this.cbJelo.Location = new System.Drawing.Point(36, 109);
            this.cbJelo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbJelo.Name = "cbJelo";
            this.cbJelo.Padding = new System.Windows.Forms.Padding(1);
            this.cbJelo.SelectedIndex = -1;
            this.cbJelo.SelectedItem = null;
            this.cbJelo.Size = new System.Drawing.Size(213, 30);
            this.cbJelo.TabIndex = 58;
            this.cbJelo.Texts = "";
            // 
            // btnIzmeniStavku
            // 
            this.btnIzmeniStavku.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnIzmeniStavku.FlatAppearance.BorderSize = 0;
            this.btnIzmeniStavku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeniStavku.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniStavku.Location = new System.Drawing.Point(524, 217);
            this.btnIzmeniStavku.Name = "btnIzmeniStavku";
            this.btnIzmeniStavku.Size = new System.Drawing.Size(372, 32);
            this.btnIzmeniStavku.TabIndex = 64;
            this.btnIzmeniStavku.Text = "Izmeni postojecu stavku";
            this.btnIzmeniStavku.UseVisualStyleBackColor = false;
            // 
            // btnSacuvajIzmenuStavke
            // 
            this.btnSacuvajIzmenuStavke.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSacuvajIzmenuStavke.Enabled = false;
            this.btnSacuvajIzmenuStavke.FlatAppearance.BorderSize = 0;
            this.btnSacuvajIzmenuStavke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvajIzmenuStavke.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajIzmenuStavke.Location = new System.Drawing.Point(520, 261);
            this.btnSacuvajIzmenuStavke.Name = "btnSacuvajIzmenuStavke";
            this.btnSacuvajIzmenuStavke.Size = new System.Drawing.Size(372, 32);
            this.btnSacuvajIzmenuStavke.TabIndex = 65;
            this.btnSacuvajIzmenuStavke.Text = "Sacuvaj izmenu stavke";
            this.btnSacuvajIzmenuStavke.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancel.Location = new System.Drawing.Point(395, 655);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 43);
            this.btnCancel.TabIndex = 66;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // rbTezak
            // 
            this.rbTezak.AutoSize = true;
            this.rbTezak.Location = new System.Drawing.Point(33, 323);
            this.rbTezak.Name = "rbTezak";
            this.rbTezak.Size = new System.Drawing.Size(66, 20);
            this.rbTezak.TabIndex = 69;
            this.rbTezak.TabStop = true;
            this.rbTezak.Text = "Tezak";
            this.rbTezak.UseVisualStyleBackColor = true;
            // 
            // rbSrednji
            // 
            this.rbSrednji.AutoSize = true;
            this.rbSrednji.Location = new System.Drawing.Point(33, 297);
            this.rbSrednji.Name = "rbSrednji";
            this.rbSrednji.Size = new System.Drawing.Size(70, 20);
            this.rbSrednji.TabIndex = 68;
            this.rbSrednji.TabStop = true;
            this.rbSrednji.Text = "Srednji";
            this.rbSrednji.UseVisualStyleBackColor = true;
            // 
            // rbLak
            // 
            this.rbLak.AutoSize = true;
            this.rbLak.Location = new System.Drawing.Point(33, 271);
            this.rbLak.Name = "rbLak";
            this.rbLak.Size = new System.Drawing.Size(50, 20);
            this.rbLak.TabIndex = 67;
            this.rbLak.TabStop = true;
            this.rbLak.Text = "Lak";
            this.rbLak.UseVisualStyleBackColor = true;
            // 
            // UCIzmenaRecepta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rbTezak);
            this.Controls.Add(this.rbSrednji);
            this.Controls.Add(this.rbLak);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSacuvajIzmenuStavke);
            this.Controls.Add(this.btnIzmeniStavku);
            this.Controls.Add(this.chkTezak);
            this.Controls.Add(this.chkSrednji);
            this.Controls.Add(this.chkLak);
            this.Controls.Add(this.cbMJ);
            this.Controls.Add(this.cbNamirnica);
            this.Controls.Add(this.cbJelo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.txtVremeKuvanja);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtTezina);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.numericKolicina);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtProfilIshrane);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUkupneKalorije);
            this.Controls.Add(this.cbNamirnice);
            this.Controls.Add(this.cbMJe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbJela);
            this.Controls.Add(this.label1);
            this.Name = "UCIzmenaRecepta";
            this.Size = new System.Drawing.Size(1016, 723);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkTezak;
        private System.Windows.Forms.CheckBox chkSrednji;
        private System.Windows.Forms.CheckBox chkLak;
        private MockUpComboBox cbMJ;
        private MockUpComboBox cbNamirnica;
        private MockUpComboBox cbJelo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.TextBox txtVremeKuvanja;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtTezina;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.NumericUpDown numericKolicina;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtProfilIshrane;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUkupneKalorije;
        private System.Windows.Forms.ComboBox cbNamirnice;
        private System.Windows.Forms.ComboBox cbMJe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbJela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzmeniStavku;
        private Button btnSacuvajIzmenuStavke;
        private Button btnCancel;
        private RadioButton rbTezak;
        private RadioButton rbSrednji;
        private RadioButton rbLak;

        public CheckBox ChkTezak { get => chkTezak; set => chkTezak = value; }
        public CheckBox ChkSrednji { get => chkSrednji; set => chkSrednji = value; }
        public CheckBox ChkLak { get => chkLak; set => chkLak = value; }
        public MockUpComboBox CbMJ { get => cbMJ; set => cbMJ = value; }
        public MockUpComboBox CbNamirnica { get => cbNamirnica; set => cbNamirnica = value; }
        public MockUpComboBox CbJelo { get => cbJelo; set => cbJelo = value; }
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
        public Label Label12 { get => label12; set => label12 = value; }
        public Label Label11 { get => label11; set => label11 = value; }
        public Button BtnIzmeni { get => btnIzmeni; set => btnIzmeni = value; }
        public TextBox TxtVremeKuvanja { get => txtVremeKuvanja; set => txtVremeKuvanja = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public Label Label10 { get => label10; set => label10 = value; }
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
        public TextBox TxtTezina { get => txtTezina; set => txtTezina = value; }
        public TextBox TxtOpis { get => txtOpis; set => txtOpis = value; }
        public NumericUpDown NumericKolicina { get => numericKolicina; set => numericKolicina = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public TextBox TxtProfilIshrane { get => txtProfilIshrane; set => txtProfilIshrane = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label9 { get => label9; set => label9 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label8 { get => label8; set => label8 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public TextBox TxtUkupneKalorije { get => txtUkupneKalorije; set => txtUkupneKalorije = value; }
        public ComboBox CbNamirnice { get => cbNamirnice; set => cbNamirnice = value; }
        public ComboBox CbMJe { get => cbMJe; set => cbMJe = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public ComboBox CbJela { get => cbJela; set => cbJela = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Button BtnIzmeniStavku { get => btnIzmeniStavku; set => btnIzmeniStavku = value; }
        public Button BtnSacuvajIzmenuStavke { get => btnSacuvajIzmenuStavke; set => btnSacuvajIzmenuStavke = value; }
        public Button BtnCancel { get => btnCancel; set => btnCancel = value; }
        public RadioButton RbTezak { get => rbTezak; set => rbTezak = value; }
        public RadioButton RbSrednji { get => rbSrednji; set => rbSrednji = value; }
        public RadioButton RbLak { get => rbLak; set => rbLak = value; }
    }
}
