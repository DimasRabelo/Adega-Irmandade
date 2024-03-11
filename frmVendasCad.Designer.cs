namespace Adega_Irmandade
{
    partial class frmVendasCad
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
            this.mkdCadDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.btnCadSalvar = new System.Windows.Forms.Button();
            this.pctFechar = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmbCadStatus = new System.Windows.Forms.ComboBox();
            this.lblCadStatus = new System.Windows.Forms.Label();
            this.lblCadDataVenda = new System.Windows.Forms.Label();
            this.lblCadNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCadCadastrar = new System.Windows.Forms.Label();
            this.cmbCadFuncionario = new System.Windows.Forms.ComboBox();
            this.mskCadHoraVneda = new System.Windows.Forms.MaskedTextBox();
            this.lblCadHoraVenda = new System.Windows.Forms.Label();
            this.cmbCadVendasProdutos = new System.Windows.Forms.ComboBox();
            this.lblCadVendaProdutos = new System.Windows.Forms.Label();
            this.nudValorVenda = new System.Windows.Forms.NumericUpDown();
            this.lblCadValorVenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // mkdCadDataVenda
            // 
            this.mkdCadDataVenda.Enabled = false;
            this.mkdCadDataVenda.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdCadDataVenda.Location = new System.Drawing.Point(39, 287);
            this.mkdCadDataVenda.Mask = "00/00/0000";
            this.mkdCadDataVenda.Name = "mkdCadDataVenda";
            this.mkdCadDataVenda.Size = new System.Drawing.Size(131, 34);
            this.mkdCadDataVenda.TabIndex = 104;
            this.mkdCadDataVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkdCadDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // btnCadSalvar
            // 
            this.btnCadSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadSalvar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadSalvar.ForeColor = System.Drawing.Color.White;
            this.btnCadSalvar.Location = new System.Drawing.Point(159, 585);
            this.btnCadSalvar.Name = "btnCadSalvar";
            this.btnCadSalvar.Size = new System.Drawing.Size(240, 54);
            this.btnCadSalvar.TabIndex = 103;
            this.btnCadSalvar.Text = "SALVAR";
            this.btnCadSalvar.UseVisualStyleBackColor = false;
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
            this.pctLogo.Location = new System.Drawing.Point(772, 63);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(418, 510);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 101;
            this.pctLogo.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(482, 585);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(240, 54);
            this.btnLimpar.TabIndex = 100;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // cmbCadStatus
            // 
            this.cmbCadStatus.Enabled = false;
            this.cmbCadStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCadStatus.FormattingEnabled = true;
            this.cmbCadStatus.Items.AddRange(new object[] {
            "ATIVO",
            "DESATIVADO"});
            this.cmbCadStatus.Location = new System.Drawing.Point(40, 406);
            this.cmbCadStatus.Name = "cmbCadStatus";
            this.cmbCadStatus.Size = new System.Drawing.Size(204, 26);
            this.cmbCadStatus.TabIndex = 93;
            // 
            // lblCadStatus
            // 
            this.lblCadStatus.AutoSize = true;
            this.lblCadStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblCadStatus.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadStatus.ForeColor = System.Drawing.Color.White;
            this.lblCadStatus.Location = new System.Drawing.Point(39, 368);
            this.lblCadStatus.Name = "lblCadStatus";
            this.lblCadStatus.Size = new System.Drawing.Size(103, 27);
            this.lblCadStatus.TabIndex = 82;
            this.lblCadStatus.Text = "STATUS:";
            // 
            // lblCadDataVenda
            // 
            this.lblCadDataVenda.AutoSize = true;
            this.lblCadDataVenda.BackColor = System.Drawing.Color.Transparent;
            this.lblCadDataVenda.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadDataVenda.ForeColor = System.Drawing.Color.White;
            this.lblCadDataVenda.Location = new System.Drawing.Point(34, 240);
            this.lblCadDataVenda.Name = "lblCadDataVenda";
            this.lblCadDataVenda.Size = new System.Drawing.Size(154, 27);
            this.lblCadDataVenda.TabIndex = 75;
            this.lblCadDataVenda.Text = "DATA VENDA:";
            // 
            // lblCadNome
            // 
            this.lblCadNome.AutoSize = true;
            this.lblCadNome.BackColor = System.Drawing.Color.Transparent;
            this.lblCadNome.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadNome.ForeColor = System.Drawing.Color.White;
            this.lblCadNome.Location = new System.Drawing.Point(154, 142);
            this.lblCadNome.Name = "lblCadNome";
            this.lblCadNome.Size = new System.Drawing.Size(277, 27);
            this.lblCadNome.TabIndex = 74;
            this.lblCadNome.Text = "NOME DO FUNCIONÁRIO:";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 73;
            this.label2.Text = "VENDA\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // 
            // cmbCadFuncionario
            // 
            this.cmbCadFuncionario.Enabled = false;
            this.cmbCadFuncionario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCadFuncionario.FormattingEnabled = true;
            this.cmbCadFuncionario.Items.AddRange(new object[] {
            "ALAN COELHO BUENO",
            "WAGNITON COELHO",
            "ENZO GOUVEIA",
            "RENATO OCELA",
            "MARLENE RABELO",
            "ARTUR ALVIM",
            "BENEOBENES SILVA",
            "LUDMILA RIBEIRO",
            "EMILLY RIBEIRO",
            "GORETE MILAGRES",
            "FERNANDA MELLO",
            "JOÃO ALVARES",
            "DIEGO DA COSTA SILVA",
            "SESHOMARU YAKASHAKY",
            "ZÉ DO CAIXÃO",
            "DIMAS APARECIDO",
            "GABRIEL JESUS",
            "RAMÓN VALDEZ"});
            this.cmbCadFuncionario.Location = new System.Drawing.Point(159, 184);
            this.cmbCadFuncionario.Name = "cmbCadFuncionario";
            this.cmbCadFuncionario.Size = new System.Drawing.Size(475, 26);
            this.cmbCadFuncionario.TabIndex = 106;
            // 
            // mskCadHoraVneda
            // 
            this.mskCadHoraVneda.Enabled = false;
            this.mskCadHoraVneda.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCadHoraVneda.Location = new System.Drawing.Point(577, 292);
            this.mskCadHoraVneda.Mask = "00:00";
            this.mskCadHoraVneda.Name = "mskCadHoraVneda";
            this.mskCadHoraVneda.Size = new System.Drawing.Size(154, 29);
            this.mskCadHoraVneda.TabIndex = 109;
            this.mskCadHoraVneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCadHoraVneda.ValidatingType = typeof(System.DateTime);
            // 
            // lblCadHoraVenda
            // 
            this.lblCadHoraVenda.AutoSize = true;
            this.lblCadHoraVenda.BackColor = System.Drawing.Color.Transparent;
            this.lblCadHoraVenda.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadHoraVenda.ForeColor = System.Drawing.Color.White;
            this.lblCadHoraVenda.Location = new System.Drawing.Point(572, 235);
            this.lblCadHoraVenda.Name = "lblCadHoraVenda";
            this.lblCadHoraVenda.Size = new System.Drawing.Size(92, 54);
            this.lblCadHoraVenda.TabIndex = 110;
            this.lblCadHoraVenda.Text = "HORA \r\nVENDA:";
            // 
            // cmbCadVendasProdutos
            // 
            this.cmbCadVendasProdutos.Enabled = false;
            this.cmbCadVendasProdutos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCadVendasProdutos.FormattingEnabled = true;
            this.cmbCadVendasProdutos.Items.AddRange(new object[] {
            "ORIGINAL269ML",
            "GATORADE500ML",
            "REDLABEL1LT",
            "COCACOLA2LT",
            "SPATEN269ML",
            "WHITEHORSE1LT",
            "CARVÃODECOCOZOMO",
            "AMSTEL269ML",
            "FANTA350ML",
            "H2O500ML",
            "JACK DANIELS"});
            this.cmbCadVendasProdutos.Location = new System.Drawing.Point(159, 502);
            this.cmbCadVendasProdutos.Name = "cmbCadVendasProdutos";
            this.cmbCadVendasProdutos.Size = new System.Drawing.Size(475, 26);
            this.cmbCadVendasProdutos.TabIndex = 111;
            // 
            // lblCadVendaProdutos
            // 
            this.lblCadVendaProdutos.AutoSize = true;
            this.lblCadVendaProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblCadVendaProdutos.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadVendaProdutos.ForeColor = System.Drawing.Color.White;
            this.lblCadVendaProdutos.Location = new System.Drawing.Point(154, 459);
            this.lblCadVendaProdutos.Name = "lblCadVendaProdutos";
            this.lblCadVendaProdutos.Size = new System.Drawing.Size(131, 27);
            this.lblCadVendaProdutos.TabIndex = 112;
            this.lblCadVendaProdutos.Text = "PRODUTOS";
            // 
            // nudValorVenda
            // 
            this.nudValorVenda.Location = new System.Drawing.Point(611, 412);
            this.nudValorVenda.Name = "nudValorVenda";
            this.nudValorVenda.Size = new System.Drawing.Size(120, 20);
            this.nudValorVenda.TabIndex = 113;
            // 
            // lblCadValorVenda
            // 
            this.lblCadValorVenda.AutoSize = true;
            this.lblCadValorVenda.BackColor = System.Drawing.Color.Transparent;
            this.lblCadValorVenda.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadValorVenda.ForeColor = System.Drawing.Color.White;
            this.lblCadValorVenda.Location = new System.Drawing.Point(606, 355);
            this.lblCadValorVenda.Name = "lblCadValorVenda";
            this.lblCadValorVenda.Size = new System.Drawing.Size(91, 54);
            this.lblCadValorVenda.TabIndex = 114;
            this.lblCadValorVenda.Text = "VALOR \r\nVENDA";
            // 
            // frmVendasCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adega_Irmandade.Properties.Resources.fundofumacaCad;
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.lblCadValorVenda);
            this.Controls.Add(this.nudValorVenda);
            this.Controls.Add(this.lblCadVendaProdutos);
            this.Controls.Add(this.cmbCadVendasProdutos);
            this.Controls.Add(this.lblCadHoraVenda);
            this.Controls.Add(this.mskCadHoraVneda);
            this.Controls.Add(this.cmbCadFuncionario);
            this.Controls.Add(this.mkdCadDataVenda);
            this.Controls.Add(this.btnCadSalvar);
            this.Controls.Add(this.pctFechar);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cmbCadStatus);
            this.Controls.Add(this.lblCadStatus);
            this.Controls.Add(this.lblCadDataVenda);
            this.Controls.Add(this.lblCadNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCadCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVendasCad";
            this.Text = "frmVendasCad";
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mkdCadDataVenda;
        private System.Windows.Forms.Button btnCadSalvar;
        private System.Windows.Forms.PictureBox pctFechar;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbCadStatus;
        private System.Windows.Forms.Label lblCadStatus;
        private System.Windows.Forms.Label lblCadDataVenda;
        private System.Windows.Forms.Label lblCadNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCadCadastrar;
        private System.Windows.Forms.ComboBox cmbCadFuncionario;
        private System.Windows.Forms.MaskedTextBox mskCadHoraVneda;
        private System.Windows.Forms.Label lblCadHoraVenda;
        private System.Windows.Forms.ComboBox cmbCadVendasProdutos;
        private System.Windows.Forms.Label lblCadVendaProdutos;
        private System.Windows.Forms.NumericUpDown nudValorVenda;
        private System.Windows.Forms.Label lblCadValorVenda;
    }
}