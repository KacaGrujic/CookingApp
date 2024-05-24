using System.Windows.Forms;

namespace Klijent.UserControls
{
    partial class UCNamirnicaMain
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlDash = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.dgvNamirniceList = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            this.pnlDash.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamirniceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlDash);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(575, 519);
            this.pnlMain.TabIndex = 5;
            // 
            // pnlDash
            // 
            this.pnlDash.Controls.Add(this.panel);
            this.pnlDash.Controls.Add(this.pictureBox2);
            this.pnlDash.Location = new System.Drawing.Point(13, -10);
            this.pnlDash.Name = "pnlDash";
            this.pnlDash.Size = new System.Drawing.Size(581, 600);
            this.pnlDash.TabIndex = 3;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dgvNamirniceList);
            this.panel.Location = new System.Drawing.Point(12, 134);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(458, 354);
            this.panel.TabIndex = 5;
            // 
            // dgvNamirniceList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvNamirniceList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNamirniceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNamirniceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNamirniceList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNamirniceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNamirniceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNamirniceList.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNamirniceList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNamirniceList.EnableHeadersVisualStyles = false;
            this.dgvNamirniceList.Location = new System.Drawing.Point(16, 34);
            this.dgvNamirniceList.Name = "dgvNamirniceList";
            this.dgvNamirniceList.RowHeadersWidth = 51;
            this.dgvNamirniceList.RowTemplate.Height = 24;
            this.dgvNamirniceList.Size = new System.Drawing.Size(433, 165);
            this.dgvNamirniceList.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Klijent.Properties.Resources._360_F_649088106_dNidCj4QMhNAavuXXluy7JLMbjtGPGHo;
            this.pictureBox2.Location = new System.Drawing.Point(68, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(490, 393);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // UCNamirnicaMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "UCNamirnicaMain";
            this.Size = new System.Drawing.Size(575, 519);
            this.pnlMain.ResumeLayout(false);
            this.pnlDash.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamirniceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMain;
        private Panel pnlDash;
        private Panel panel;
        private DataGridView dgvNamirniceList;
        private PictureBox pictureBox2;

        public Panel PnlMain { get => pnlMain; set => pnlMain = value; }
        public Panel PnlDash { get => pnlDash; set => pnlDash = value; }
        public PictureBox PictureBox2 { get => pictureBox2; set => pictureBox2 = value; }

        public DataGridView DgvNamirniceList { get => dgvNamirniceList; set => dgvNamirniceList = value; }
        public Panel Panel { get => panel; set => panel = value; }
    }
}
