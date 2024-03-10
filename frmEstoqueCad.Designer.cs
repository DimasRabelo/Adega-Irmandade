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
            this.mkdCadDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.mkdCadDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.btnCadSalvar = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmbCadStatus = new System.Windows.Forms.ComboBox();
            this.txtCadNome = new System.Windows.Forms.TextBox();
            this.lblCadFacebook = new System.Windows.Forms.Label();
            this.lblCadStatus = new System.Windows.Forms.Label();
            this.lblCadDataAdmissao = new System.Windows.Forms.Label();
            this.lblCadCargo = new System.Windows.Forms.Label();
            this.lblCadDataNasc = new System.Windows.Forms.Label();
            this.lblCadNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCadCadastrar = new System.Windows.Forms.Label();
            this.mkdCadCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCadCep = new System.Windows.Forms.Label();
            this.cmbCadNivel = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // mkdCadDataAdmissao
            // 
            this.mkdCadDataAdmissao.Enabled = false;
            this.mkdCadDataAdmissao.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdCadDataAdmissao.Location = new System.Drawing.Point(51, 328);
            this.mkdCadDataAdmissao.Mask = "00/00/0000";
            this.mkdCadDataAdmissao.Name = "mkdCadDataAdmissao";
            this.mkdCadDataAdmissao.Size = new System.Drawing.Size(132, 34);
            this.mkdCadDataAdmissao.TabIndex = 107;
            this.mkdCadDataAdmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkdCadDataAdmissao.ValidatingType = typeof(System.DateTime);
            // 
            // mkdCadDataNasc
            // 
            this.mkdCadDataNasc.Enabled = false;
            this.mkdCadDataNasc.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdCadDataNasc.Location = new System.Drawing.Point(665, 201);
            this.mkdCadDataNasc.Mask = "00/00/0000";
            this.mkdCadDataNasc.Name = "mkdCadDataNasc";
            this.mkdCadDataNasc.Size = new System.Drawing.Size(131, 34);
            this.mkdCadDataNasc.TabIndex = 106;
            this.mkdCadDataNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkdCadDataNasc.ValidatingType = typeof(System.DateTime);
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
            this.cmbCadStatus.Location = new System.Drawing.Point(339, 337);
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
            // 
            // lblCadFacebook
            // 
            this.lblCadFacebook.AutoSize = true;
            this.lblCadFacebook.BackColor = System.Drawing.Color.Transparent;
            this.lblCadFacebook.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadFacebook.ForeColor = System.Drawing.Color.White;
            this.lblCadFacebook.Location = new System.Drawing.Point(46, 430);
            this.lblCadFacebook.Name = "lblCadFacebook";
            this.lblCadFacebook.Size = new System.Drawing.Size(123, 27);
            this.lblCadFacebook.TabIndex = 83;
            this.lblCadFacebook.Text = "PRODUTO:";
            // 
            // lblCadStatus
            // 
            this.lblCadStatus.AutoSize = true;
            this.lblCadStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblCadStatus.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadStatus.ForeColor = System.Drawing.Color.White;
            this.lblCadStatus.Location = new System.Drawing.Point(334, 297);
            this.lblCadStatus.Name = "lblCadStatus";
            this.lblCadStatus.Size = new System.Drawing.Size(103, 27);
            this.lblCadStatus.TabIndex = 82;
            this.lblCadStatus.Text = "STATUS:";
            // 
            // lblCadDataAdmissao
            // 
            this.lblCadDataAdmissao.AutoSize = true;
            this.lblCadDataAdmissao.BackColor = System.Drawing.Color.Transparent;
            this.lblCadDataAdmissao.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadDataAdmissao.ForeColor = System.Drawing.Color.White;
            this.lblCadDataAdmissao.Location = new System.Drawing.Point(44, 297);
            this.lblCadDataAdmissao.Name = "lblCadDataAdmissao";
            this.lblCadDataAdmissao.Size = new System.Drawing.Size(233, 27);
            this.lblCadDataAdmissao.TabIndex = 81;
            this.lblCadDataAdmissao.Text = "DATA ATUALIZAÇÃO:";
            // 
            // lblCadCargo
            // 
            this.lblCadCargo.AutoSize = true;
            this.lblCadCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCargo.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCargo.ForeColor = System.Drawing.Color.White;
            this.lblCadCargo.Location = new System.Drawing.Point(41, 179);
            this.lblCadCargo.Name = "lblCadCargo";
            this.lblCadCargo.Size = new System.Drawing.Size(159, 27);
            this.lblCadCargo.TabIndex = 76;
            this.lblCadCargo.Text = "QUANTIDADE:";
            // 
            // lblCadDataNasc
            // 
            this.lblCadDataNasc.AutoSize = true;
            this.lblCadDataNasc.BackColor = System.Drawing.Color.Transparent;
            this.lblCadDataNasc.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadDataNasc.ForeColor = System.Drawing.Color.White;
            this.lblCadDataNasc.Location = new System.Drawing.Point(663, 144);
            this.lblCadDataNasc.Name = "lblCadDataNasc";
            this.lblCadDataNasc.Size = new System.Drawing.Size(136, 54);
            this.lblCadDataNasc.TabIndex = 75;
            this.lblCadDataNasc.Text = "DATA \r\nCADASTRO:";
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
            this.label2.Location = new System.Drawing.Point(237, 27);
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
            this.lblCadCadastrar.Location = new System.Drawing.Point(31, 27);
            this.lblCadCadastrar.Name = "lblCadCadastrar";
            this.lblCadCadastrar.Size = new System.Drawing.Size(178, 40);
            this.lblCadCadastrar.TabIndex = 72;
            this.lblCadCadastrar.Text = "CADASTRAR\r\n";
            this.lblCadCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mkdCadCep
            // 
            this.mkdCadCep.Enabled = false;
            this.mkdCadCep.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdCadCep.Location = new System.Drawing.Point(645, 334);
            this.mkdCadCep.Mask = "00:00";
            this.mkdCadCep.Name = "mkdCadCep";
            this.mkdCadCep.Size = new System.Drawing.Size(154, 29);
            this.mkdCadCep.TabIndex = 108;
            this.mkdCadCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkdCadCep.ValidatingType = typeof(System.DateTime);
            // 
            // lblCadCep
            // 
            this.lblCadCep.AutoSize = true;
            this.lblCadCep.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCep.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCep.ForeColor = System.Drawing.Color.White;
            this.lblCadCep.Location = new System.Drawing.Point(640, 270);
            this.lblCadCep.Name = "lblCadCep";
            this.lblCadCep.Size = new System.Drawing.Size(121, 54);
            this.lblCadCep.TabIndex = 109;
            this.lblCadCep.Text = "HORA \r\nCONTATO:";
            // 
            // cmbCadNivel
            // 
            this.cmbCadNivel.Enabled = false;
            this.cmbCadNivel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCadNivel.FormattingEnabled = true;
            this.cmbCadNivel.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "USUÁRIO"});
            this.cmbCadNivel.Location = new System.Drawing.Point(51, 460);
            this.cmbCadNivel.Name = "cmbCadNivel";
            this.cmbCadNivel.Size = new System.Drawing.Size(435, 26);
            this.cmbCadNivel.TabIndex = 110;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(46, 212);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 111;
            // 
            // frmEstoqueCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Adega_Irmandade.Properties.Resources.fundofumacaCad;
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cmbCadNivel);
            this.Controls.Add(this.lblCadCep);
            this.Controls.Add(this.mkdCadCep);
            this.Controls.Add(this.mkdCadDataAdmissao);
            this.Controls.Add(this.mkdCadDataNasc);
            this.Controls.Add(this.btnCadSalvar);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cmbCadStatus);
            this.Controls.Add(this.txtCadNome);
            this.Controls.Add(this.lblCadFacebook);
            this.Controls.Add(this.lblCadStatus);
            this.Controls.Add(this.lblCadDataAdmissao);
            this.Controls.Add(this.lblCadCargo);
            this.Controls.Add(this.lblCadDataNasc);
            this.Controls.Add(this.lblCadNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCadCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstoqueCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstoqueCad";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mkdCadDataAdmissao;
        private System.Windows.Forms.MaskedTextBox mkdCadDataNasc;
        private System.Windows.Forms.Button btnCadSalvar;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbCadStatus;
        private System.Windows.Forms.TextBox txtCadNome;
        private System.Windows.Forms.Label lblCadFacebook;
        private System.Windows.Forms.Label lblCadStatus;
        private System.Windows.Forms.Label lblCadDataAdmissao;
        private System.Windows.Forms.Label lblCadCargo;
        private System.Windows.Forms.Label lblCadDataNasc;
        private System.Windows.Forms.Label lblCadNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCadCadastrar;
        private System.Windows.Forms.MaskedTextBox mkdCadCep;
        private System.Windows.Forms.Label lblCadCep;
        private System.Windows.Forms.ComboBox cmbCadNivel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}