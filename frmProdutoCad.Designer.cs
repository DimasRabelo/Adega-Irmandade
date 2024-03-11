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
            this.mkdCadDataRecebimento = new System.Windows.Forms.MaskedTextBox();
            this.btnCadSalvar = new System.Windows.Forms.Button();
            this.pctFechar = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCadFornecedor = new System.Windows.Forms.TextBox();
            this.cmbCadStatus = new System.Windows.Forms.ComboBox();
            this.cmbCadCategoria = new System.Windows.Forms.ComboBox();
            this.txtCadDescricao = new System.Windows.Forms.TextBox();
            this.txtCadProduto = new System.Windows.Forms.TextBox();
            this.lblCadPrecoVenda = new System.Windows.Forms.Label();
            this.lblCadFornecedor = new System.Windows.Forms.Label();
            this.lblCadStatus = new System.Windows.Forms.Label();
            this.lblCadCategoria = new System.Windows.Forms.Label();
            this.lblCadPrecoCompra = new System.Windows.Forms.Label();
            this.lblCadDescricao = new System.Windows.Forms.Label();
            this.lblCadDataRecebimento = new System.Windows.Forms.Label();
            this.lblCadProduto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCadCadastrar = new System.Windows.Forms.Label();
            this.mksHoraRecebimento = new System.Windows.Forms.MaskedTextBox();
            this.lblCadRecebimento = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nudPrecoCompra = new System.Windows.Forms.NumericUpDown();
            this.nudPrecoVenda = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // mkdCadDataRecebimento
            // 
            this.mkdCadDataRecebimento.Enabled = false;
            this.mkdCadDataRecebimento.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdCadDataRecebimento.Location = new System.Drawing.Point(676, 461);
            this.mkdCadDataRecebimento.Mask = "00/00/0000";
            this.mkdCadDataRecebimento.Name = "mkdCadDataRecebimento";
            this.mkdCadDataRecebimento.Size = new System.Drawing.Size(131, 34);
            this.mkdCadDataRecebimento.TabIndex = 104;
            this.mkdCadDataRecebimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkdCadDataRecebimento.ValidatingType = typeof(System.DateTime);
            this.mkdCadDataRecebimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkdCadDataNasc_MaskInputRejected);
            // 
            // btnCadSalvar
            // 
            this.btnCadSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadSalvar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadSalvar.ForeColor = System.Drawing.Color.White;
            this.btnCadSalvar.Location = new System.Drawing.Point(336, 562);
            this.btnCadSalvar.Name = "btnCadSalvar";
            this.btnCadSalvar.Size = new System.Drawing.Size(212, 66);
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
            this.pctLogo.Size = new System.Drawing.Size(294, 505);
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
            this.btnLimpar.Location = new System.Drawing.Point(597, 562);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(212, 66);
            this.btnLimpar.TabIndex = 100;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCadFornecedor
            // 
            this.txtCadFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCadFornecedor.Enabled = false;
            this.txtCadFornecedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadFornecedor.Location = new System.Drawing.Point(302, 469);
            this.txtCadFornecedor.Name = "txtCadFornecedor";
            this.txtCadFornecedor.Size = new System.Drawing.Size(245, 26);
            this.txtCadFornecedor.TabIndex = 97;
            this.txtCadFornecedor.TextChanged += new System.EventHandler(this.txtCadFacebook_TextChanged);
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
            // cmbCadCategoria
            // 
            this.cmbCadCategoria.Enabled = false;
            this.cmbCadCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCadCategoria.FormattingEnabled = true;
            this.cmbCadCategoria.Items.AddRange(new object[] {
            "ALCOOLICO",
            "NÃO ALCOÓLICO",
            "TABACARIA"});
            this.cmbCadCategoria.Location = new System.Drawing.Point(421, 253);
            this.cmbCadCategoria.Name = "cmbCadCategoria";
            this.cmbCadCategoria.Size = new System.Drawing.Size(375, 26);
            this.cmbCadCategoria.TabIndex = 92;
            this.cmbCadCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCadNivel_SelectedIndexChanged);
            // 
            // txtCadDescricao
            // 
            this.txtCadDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCadDescricao.Enabled = false;
            this.txtCadDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadDescricao.Location = new System.Drawing.Point(46, 253);
            this.txtCadDescricao.Name = "txtCadDescricao";
            this.txtCadDescricao.Size = new System.Drawing.Size(277, 26);
            this.txtCadDescricao.TabIndex = 89;
            this.txtCadDescricao.TextChanged += new System.EventHandler(this.txtCadCargo_TextChanged);
            // 
            // txtCadProduto
            // 
            this.txtCadProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCadProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadProduto.Location = new System.Drawing.Point(46, 148);
            this.txtCadProduto.Name = "txtCadProduto";
            this.txtCadProduto.Size = new System.Drawing.Size(750, 26);
            this.txtCadProduto.TabIndex = 88;
            this.txtCadProduto.TextChanged += new System.EventHandler(this.txtCadNome_TextChanged);
            // 
            // lblCadPrecoVenda
            // 
            this.lblCadPrecoVenda.AutoSize = true;
            this.lblCadPrecoVenda.BackColor = System.Drawing.Color.Transparent;
            this.lblCadPrecoVenda.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadPrecoVenda.ForeColor = System.Drawing.Color.White;
            this.lblCadPrecoVenda.Location = new System.Drawing.Point(41, 431);
            this.lblCadPrecoVenda.Name = "lblCadPrecoVenda";
            this.lblCadPrecoVenda.Size = new System.Drawing.Size(207, 27);
            this.lblCadPrecoVenda.TabIndex = 86;
            this.lblCadPrecoVenda.Text = "PREÇO DE VENDA:";
            this.lblCadPrecoVenda.Click += new System.EventHandler(this.lblCadEndereco_Click);
            // 
            // lblCadFornecedor
            // 
            this.lblCadFornecedor.AutoSize = true;
            this.lblCadFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.lblCadFornecedor.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadFornecedor.ForeColor = System.Drawing.Color.White;
            this.lblCadFornecedor.Location = new System.Drawing.Point(347, 431);
            this.lblCadFornecedor.Name = "lblCadFornecedor";
            this.lblCadFornecedor.Size = new System.Drawing.Size(167, 27);
            this.lblCadFornecedor.TabIndex = 83;
            this.lblCadFornecedor.Text = "FORNECEDOR:";
            this.lblCadFornecedor.Click += new System.EventHandler(this.lblCadFacebook_Click);
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
            // lblCadCategoria
            // 
            this.lblCadCategoria.AutoSize = true;
            this.lblCadCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCategoria.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCadCategoria.Location = new System.Drawing.Point(416, 223);
            this.lblCadCategoria.Name = "lblCadCategoria";
            this.lblCadCategoria.Size = new System.Drawing.Size(144, 27);
            this.lblCadCategoria.TabIndex = 79;
            this.lblCadCategoria.Text = "CATEGORIA:";
            this.lblCadCategoria.Click += new System.EventHandler(this.lblCadNivel_Click);
            // 
            // lblCadPrecoCompra
            // 
            this.lblCadPrecoCompra.AutoSize = true;
            this.lblCadPrecoCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblCadPrecoCompra.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadPrecoCompra.ForeColor = System.Drawing.Color.White;
            this.lblCadPrecoCompra.Location = new System.Drawing.Point(572, 323);
            this.lblCadPrecoCompra.Name = "lblCadPrecoCompra";
            this.lblCadPrecoCompra.Size = new System.Drawing.Size(226, 27);
            this.lblCadPrecoCompra.TabIndex = 77;
            this.lblCadPrecoCompra.Text = "PREÇO DE COMPRA:";
            this.lblCadPrecoCompra.Click += new System.EventHandler(this.lblCadEmail_Click);
            // 
            // lblCadDescricao
            // 
            this.lblCadDescricao.AutoSize = true;
            this.lblCadDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblCadDescricao.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadDescricao.ForeColor = System.Drawing.Color.White;
            this.lblCadDescricao.Location = new System.Drawing.Point(41, 223);
            this.lblCadDescricao.Name = "lblCadDescricao";
            this.lblCadDescricao.Size = new System.Drawing.Size(144, 27);
            this.lblCadDescricao.TabIndex = 76;
            this.lblCadDescricao.Text = "DESCRIÇÃO:";
            this.lblCadDescricao.Click += new System.EventHandler(this.lblCadCargo_Click);
            // 
            // lblCadDataRecebimento
            // 
            this.lblCadDataRecebimento.AutoSize = true;
            this.lblCadDataRecebimento.BackColor = System.Drawing.Color.Transparent;
            this.lblCadDataRecebimento.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadDataRecebimento.ForeColor = System.Drawing.Color.White;
            this.lblCadDataRecebimento.Location = new System.Drawing.Point(572, 431);
            this.lblCadDataRecebimento.Name = "lblCadDataRecebimento";
            this.lblCadDataRecebimento.Size = new System.Drawing.Size(237, 27);
            this.lblCadDataRecebimento.TabIndex = 75;
            this.lblCadDataRecebimento.Text = "DATA RECEBIMENTO:";
            this.lblCadDataRecebimento.Click += new System.EventHandler(this.lblCadDataNasc_Click);
            // 
            // lblCadProduto
            // 
            this.lblCadProduto.AutoSize = true;
            this.lblCadProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblCadProduto.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadProduto.ForeColor = System.Drawing.Color.White;
            this.lblCadProduto.Location = new System.Drawing.Point(41, 118);
            this.lblCadProduto.Name = "lblCadProduto";
            this.lblCadProduto.Size = new System.Drawing.Size(230, 27);
            this.lblCadProduto.TabIndex = 74;
            this.lblCadProduto.Text = "NOME DO PRODUTO:";
            this.lblCadProduto.Click += new System.EventHandler(this.lblCadNome_Click);
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
            // mksHoraRecebimento
            // 
            this.mksHoraRecebimento.Enabled = false;
            this.mksHoraRecebimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mksHoraRecebimento.Location = new System.Drawing.Point(46, 571);
            this.mksHoraRecebimento.Mask = "00:00";
            this.mksHoraRecebimento.Name = "mksHoraRecebimento";
            this.mksHoraRecebimento.Size = new System.Drawing.Size(154, 26);
            this.mksHoraRecebimento.TabIndex = 106;
            this.mksHoraRecebimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mksHoraRecebimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblCadRecebimento
            // 
            this.lblCadRecebimento.AutoSize = true;
            this.lblCadRecebimento.BackColor = System.Drawing.Color.Transparent;
            this.lblCadRecebimento.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadRecebimento.ForeColor = System.Drawing.Color.White;
            this.lblCadRecebimento.Location = new System.Drawing.Point(46, 514);
            this.lblCadRecebimento.Name = "lblCadRecebimento";
            this.lblCadRecebimento.Size = new System.Drawing.Size(175, 54);
            this.lblCadRecebimento.TabIndex = 107;
            this.lblCadRecebimento.Text = "HORA \r\nRECEBIMENTO:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(-15, -15);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 108;
            // 
            // nudPrecoCompra
            // 
            this.nudPrecoCompra.Location = new System.Drawing.Point(676, 369);
            this.nudPrecoCompra.Name = "nudPrecoCompra";
            this.nudPrecoCompra.Size = new System.Drawing.Size(120, 20);
            this.nudPrecoCompra.TabIndex = 109;
            // 
            // nudPrecoVenda
            // 
            this.nudPrecoVenda.Location = new System.Drawing.Point(46, 475);
            this.nudPrecoVenda.Name = "nudPrecoVenda";
            this.nudPrecoVenda.Size = new System.Drawing.Size(120, 20);
            this.nudPrecoVenda.TabIndex = 110;
            // 
            // frmProdutoCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adega_Irmandade.Properties.Resources.fundofumacaCad;
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.nudPrecoVenda);
            this.Controls.Add(this.nudPrecoCompra);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblCadRecebimento);
            this.Controls.Add(this.mksHoraRecebimento);
            this.Controls.Add(this.mkdCadDataRecebimento);
            this.Controls.Add(this.btnCadSalvar);
            this.Controls.Add(this.pctFechar);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtCadFornecedor);
            this.Controls.Add(this.cmbCadStatus);
            this.Controls.Add(this.cmbCadCategoria);
            this.Controls.Add(this.txtCadDescricao);
            this.Controls.Add(this.txtCadProduto);
            this.Controls.Add(this.lblCadPrecoVenda);
            this.Controls.Add(this.lblCadFornecedor);
            this.Controls.Add(this.lblCadStatus);
            this.Controls.Add(this.lblCadCategoria);
            this.Controls.Add(this.lblCadPrecoCompra);
            this.Controls.Add(this.lblCadDescricao);
            this.Controls.Add(this.lblCadDataRecebimento);
            this.Controls.Add(this.lblCadProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCadCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProdutoCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdutoCad";
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mkdCadDataRecebimento;
        private System.Windows.Forms.Button btnCadSalvar;
        private System.Windows.Forms.PictureBox pctFechar;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtCadFornecedor;
        private System.Windows.Forms.ComboBox cmbCadStatus;
        private System.Windows.Forms.ComboBox cmbCadCategoria;
        private System.Windows.Forms.TextBox txtCadDescricao;
        private System.Windows.Forms.TextBox txtCadProduto;
        private System.Windows.Forms.Label lblCadPrecoVenda;
        private System.Windows.Forms.Label lblCadFornecedor;
        private System.Windows.Forms.Label lblCadStatus;
        private System.Windows.Forms.Label lblCadCategoria;
        private System.Windows.Forms.Label lblCadPrecoCompra;
        private System.Windows.Forms.Label lblCadDescricao;
        private System.Windows.Forms.Label lblCadDataRecebimento;
        private System.Windows.Forms.Label lblCadProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCadCadastrar;
        private System.Windows.Forms.MaskedTextBox mksHoraRecebimento;
        private System.Windows.Forms.Label lblCadRecebimento;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown nudPrecoCompra;
        private System.Windows.Forms.NumericUpDown nudPrecoVenda;
    }
}