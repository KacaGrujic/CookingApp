using System.Windows.Forms;

namespace Klijent.UserControls
{
    partial class UCIzmenaJela
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
            this.cbKuhinja = new Klijent.UserControls.MockUpComboBox();
            this.cbVrstaJela = new Klijent.UserControls.MockUpComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKuhinja
            // 
            this.cbKuhinja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbKuhinja.BorderColor = System.Drawing.Color.DarkGreen;
            this.cbKuhinja.BorderSize = 1;
            this.cbKuhinja.DataSource = null;
            this.cbKuhinja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbKuhinja.ForeColor = System.Drawing.Color.DimGray;
            this.cbKuhinja.IconColor = System.Drawing.Color.DarkGreen;
            this.cbKuhinja.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbKuhinja.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbKuhinja.Location = new System.Drawing.Point(333, 194);
            this.cbKuhinja.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbKuhinja.Name = "cbKuhinja";
            this.cbKuhinja.Padding = new System.Windows.Forms.Padding(1);
            this.cbKuhinja.SelectedIndex = -1;
            this.cbKuhinja.SelectedItem = null;
            this.cbKuhinja.Size = new System.Drawing.Size(208, 30);
            this.cbKuhinja.TabIndex = 28;
            this.cbKuhinja.Texts = "";
            // 
            // cbVrstaJela
            // 
            this.cbVrstaJela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbVrstaJela.BorderColor = System.Drawing.Color.DarkGreen;
            this.cbVrstaJela.BorderSize = 1;
            this.cbVrstaJela.DataSource = null;
            this.cbVrstaJela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbVrstaJela.ForeColor = System.Drawing.Color.DimGray;
            this.cbVrstaJela.IconColor = System.Drawing.Color.DarkGreen;
            this.cbVrstaJela.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbVrstaJela.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbVrstaJela.Location = new System.Drawing.Point(67, 194);
            this.cbVrstaJela.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbVrstaJela.Name = "cbVrstaJela";
            this.cbVrstaJela.Padding = new System.Windows.Forms.Padding(1);
            this.cbVrstaJela.SelectedIndex = -1;
            this.cbVrstaJela.SelectedItem = null;
            this.cbVrstaJela.Size = new System.Drawing.Size(219, 30);
            this.cbVrstaJela.TabIndex = 27;
            this.cbVrstaJela.Texts = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(461, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "KUHINJA";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnIzmeni.FlatAppearance.BorderSize = 0;
            this.btnIzmeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeni.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.ForeColor = System.Drawing.Color.DimGray;
            this.btnIzmeni.Location = new System.Drawing.Point(64, 283);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(477, 39);
            this.btnIzmeni.TabIndex = 25;
            this.btnIzmeni.Text = "IZMENI JELO";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 45);
            this.label1.TabIndex = 21;
            this.label1.Text = "Izmena jela";
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNaziv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNaziv.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(133, 105);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(310, 35);
            this.txtNaziv.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(62, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "VRSTA JELA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(256, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "NAZIV";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Klijent.Properties.Resources.istockphoto_1339324933_612x6124;
            this.pictureBox1.Location = new System.Drawing.Point(98, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancel.Location = new System.Drawing.Point(180, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(253, 26);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // UCIzmenaJela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbKuhinja);
            this.Controls.Add(this.cbVrstaJela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UCIzmenaJela";
            this.Size = new System.Drawing.Size(611, 536);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MockUpComboBox cbKuhinja;
        private MockUpComboBox cbVrstaJela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Button btnCancel;

        public MockUpComboBox CbKuhinja { get => cbKuhinja; set => cbKuhinja = value; }
        public MockUpComboBox CbVrstaJela { get => cbVrstaJela; set => cbVrstaJela = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Button BtnIzmeni { get => btnIzmeni; set => btnIzmeni = value; }
        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Button BtnCancel { get => btnCancel; set => btnCancel = value; }
    }
}
