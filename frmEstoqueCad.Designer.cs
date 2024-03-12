namespace Adega_Irmandade
{
    partial class frmEstoqueCad
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
            this.btnCadSalvar = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmbCadStatus = new System.Windows.Forms.ComboBox();
            this.txtCadNome = new System.Windows.Forms.TextBox();
            this.lblCadProdutos = new System.Windows.Forms.Label();
            this.lblCadStatus = new System.Windows.Forms.Label();
            this.lblCadQuantidade = new System.Windows.Forms.Label();
            this.lblCadNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCadCadastrar = new System.Windows.Forms.Label();
            this.cmbCadProduto = new System.Windows.Forms.ComboBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.pctFechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadSalvar
            // 
            this.btnCadSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadSalvar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadSalvar.ForeColor = System.Drawing.Color.White;
            this.btnCadSalvar.Location = new System.Drawing.Point(46, 573);
            this.btnCadSalvar.Name = "btnCadSalvar";
            this.btnCadSalvar.Size = new System.Drawing.Size(300, 72);
            this.btnCadSalvar.TabIndex = 105;
            this.btnCadSalvar.Text = "SALVAR";
            this.btnCadSalvar.UseVisualStyleBackColor = false;
            this.btnCadSalvar.Click += new System.EventHandler(this.btnCadSalvar_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = global::Adega_Irmandade.Properties.Resources.adegalogo_2;
            this.pctLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctLogo.Location = new System.Drawing.Point(896, 54);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(294, 471);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 104;
            this.pctLogo.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(499, 573);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(300, 72);
            this.btnLimpar.TabIndex = 103;
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
            this.cmbCadStatus.Location = new System.Drawing.Point(595, 240);
            this.cmbCadStatus.Name = "cmbCadStatus";
            this.cmbCadStatus.Size = new System.Drawing.Size(204, 26);
            this.cmbCadStatus.TabIndex = 96;
            
            // 
            // txtCadNome
            // 
            this.txtCadNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCadNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadNome.Location = new System.Drawing.Point(46, 105);
            this.txtCadNome.Name = "txtCadNome";
            this.txtCadNome.Size = new System.Drawing.Size(750, 26);
            this.txtCadNome.TabIndex = 91;
            this.txtCadNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCadNome_KeyPress);
            // 
            // lblCadProdutos
            // 
            this.lblCadProdutos.AutoSize = true;
            this.lblCadProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblCadProdutos.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadProdutos.ForeColor = System.Drawing.Color.White;
            this.lblCadProdutos.Location = new System.Drawing.Point(39, 380);
            this.lblCadProdutos.Name = "lblCadProdutos";
            this.lblCadProdutos.Size = new System.Drawing.Size(123, 27);
            this.lblCadProdutos.TabIndex = 83;
            this.lblCadProdutos.Text = "PRODUTO:";
            // 
            // lblCadStatus
            // 
            this.lblCadStatus.AutoSize = true;
            this.lblCadStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblCadStatus.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadStatus.ForeColor = System.Drawing.Color.White;
            this.lblCadStatus.Location = new System.Drawing.Point(590, 212);
            this.lblCadStatus.Name = "lblCadStatus";
            this.lblCadStatus.Size = new System.Drawing.Size(103, 27);
            this.lblCadStatus.TabIndex = 82;
            this.lblCadStatus.Text = "STATUS:";
            // 
            // lblCadQuantidade
            // 
            this.lblCadQuantidade.AutoSize = true;
            this.lblCadQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCadQuantidade.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblCadQuantidade.Location = new System.Drawing.Point(39, 212);
            this.lblCadQuantidade.Name = "lblCadQuantidade";
            this.lblCadQuantidade.Size = new System.Drawing.Size(159, 27);
            this.lblCadQuantidade.TabIndex = 76;
            this.lblCadQuantidade.Text = "QUANTIDADE:";
            // 
            // lblCadNome
            // 
            this.lblCadNome.AutoSize = true;
            this.lblCadNome.BackColor = System.Drawing.Color.Transparent;
            this.lblCadNome.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadNome.ForeColor = System.Drawing.Color.White;
            this.lblCadNome.Location = new System.Drawing.Point(41, 75);
            this.lblCadNome.Name = "lblCadNome";
            this.lblCadNome.Size = new System.Drawing.Size(82, 27);
            this.lblCadNome.TabIndex = 74;
            this.lblCadNome.Text = "NOME:";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(223, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 73;
            this.label2.Text = "ESTOQUE\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCadCadastrar
            // 
            this.lblCadCadastrar.AllowDrop = true;
            this.lblCadCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCadastrar.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCadastrar.ForeColor = System.Drawing.Color.White;
            this.lblCadCadastrar.Location = new System.Drawing.Point(39, 19);
            this.lblCadCadastrar.Name = "lblCadCadastrar";
            this.lblCadCadastrar.Size = new System.Drawing.Size(178, 40);
            this.lblCadCadastrar.TabIndex = 72;
            this.lblCadCadastrar.Text = "CADASTRAR\r\n";
            this.lblCadCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbCadProduto
            // 
            this.cmbCadProduto.Enabled = false;
            this.cmbCadProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCadProduto.FormattingEnabled = true;
            this.cmbCadProduto.Items.AddRange(new object[] {
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
            this.cmbCadProduto.Location = new System.Drawing.Point(35, 410);
            this.cmbCadProduto.Name = "cmbCadProduto";
            this.cmbCadProduto.Size = new System.Drawing.Size(435, 26);
            this.cmbCadProduto.TabIndex = 110;
          
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(46, 246);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 20);
            this.nudQuantidade.TabIndex = 111;
           
            // 
            // pctFechar
            // 
            this.pctFechar.BackColor = System.Drawing.Color.Transparent;
            this.pctFechar.Image = global::Adega_Irmandade.Properties.Resources.botaoFechar;
            this.pctFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctFechar.Location = new System.Drawing.Point(1151, 12);
            this.pctFechar.Name = "pctFechar";
            this.pctFechar.Size = new System.Drawing.Size(39, 30);
            this.pctFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFechar.TabIndex = 112;
            this.pctFechar.TabStop = false;
            this.pctFechar.Click += new System.EventHandler(this.pctFechar_Click);
            // 
            // frmEstoqueCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adega_Irmandade.Properties.Resources.fundofumacaCad;
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.pctFechar);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.cmbCadProduto);
            this.Controls.Add(this.btnCadSalvar);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cmbCadStatus);
            this.Controls.Add(this.txtCadNome);
            this.Controls.Add(this.lblCadProdutos);
            this.Controls.Add(this.lblCadStatus);
            this.Controls.Add(this.lblCadQuantidade);
            this.Controls.Add(this.lblCadNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCadCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstoqueCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstoqueCad";
            this.Load += new System.EventHandler(this.frmEstoqueCad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadSalvar;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbCadStatus;
        private System.Windows.Forms.TextBox txtCadNome;
        private System.Windows.Forms.Label lblCadProdutos;
        private System.Windows.Forms.Label lblCadStatus;
        private System.Windows.Forms.Label lblCadQuantidade;
        private System.Windows.Forms.Label lblCadNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCadCadastrar;
        private System.Windows.Forms.ComboBox cmbCadProduto;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.PictureBox pctFechar;
    }
}