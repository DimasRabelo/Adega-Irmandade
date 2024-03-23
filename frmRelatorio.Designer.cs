namespace Adega_Irmandade
{
    partial class frmRelatorio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.dgvRelatorios = new System.Windows.Forms.DataGridView();
            this.pctFechar = new System.Windows.Forms.PictureBox();
            this.chkFunc = new System.Windows.Forms.CheckBox();
            this.lblRelaStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAno = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = global::Adega_Irmandade.Properties.Resources.adegalogo_2;
            this.pctLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctLogo.Location = new System.Drawing.Point(601, 268);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(225, 319);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 89;
            this.pctLogo.TabStop = false;
            // 
            // dgvRelatorios
            // 
            this.dgvRelatorios.AllowUserToResizeRows = false;
            this.dgvRelatorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRelatorios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRelatorios.BackgroundColor = System.Drawing.Color.Black;
            this.dgvRelatorios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRelatorios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRelatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRelatorios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRelatorios.GridColor = System.Drawing.Color.White;
            this.dgvRelatorios.Location = new System.Drawing.Point(12, 314);
            this.dgvRelatorios.MultiSelect = false;
            this.dgvRelatorios.Name = "dgvRelatorios";
            this.dgvRelatorios.ReadOnly = true;
            this.dgvRelatorios.RowHeadersVisible = false;
            this.dgvRelatorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelatorios.Size = new System.Drawing.Size(583, 214);
            this.dgvRelatorios.TabIndex = 88;
            this.dgvRelatorios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRelatorios_CellFormatting);
            // 
            // pctFechar
            // 
            this.pctFechar.BackColor = System.Drawing.Color.Transparent;
            this.pctFechar.Image = global::Adega_Irmandade.Properties.Resources.botaoFechar;
            this.pctFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctFechar.Location = new System.Drawing.Point(770, 12);
            this.pctFechar.Name = "pctFechar";
            this.pctFechar.Size = new System.Drawing.Size(39, 30);
            this.pctFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFechar.TabIndex = 84;
            this.pctFechar.TabStop = false;
            this.pctFechar.Click += new System.EventHandler(this.pctFechar_Click);
            // 
            // chkFunc
            // 
            this.chkFunc.AutoSize = true;
            this.chkFunc.BackColor = System.Drawing.Color.Transparent;
            this.chkFunc.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFunc.ForeColor = System.Drawing.Color.White;
            this.chkFunc.Location = new System.Drawing.Point(130, 237);
            this.chkFunc.Name = "chkFunc";
            this.chkFunc.Size = new System.Drawing.Size(108, 31);
            this.chkFunc.TabIndex = 83;
            this.chkFunc.Text = "ATIVO?";
            this.chkFunc.UseVisualStyleBackColor = false;
            this.chkFunc.CheckedChanged += new System.EventHandler(this.chkFunc_CheckedChanged);
            // 
            // lblRelaStatus
            // 
            this.lblRelaStatus.AutoSize = true;
            this.lblRelaStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblRelaStatus.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelaStatus.ForeColor = System.Drawing.Color.White;
            this.lblRelaStatus.Location = new System.Drawing.Point(21, 238);
            this.lblRelaStatus.Name = "lblRelaStatus";
            this.lblRelaStatus.Size = new System.Drawing.Size(103, 27);
            this.lblRelaStatus.TabIndex = 82;
            this.lblRelaStatus.Text = "STATUS:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 50);
            this.label1.TabIndex = 79;
            this.label1.Text = "RELATÓRIOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkAno
            // 
            this.chkAno.AutoSize = true;
            this.chkAno.BackColor = System.Drawing.Color.Transparent;
            this.chkAno.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAno.ForeColor = System.Drawing.Color.White;
            this.chkAno.Location = new System.Drawing.Point(155, 186);
            this.chkAno.Name = "chkAno";
            this.chkAno.Size = new System.Drawing.Size(108, 31);
            this.chkAno.TabIndex = 90;
            this.chkAno.Text = "ATIVO?";
            this.chkAno.UseVisualStyleBackColor = false;
            this.chkAno.CheckedChanged += new System.EventHandler(this.chkAno_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 27);
            this.label2.TabIndex = 91;
            this.label2.Text = "STATUS:";
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adega_Irmandade.Properties.Resources.fundofumacaCad;
            this.ClientSize = new System.Drawing.Size(833, 630);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkAno);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.dgvRelatorios);
            this.Controls.Add(this.pctFechar);
            this.Controls.Add(this.chkFunc);
            this.Controls.Add(this.lblRelaStatus);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIOS";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.DataGridView dgvRelatorios;
        private System.Windows.Forms.PictureBox pctFechar;
        private System.Windows.Forms.CheckBox chkFunc;
        private System.Windows.Forms.Label lblRelaStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAno;
        private System.Windows.Forms.Label label2;
    }
}