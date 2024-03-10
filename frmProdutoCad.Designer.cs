namespace Adega_Irmandade
{
    partial class frmProdutoCad
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
            this.mkdCadDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.btnCadSalvar = new System.Windows.Forms.Button();
            this.pctFechar = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCadFacebook = new System.Windows.Forms.TextBox();
            this.cmbCadStatus = new System.Windows.Forms.ComboBox();
            this.cmbCadNivel = new System.Windows.Forms.ComboBox();
            this.txtCadCargo = new System.Windows.Forms.TextBox();
            this.txtCadNome = new System.Windows.Forms.TextBox();
            this.lblCadEndereco = new System.Windows.Forms.Label();
            this.lblCadFacebook = new System.Windows.Forms.Label();
            this.lblCadStatus = new System.Windows.Forms.Label();
            this.lblCadNivel = new System.Windows.Forms.Label();
            this.lblCadEmail = new System.Windows.Forms.Label();
            this.lblCadCargo = new System.Windows.Forms.Label();
            this.lblCadDataNasc = new System.Windows.Forms.Label();
            this.lblCadNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCadCadastrar = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // mkdCadDataNasc
            // 
            this.mkdCadDataNasc.Enabled = false;
            this.mkdCadDataNasc.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdCadDataNasc.Location = new System.Drawing.Point(676, 461);
            this.mkdCadDataNasc.Mask = "00/00/0000";
            this.mkdCadDataNasc.Name = "mkdCadDataNasc";
            this.mkdCadDataNasc.Size = new System.Drawing.Size(131, 34);
            this.mkdCadDataNasc.TabIndex = 104;
            this.mkdCadDataNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkdCadDataNasc.ValidatingType = typeof(System.DateTime);
            this.mkdCadDataNasc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkdCadDataNasc_MaskInputRejected);
            // 
            // btnCadSalvar
            // 
            this.btnCadSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadSalvar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadSalvar.ForeColor = System.Drawing.Color.White;
            this.btnCadSalvar.Location = new System.Drawing.Point(854, 598);
            this.btnCadSalvar.Name = "btnCadSalvar";
            this.btnCadSalvar.Size = new System.Drawing.Size(125, 40);
            this.btnCadSalvar.TabIndex = 103;
            this.btnCadSalvar.Text = "SALVAR";
            this.btnCadSalvar.UseVisualStyleBackColor = false;
            this.btnCadSalvar.Click += new System.EventHandler(this.btnCadSalvar_Click);
            // 
            // pctFechar
            // 
            this.pctFechar.BackColor = System.Drawing.Color.Transparent;
            this.pctFechar.Image = global::Adega_Irmandade.Properties.Resources.botaoFechar;
            this.pctFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctFechar.Location = new System.Drawing.Point(1151, 27);
            this.pctFechar.Name = "pctFechar";
            this.pctFechar.Size = new System.Drawing.Size(39, 30);
            this.pctFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFechar.TabIndex = 102;
            this.pctFechar.TabStop = false;
            this.pctFechar.Click += new System.EventHandler(this.pctFechar_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = global::Adega_Irmandade.Properties.Resources.adegalogo_2;
            this.pctLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctLogo.Location = new System.Drawing.Point(896, 63);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(294, 204);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 101;
            this.pctLogo.TabStop = false;
            this.pctLogo.Click += new System.EventHandler(this.pctLogo_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(998, 598);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 40);
            this.btnLimpar.TabIndex = 100;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCadFacebook
            // 
            this.txtCadFacebook.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCadFacebook.Enabled = false;
            this.txtCadFacebook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadFacebook.Location = new System.Drawing.Point(303, 461);
            this.txtCadFacebook.Name = "txtCadFacebook";
            this.txtCadFacebook.Size = new System.Drawing.Size(245, 26);
            this.txtCadFacebook.TabIndex = 97;
            this.txtCadFacebook.TextChanged += new System.EventHandler(this.txtCadFacebook_TextChanged);
            // 
            // cmbCadStatus
            // 
            this.cmbCadStatus.Enabled = false;
            this.cmbCadStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCadStatus.FormattingEnabled = true;
            this.cmbCadStatus.Items.AddRange(new object[] {
            "ATIVO",
            "DESATIVADO"});
            this.cmbCadStatus.Location = new System.Drawing.Point(46, 353);
            this.cmbCadStatus.Name = "cmbCadStatus";
            this.cmbCadStatus.Size = new System.Drawing.Size(204, 26);
            this.cmbCadStatus.TabIndex = 93;
            this.cmbCadStatus.SelectedIndexChanged += new System.EventHandler(this.cmbCadStatus_SelectedIndexChanged);
            // 
            // cmbCadNivel
            // 
            this.cmbCadNivel.Enabled = false;
            this.cmbCadNivel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCadNivel.FormattingEnabled = true;
            this.cmbCadNivel.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "USUÁRIO"});
            this.cmbCadNivel.Location = new System.Drawing.Point(421, 253);
            this.cmbCadNivel.Name = "cmbCadNivel";
            this.cmbCadNivel.Size = new System.Drawing.Size(375, 26);
            this.cmbCadNivel.TabIndex = 92;
            this.cmbCadNivel.SelectedIndexChanged += new System.EventHandler(this.cmbCadNivel_SelectedIndexChanged);
            // 
            // txtCadCargo
            // 
            this.txtCadCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCadCargo.Enabled = false;
            this.txtCadCargo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadCargo.Location = new System.Drawing.Point(46, 253);
            this.txtCadCargo.Name = "txtCadCargo";
            this.txtCadCargo.Size = new System.Drawing.Size(277, 26);
            this.txtCadCargo.TabIndex = 89;
            this.txtCadCargo.TextChanged += new System.EventHandler(this.txtCadCargo_TextChanged);
            // 
            // txtCadNome
            // 
            this.txtCadNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCadNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadNome.Location = new System.Drawing.Point(46, 148);
            this.txtCadNome.Name = "txtCadNome";
            this.txtCadNome.Size = new System.Drawing.Size(750, 26);
            this.txtCadNome.TabIndex = 88;
            this.txtCadNome.TextChanged += new System.EventHandler(this.txtCadNome_TextChanged);
            // 
            // lblCadEndereco
            // 
            this.lblCadEndereco.AutoSize = true;
            this.lblCadEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblCadEndereco.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadEndereco.ForeColor = System.Drawing.Color.White;
            this.lblCadEndereco.Location = new System.Drawing.Point(43, 431);
            this.lblCadEndereco.Name = "lblCadEndereco";
            this.lblCadEndereco.Size = new System.Drawing.Size(207, 27);
            this.lblCadEndereco.TabIndex = 86;
            this.lblCadEndereco.Text = "PREÇO DE VENDA:";
            this.lblCadEndereco.Click += new System.EventHandler(this.lblCadEndereco_Click);
            // 
            // lblCadFacebook
            // 
            this.lblCadFacebook.AutoSize = true;
            this.lblCadFacebook.BackColor = System.Drawing.Color.Transparent;
            this.lblCadFacebook.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadFacebook.ForeColor = System.Drawing.Color.White;
            this.lblCadFacebook.Location = new System.Drawing.Point(347, 431);
            this.lblCadFacebook.Name = "lblCadFacebook";
            this.lblCadFacebook.Size = new System.Drawing.Size(167, 27);
            this.lblCadFacebook.TabIndex = 83;
            this.lblCadFacebook.Text = "FORNECEDOR:";
            this.lblCadFacebook.Click += new System.EventHandler(this.lblCadFacebook_Click);
            // 
            // lblCadStatus
            // 
            this.lblCadStatus.AutoSize = true;
            this.lblCadStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblCadStatus.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadStatus.ForeColor = System.Drawing.Color.White;
            this.lblCadStatus.Location = new System.Drawing.Point(41, 323);
            this.lblCadStatus.Name = "lblCadStatus";
            this.lblCadStatus.Size = new System.Drawing.Size(103, 27);
            this.lblCadStatus.TabIndex = 82;
            this.lblCadStatus.Text = "STATUS:";
            this.lblCadStatus.Click += new System.EventHandler(this.lblCadStatus_Click);
            // 
            // lblCadNivel
            // 
            this.lblCadNivel.AutoSize = true;
            this.lblCadNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblCadNivel.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadNivel.ForeColor = System.Drawing.Color.White;
            this.lblCadNivel.Location = new System.Drawing.Point(416, 223);
            this.lblCadNivel.Name = "lblCadNivel";
            this.lblCadNivel.Size = new System.Drawing.Size(144, 27);
            this.lblCadNivel.TabIndex = 79;
            this.lblCadNivel.Text = "CATEGORIA:";
            this.lblCadNivel.Click += new System.EventHandler(this.lblCadNivel_Click);
            // 
            // lblCadEmail
            // 
            this.lblCadEmail.AutoSize = true;
            this.lblCadEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCadEmail.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadEmail.ForeColor = System.Drawing.Color.White;
            this.lblCadEmail.Location = new System.Drawing.Point(572, 323);
            this.lblCadEmail.Name = "lblCadEmail";
            this.lblCadEmail.Size = new System.Drawing.Size(226, 27);
            this.lblCadEmail.TabIndex = 77;
            this.lblCadEmail.Text = "PREÇO DE COMPRA:";
            this.lblCadEmail.Click += new System.EventHandler(this.lblCadEmail_Click);
            // 
            // lblCadCargo
            // 
            this.lblCadCargo.AutoSize = true;
            this.lblCadCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCargo.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCargo.ForeColor = System.Drawing.Color.White;
            this.lblCadCargo.Location = new System.Drawing.Point(46, 223);
            this.lblCadCargo.Name = "lblCadCargo";
            this.lblCadCargo.Size = new System.Drawing.Size(144, 27);
            this.lblCadCargo.TabIndex = 76;
            this.lblCadCargo.Text = "DESCRIÇÃO:";
            this.lblCadCargo.Click += new System.EventHandler(this.lblCadCargo_Click);
            // 
            // lblCadDataNasc
            // 
            this.lblCadDataNasc.AutoSize = true;
            this.lblCadDataNasc.BackColor = System.Drawing.Color.Transparent;
            this.lblCadDataNasc.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadDataNasc.ForeColor = System.Drawing.Color.White;
            this.lblCadDataNasc.Location = new System.Drawing.Point(572, 431);
            this.lblCadDataNasc.Name = "lblCadDataNasc";
            this.lblCadDataNasc.Size = new System.Drawing.Size(237, 27);
            this.lblCadDataNasc.TabIndex = 75;
            this.lblCadDataNasc.Text = "DATA RECEBIMENTO:";
            this.lblCadDataNasc.Click += new System.EventHandler(this.lblCadDataNasc_Click);
            // 
            // lblCadNome
            // 
            this.lblCadNome.AutoSize = true;
            this.lblCadNome.BackColor = System.Drawing.Color.Transparent;
            this.lblCadNome.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadNome.ForeColor = System.Drawing.Color.White;
            this.lblCadNome.Location = new System.Drawing.Point(46, 118);
            this.lblCadNome.Name = "lblCadNome";
            this.lblCadNome.Size = new System.Drawing.Size(230, 27);
            this.lblCadNome.TabIndex = 74;
            this.lblCadNome.Text = "NOME DO PRODUTO:";
            this.lblCadNome.Click += new System.EventHandler(this.lblCadNome_Click);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(246, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 73;
            this.label2.Text = "PRODUTOS\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCadCadastrar
            // 
            this.lblCadCadastrar.AllowDrop = true;
            this.lblCadCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCadastrar.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCadastrar.ForeColor = System.Drawing.Color.White;
            this.lblCadCadastrar.Location = new System.Drawing.Point(46, 44);
            this.lblCadCadastrar.Name = "lblCadCadastrar";
            this.lblCadCadastrar.Size = new System.Drawing.Size(178, 40);
            this.lblCadCadastrar.TabIndex = 72;
            this.lblCadCadastrar.Text = "CADASTRAR\r\n";
            this.lblCadCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCadCadastrar.Click += new System.EventHandler(this.lblCadCadastrar_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(46, 571);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(154, 26);
            this.maskedTextBox1.TabIndex = 106;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 54);
            this.label1.TabIndex = 107;
            this.label1.Text = "HORA \r\nCONTATO:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(-15, -15);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 108;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(676, 353);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 109;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(51, 461);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 110;
            // 
            // frmProdutoCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adega_Irmandade.Properties.Resources.fundofumacaCad;
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.mkdCadDataNasc);
            this.Controls.Add(this.btnCadSalvar);
            this.Controls.Add(this.pctFechar);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtCadFacebook);
            this.Controls.Add(this.cmbCadStatus);
            this.Controls.Add(this.cmbCadNivel);
            this.Controls.Add(this.txtCadCargo);
            this.Controls.Add(this.txtCadNome);
            this.Controls.Add(this.lblCadEndereco);
            this.Controls.Add(this.lblCadFacebook);
            this.Controls.Add(this.lblCadStatus);
            this.Controls.Add(this.lblCadNivel);
            this.Controls.Add(this.lblCadEmail);
            this.Controls.Add(this.lblCadCargo);
            this.Controls.Add(this.lblCadDataNasc);
            this.Controls.Add(this.lblCadNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCadCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProdutoCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdutoCad";
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mkdCadDataNasc;
        private System.Windows.Forms.Button btnCadSalvar;
        private System.Windows.Forms.PictureBox pctFechar;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtCadFacebook;
        private System.Windows.Forms.ComboBox cmbCadStatus;
        private System.Windows.Forms.ComboBox cmbCadNivel;
        private System.Windows.Forms.TextBox txtCadCargo;
        private System.Windows.Forms.TextBox txtCadNome;
        private System.Windows.Forms.Label lblCadEndereco;
        private System.Windows.Forms.Label lblCadFacebook;
        private System.Windows.Forms.Label lblCadStatus;
        private System.Windows.Forms.Label lblCadNivel;
        private System.Windows.Forms.Label lblCadEmail;
        private System.Windows.Forms.Label lblCadCargo;
        private System.Windows.Forms.Label lblCadDataNasc;
        private System.Windows.Forms.Label lblCadNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCadCadastrar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}