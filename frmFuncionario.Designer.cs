namespace Adega_Irmandade
{
    partial class frmFuncionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFuncNome = new System.Windows.Forms.Label();
            this.txtCadNome = new System.Windows.Forms.TextBox();
            this.lblFuncStatus = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.pctFechar = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "FUNCIONÁRIOS\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFuncNome
            // 
            this.lblFuncNome.AutoSize = true;
            this.lblFuncNome.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncNome.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncNome.ForeColor = System.Drawing.Color.White;
            this.lblFuncNome.Location = new System.Drawing.Point(139, 523);
            this.lblFuncNome.Name = "lblFuncNome";
            this.lblFuncNome.Size = new System.Drawing.Size(82, 27);
            this.lblFuncNome.TabIndex = 69;
            this.lblFuncNome.Text = "NOME:";
            // 
            // txtCadNome
            // 
            this.txtCadNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCadNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadNome.Location = new System.Drawing.Point(227, 523);
            this.txtCadNome.Name = "txtCadNome";
            this.txtCadNome.Size = new System.Drawing.Size(750, 27);
            this.txtCadNome.TabIndex = 70;
            this.txtCadNome.TextChanged += new System.EventHandler(this.txtCadNome_TextChanged);
            // 
            // lblFuncStatus
            // 
            this.lblFuncStatus.AutoSize = true;
            this.lblFuncStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncStatus.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncStatus.ForeColor = System.Drawing.Color.White;
            this.lblFuncStatus.Location = new System.Drawing.Point(215, 584);
            this.lblFuncStatus.Name = "lblFuncStatus";
            this.lblFuncStatus.Size = new System.Drawing.Size(103, 27);
            this.lblFuncStatus.TabIndex = 71;
            this.lblFuncStatus.Text = "STATUS:";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.BackColor = System.Drawing.Color.Transparent;
            this.chkAtivo.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.ForeColor = System.Drawing.Color.White;
            this.chkAtivo.Location = new System.Drawing.Point(335, 583);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(108, 31);
            this.chkAtivo.TabIndex = 72;
            this.chkAtivo.Text = "ATIVO?";
            this.chkAtivo.UseVisualStyleBackColor = false;
            this.chkAtivo.CheckedChanged += new System.EventHandler(this.chkAtivo_CheckedChanged);
            // 
            // pctFechar
            // 
            this.pctFechar.BackColor = System.Drawing.Color.Transparent;
            this.pctFechar.Image = global::Adega_Irmandade.Properties.Resources.botaoFechar;
            this.pctFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctFechar.Location = new System.Drawing.Point(1169, 14);
            this.pctFechar.Name = "pctFechar";
            this.pctFechar.Size = new System.Drawing.Size(39, 30);
            this.pctFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFechar.TabIndex = 73;
            this.pctFechar.TabStop = false;
            this.pctFechar.Click += new System.EventHandler(this.pctFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Location = new System.Drawing.Point(1032, 583);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(170, 40);
            this.btnExcluir.TabIndex = 76;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAlterar.Location = new System.Drawing.Point(856, 583);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(170, 40);
            this.btnAlterar.TabIndex = 75;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Location = new System.Drawing.Point(680, 583);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(170, 40);
            this.btnCadastrar.TabIndex = 74;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = global::Adega_Irmandade.Properties.Resources.adegalogo_2;
            this.pctLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctLogo.Location = new System.Drawing.Point(983, 67);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(225, 204);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 78;
            this.pctLogo.TabStop = false;
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToResizeRows = false;
            this.dgvFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFuncionario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFuncionario.BackgroundColor = System.Drawing.Color.Black;
            this.dgvFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncionario.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFuncionario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFuncionario.EnableHeadersVisualStyles = false;
            this.dgvFuncionario.GridColor = System.Drawing.Color.White;
            this.dgvFuncionario.Location = new System.Drawing.Point(32, 67);
            this.dgvFuncionario.MultiSelect = false;
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.RowHeadersVisible = false;
            this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionario.Size = new System.Drawing.Size(945, 430);
            this.dgvFuncionario.TabIndex = 79;
            this.dgvFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellClick);
            this.dgvFuncionario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvFuncionario_CellFormatting);
           
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adega_Irmandade.Properties.Resources.fundofumacaCad;
            this.ClientSize = new System.Drawing.Size(1220, 630);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pctFechar);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.lblFuncStatus);
            this.Controls.Add(this.txtCadNome);
            this.Controls.Add(this.lblFuncNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFuncionario";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFuncNome;
        private System.Windows.Forms.TextBox txtCadNome;
        private System.Windows.Forms.Label lblFuncStatus;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.PictureBox pctFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.DataGridView dgvFuncionario;
    }
}