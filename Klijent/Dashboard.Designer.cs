using System.Windows.Forms;

namespace Klijent
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbRecept = new System.Windows.Forms.PictureBox();
            this.pbNamirnica = new System.Windows.Forms.PictureBox();
            this.pbJelo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNamirnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome,";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Klijent.Properties.Resources.free_exit_logout_icon_2861_thumb;
            this.pictureBox2.Location = new System.Drawing.Point(100, 472);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbRecept
            // 
            this.pbRecept.Image = global::Klijent.Properties.Resources.roze;
            this.pbRecept.Location = new System.Drawing.Point(112, 187);
            this.pbRecept.Name = "pbRecept";
            this.pbRecept.Size = new System.Drawing.Size(144, 110);
            this.pbRecept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRecept.TabIndex = 11;
            this.pbRecept.TabStop = false;
            this.pbRecept.Click += new System.EventHandler(this.pbRecept_Click);
            // 
            // pbNamirnica
            // 
            this.pbNamirnica.Image = global::Klijent.Properties.Resources.narandzasti__1_;
            this.pbNamirnica.Location = new System.Drawing.Point(355, 71);
            this.pbNamirnica.Name = "pbNamirnica";
            this.pbNamirnica.Size = new System.Drawing.Size(165, 119);
            this.pbNamirnica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNamirnica.TabIndex = 9;
            this.pbNamirnica.TabStop = false;
            this.pbNamirnica.Click += new System.EventHandler(this.pbNamirnica_Click);
            // 
            // pbJelo
            // 
            this.pbJelo.Image = global::Klijent.Properties.Resources.zeleni;
            this.pbJelo.Location = new System.Drawing.Point(195, 83);
            this.pbJelo.Name = "pbJelo";
            this.pbJelo.Size = new System.Drawing.Size(182, 142);
            this.pbJelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJelo.TabIndex = 7;
            this.pbJelo.TabStop = false;
            this.pbJelo.Click += new System.EventHandler(this.pbJelo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Klijent.Properties.Resources.Cooking_Recipe_PNG_Download_Image;
            this.pictureBox1.Location = new System.Drawing.Point(137, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(9, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Log Out";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 629);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbRecept);
            this.Controls.Add(this.pbNamirnica);
            this.Controls.Add(this.pbJelo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNamirnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private PictureBox pbJelo;
        private PictureBox pbNamirnica;
        private PictureBox pbRecept;
        private PictureBox pictureBox2;
        private Label label2;

        public Label Label1 { get => label1; set => label1 = value; }
        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
        public PictureBox PBJelo { get => pbJelo; set => pbJelo = value; }
        public PictureBox PBNamirnica { get => pbNamirnica; set => pbNamirnica = value; }
        public PictureBox PBRecept { get => pbRecept; set => pbRecept = value; }
        public PictureBox PictureBox2 { get => pictureBox2; set => pictureBox2 = value; }
    }
}